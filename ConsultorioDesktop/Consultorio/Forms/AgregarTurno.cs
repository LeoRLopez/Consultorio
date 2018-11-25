using Consultorio.Modelo;
using Consultorio.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web.Helpers;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace Consultorio
{
    public partial class AgregarTurno : Form
    {
        private int horaTurno;
        private int minutosTurno;
        private bool __turnoAgregado = false;
        private string _bodyTemplate =
        @"<h2>Detalles del Turno</h2>
            <div>
                <hr />
                <dl class='dl-horizontal'>
                    <dt>Fecha y Hora</dt>
                    <dd><strong>{0}</strong></dd>
                    <dt>Paciente</dt>
                    <dd><strong>{1}</strong></dd>
                    <dt>Médico</dt>
                    <dd><strong>{2}</strong></dd>
                    <dt>Especialidad</dt>
                    <dd><strong>{3}</strong></dd>
                    <dt>Matricula</dt>
                    <dd><strong>{4}</strong></dd>
                    <dt>Forma de Pago</dt>
                    <dd><strong>{5}</strong></dd>
                    <dt>Precio</dt>
                    <dd><strong>{6}</strong></dd>
                    <dt>Seguro Médico</dt>
                    <dd><strong>{7}</strong></dd>
                    <dt>Servicio Extra</dt>
                    <dd><strong>{8}</strong></dd>
                    <dt>Descripción Servicio Extra</dt>
                    <dd><strong>{9}</strong></dd>
                </dl>
            </div><hr />";

        public AgregarTurno()
        {
            InitializeComponent();
            dtpFechaTurno.MinDate = DateTime.Now.Date; // No se puede sacar un turno para "ayer"
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            if (!ValidarCamposObligatorios())
                return;

            var fechaTurno = new DateTime(dtpFechaTurno.Value.Year, dtpFechaTurno.Value.Month, dtpFechaTurno.Value.Day, horaTurno, minutosTurno, 0);
            if (!ValidarFechaDelTurno(fechaTurno))
                return;

            try
            {
                var nuevoTurno = new Turno
                {
                    Atendido = false,
                    FechaYHora = fechaTurno,
                    Asistio = false,
                    IdPaciente = (int)dropDownListaPacientes.SelectedValue,
                    IdMedico = ((MedicoVM)dgvMedicos.CurrentRow.DataBoundItem).MedicoId,
                    IdEspecialidadMedico = (int)dropDownEspecialidades.SelectedValue,
                    PrecioTurno = decimal.Parse(tbPrecioTurno.Text),
                    Descripcion = tbDescripcion.Text,
                    IdFormaDePago = radiobtnParticular.IsChecked ? 1 /*Particular*/ : 2 /*Seguro Médico*/,
                    IdSeguroMedico = radioBtnSeguroMedico.IsChecked ? (Nullable<int>)dropDownSegurosMedicos.SelectedValue : null,
                };

                using (var entidades = new ClinicaEntities())
                {
                    using (var entidadesTransaction = entidades.Database.BeginTransaction())
                    {
                        try
                        {
                            entidades.Turno.Add(nuevoTurno);
                            entidades.SaveChanges();
                            EnviarNotificacionesPorEmail(entidades, nuevoTurno.IdTurno);
                            entidadesTransaction.Commit();
                            MessageBox.Show("Turno creado y notificación por Correo electrónico enviada!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (MessageBox.Show("Desea agregar otro Turno?", "TurnARG", MessageBoxButtons.YesNo) == DialogResult.No)
                            {
                                __turnoAgregado = true;
                                this.Close();
                            }
                            else
                            {
                                LimpiarRegistros();
                            }
                        }
                        catch (Exception ex)
                        {
                            entidadesTransaction.Rollback();
                            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarFechaDelTurno(DateTime fechaTurno)
        {
            if (fechaTurno.Date > DateTime.Now.Date.AddDays(7))
            {
                MessageBox.Show("Los turnos no pueden darse con más de una semana de anticipación", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }

        private bool EnviarNotificacionesPorEmail(ClinicaEntities db, int idTurno)
        {
            var turnoDB = db.Turno.Include(t => t.Especialidad).Include(t => t.FormaDePago).Include(t => t.Medico).Include(m => m.Medico.PersonalInterno).Include(t => t.Paciente).Include(t => t.SegurosMedico).First(x => x.IdTurno == idTurno);

            var emailSubject = string.Format("Nuevo Turno para el {0} a las {1} hs.", turnoDB.FechaYHora.ToString("dd/MM/yyyy"), turnoDB.FechaYHora.ToString("HH:mm"));
            var emailBody = string.Format(_bodyTemplate,
                turnoDB.FechaYHora.ToString("dd/MM/yyyy HH:mm"),
                turnoDB.Paciente.Apellidos + ", " + turnoDB.Paciente.Nombres,
                turnoDB.Medico.PersonalInterno.Single().Apellido + ", " + turnoDB.Medico.PersonalInterno.Single().Nombre,
                turnoDB.Especialidad.Nombre,
                turnoDB.Medico.MatriculaMedico,
                turnoDB.FormaDePago.Nombre,
                turnoDB.PrecioTurno,
                turnoDB.SegurosMedico == null ? "-" : turnoDB.SegurosMedico.Nombre,
                turnoDB.ServicioExtra == null ? "" : turnoDB.ServicioExtra.Nombre,
                turnoDB.Descripcion ?? "");

            var pacienteEmail = turnoDB.Paciente.Email;
            var emailPacienteModel = new EmailModel { ToEmail = pacienteEmail, EmailSubject = emailSubject, EMailBody = emailBody };
            var emailPacienteEnviado = EnviarEmail(emailPacienteModel);

            var medicoEmail = turnoDB.Medico.PersonalInterno.First().Email;
            var emailMedicoModel = new EmailModel { ToEmail = medicoEmail, EmailSubject = emailSubject, EMailBody = emailBody };
            var emailMedicoEnviado = EnviarEmail(emailMedicoModel);

            return emailPacienteEnviado.Item1 && emailMedicoEnviado.Item1;
        }

        private Tuple<bool, string> EnviarEmail(EmailModel email)
        {
            try
            {
                //Configuring webMail class to send emails  
                //gmail smtp server  
                WebMail.SmtpServer = "smtp.gmail.com";
                //gmail port to send emails  
                WebMail.SmtpPort = 587;
                WebMail.SmtpUseDefaultCredentials = true;
                //sending emails with secure protocol  
                WebMail.EnableSsl = true;
                //EmailId used to send emails from application  
                WebMail.UserName = "sagrada.familia.notificaciones@gmail.com";
                WebMail.Password = "S4gr4d4123.";

                //Sender email address.  
                WebMail.From = "sagrada.familia.notificaciones@gmail.com";

                //Send email  
                WebMail.Send(to: email.ToEmail, subject: email.EmailSubject, body: email.EMailBody, cc: email.EmailCC, bcc: email.EmailBCC, isBodyHtml: true);
            }
            catch (Exception ex)
            {
                return new Tuple<bool, string>(false, "Problema al enviar el correo electrónico. Por favor verifique los detalles: " + Environment.NewLine + ex.Message);
            }
            return new Tuple<bool, string>(true, "Correo electrónico enviado con Éxito.");
        }

        private void LimpiarRegistros()
        {
            dropDownListaPacientes.SelectedIndex = 0;
            dropDownSegurosMedicos.SelectedIndex = 0;
            tbDescripcion.Clear();
            radiobtnParticular.CheckState = CheckState.Checked;
            radioBtnSeguroMedico.CheckState = CheckState.Unchecked;
        }

        private void NuevoTurno_Load(object sender, EventArgs e)
        {
            CargarMedicos();
            CargarPacientes();
            CargarSegurosMedico();
            FiltrarCargarHorariosMedicoEnDropDown();
            CargarEspecialidesEnDropDown();
        }

        private void CargarSegurosMedico()
        {
            using (var entidades = new ClinicaEntities())
            {
                dropDownSegurosMedicos.ValueMember = "IdSeguroMedico";
                dropDownSegurosMedicos.DisplayMember = "Nombre";
                var segurosMedico = new List<SegurosMedico> { new SegurosMedico { IdSeguroMedico = -1, Nombre = "Seleccione un Seguro" } };
                segurosMedico.AddRange(entidades.SegurosMedico.OrderBy(x => x.Nombre).ToList());
                dropDownSegurosMedicos.DataSource = segurosMedico;
            }
        }

        private void CargarPacientes()
        {
            using (var entidades = new ClinicaEntities())
            {
                dropDownListaPacientes.ValueMember = "IdPaciente";
                dropDownListaPacientes.DisplayMember = "NombreCompleto";
                var pacientes = new List<PacienteDropDownVM> { new PacienteDropDownVM { IdPaciente = -1, NombreCompleto = "Seleccione un Paciente" } };
                pacientes.AddRange(entidades.Paciente.Select(paciente =>
                new PacienteDropDownVM
                {
                    IdPaciente = paciente.IdPaciente,
                    NombreCompleto = paciente.Apellidos + ", " + paciente.Nombres
                }).OrderBy(x => x.NombreCompleto).ToList());
                dropDownListaPacientes.DataSource = pacientes;
            }
        }

        private void CargarMedicos()
        {
            using (var entidades = new ClinicaEntities())
            {
                medicoVMBindingSource.DataSource = entidades.Medico.Select(medico =>
                new MedicoVM
                {
                    MedicoId = medico.IdMedico,
                    Matricula = medico.MatriculaMedico,
                    NombreCompleto = medico.PersonalInterno.FirstOrDefault().Apellido + ", " + medico.PersonalInterno.FirstOrDefault().Nombre,
                    LunesHorario = medico.Horario.Nombre,
                    MartesHorario = medico.Horario1.Nombre,
                    MiercolesHorario = medico.Horario2.Nombre,
                    JuevesHorario = medico.Horario3.Nombre,
                    ViernesHorario = medico.Horario4.Nombre,
                    SabadoHorario = medico.Horario5.Nombre,
                    DomingoHorario = medico.Horario6.Nombre,
                    EspecialidadesMedicoVM = medico.MedicoEspecialidad.Select(x =>
                        new EspecialidadMedicoVM
                        {
                            EspecialidadId = x.Especialidad.EspecialidadId,
                            NombrePrecio = x.Especialidad.Nombre + " $" + x.Especialidad.PrecioPorDefecto.ToString(),
                            Precio = x.Especialidad.PrecioPorDefecto
                        }).ToList()
                }).ToList();
            }
        }

        private void radioBtnSeguroMedico_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            dropDownSegurosMedicos.Enabled = radioBtnSeguroMedico.IsChecked;
        }

        private bool ValidarCamposObligatorios()
        {
            var idPacienteSeleccionado = (int)dropDownListaPacientes.SelectedValue;
            var idMedicoSeleccionado = -1;
            if (dgvMedicos.CurrentRow != null)
                idMedicoSeleccionado = ((MedicoVM)dgvMedicos.CurrentRow.DataBoundItem).MedicoId;
            var idEspecialidadSeleccionada = (int)dropDownEspecialidades.SelectedValue;

            decimal precioTurno = -1;

            if (idPacienteSeleccionado == -1 || idMedicoSeleccionado == -1 || idEspecialidadSeleccionada == -1 || !decimal.TryParse(tbPrecioTurno.Text, out precioTurno))
            {
                if (idPacienteSeleccionado == -1)
                    errorProvider.SetError(dropDownListaPacientes, "Debe seleccionar un Paciente");

                if (idMedicoSeleccionado == -1)
                    errorProvider.SetError(labelMedico, "Debe seleccionar un Medico");

                if (idEspecialidadSeleccionada == -1)
                    errorProvider.SetError(dropDownEspecialidades, "Debe seleccionar una Especialidad");

                if (!decimal.TryParse(tbPrecioTurno.Text, out precioTurno))
                    errorProvider.SetError(tbPrecioTurno, "Precio Inválido");

                return false;
            }

            if (dropDownHoraTurno.Text != "-")
            {
                if (!int.TryParse(dropDownHoraTurno.Text.Substring(0, 2), out horaTurno))
                {
                    errorProvider.SetError(dropDownHoraTurno, "Hora Inválida");
                    return false;
                }

                if (!int.TryParse(dropDownHoraTurno.Text.Substring(3, 2), out minutosTurno))
                {
                    errorProvider.SetError(dropDownHoraTurno, "Minutos Inválidos");
                    return false;
                }
            }
            else
            {
                errorProvider.SetError(dropDownHoraTurno, "Horario Inválido");
                return false;
            }
    
            if (radioBtnSeguroMedico.IsChecked)
            {
                var idSeguroSeleccionado = (int)dropDownSegurosMedicos.SelectedValue;
                if (idSeguroSeleccionado == -1)
                {
                    errorProvider.SetError(dropDownSegurosMedicos, "Debe seleccionar un Seguro");
                    return false;
                }
            }

            return true;
        }

        private void dgvMedicos_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            FiltrarCargarHorariosMedicoEnDropDown();
            CargarEspecialidesEnDropDown();
        }

        private void CargarEspecialidesEnDropDown()
        {
            tbPrecioTurno.Clear();
            if (dgvMedicos.CurrentRow != null)
            {
                var medicoSeleccionado = ((MedicoVM)dgvMedicos.CurrentRow.DataBoundItem);
                dropDownEspecialidades.ValueMember = "EspecialidadId";
                dropDownEspecialidades.DisplayMember = "NombrePrecio";
                var especialidades = new List<EspecialidadMedicoVM> { new EspecialidadMedicoVM { EspecialidadId = -1, NombrePrecio = "Seleccione una Especialidad" } };
                especialidades.AddRange(medicoSeleccionado.EspecialidadesMedicoVM);
                dropDownEspecialidades.DataSource = especialidades;
            }
        }

        private void FiltrarCargarHorariosMedicoEnDropDown()
        {
            if (dgvMedicos.CurrentRow != null)
            {
                List<string> horarios = new List<string>();
                var medicoSeleccionado = ((MedicoVM)dgvMedicos.CurrentRow.DataBoundItem);
                switch (dtpFechaTurno.Value.DayOfWeek)
                {
                    case DayOfWeek.Monday:
                        horarios = ObtenerHorariosPorDia(medicoSeleccionado.LunesHorario);
                        break;
                    case DayOfWeek.Tuesday:
                        horarios = ObtenerHorariosPorDia(medicoSeleccionado.MartesHorario);
                        break;
                    case DayOfWeek.Wednesday:
                        horarios = ObtenerHorariosPorDia(medicoSeleccionado.MiercolesHorario);
                        break;
                    case DayOfWeek.Thursday:
                        horarios = ObtenerHorariosPorDia(medicoSeleccionado.JuevesHorario);
                        break;
                    case DayOfWeek.Friday:
                        horarios = ObtenerHorariosPorDia(medicoSeleccionado.ViernesHorario);
                        break;
                    case DayOfWeek.Saturday:
                        horarios = ObtenerHorariosPorDia(medicoSeleccionado.SabadoHorario);
                        break;
                    case DayOfWeek.Sunday:
                        horarios = ObtenerHorariosPorDia(medicoSeleccionado.DomingoHorario);
                        break;
                }
                List<string> turnosOcupadosDelDia = new List<string>();
                using (var entidades = new ClinicaEntities())
                {
                    turnosOcupadosDelDia =
                             entidades.Turno.Where(x => x.IdMedico == medicoSeleccionado.MedicoId && EntityFunctions.TruncateTime(x.FechaYHora) == dtpFechaTurno.Value.Date)
                                            .ToList().Select(x => x.FechaYHora.ToString("HH:mm")).ToList();
                }
                dropDownHoraTurno.DataSource = horarios.Except(turnosOcupadosDelDia).ToList(); ;
            }
        }

        private List<string> ObtenerHorariosPorDia(string horarioDelDia)
        {
            switch (horarioDelDia)
            {
                case "No Atiende":
                    return new List<string> { "-" };
                case "Mañana y Tarde":
                    return new List<string> { "08:00", "08:15", "08:30", "08:45", "09:00", "09:15", "09:30", "09:45", "10:00", "10:15", "10:30", "10:45", "11:00", "11:15", "11:30", "11:45",
                                              "16:00", "16:15", "16:30", "16:45", "17:00", "17:15", "17:30", "17:45", "18:00", "18:15", "18:30", "18:45", "19:00", "19:15", "19:30", "19:45", "20:00", "20:15" };
                case "Mañana":
                    return new List<string> { "08:00", "08:15", "08:30", "08:45", "09:00", "09:15", "09:30", "09:45", "10:00", "10:15", "10:30", "10:45", "11:00", "11:15", "11:30", "11:45" };
                case "Tarde":
                    return new List<string> { "16:00", "16:15", "16:30", "16:45", "17:00", "17:15", "17:30", "17:45", "18:00", "18:15", "18:30", "18:45", "19:00", "19:15", "19:30", "19:45", "20:00", "20:15" };
            }
            return new List<string> { "-" };
        }

        private void dateTimePickerTurno_ValueChanged(object sender, EventArgs e)
        {
            FiltrarCargarHorariosMedicoEnDropDown();
        }

        private void NuevoTurno_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!__turnoAgregado)
            {
                if (MessageBox.Show("¿Esta seguro que desea salir?.Los datos no guardados se perderán.", "TurnARG",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void radTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as RadTextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void dropDownEspecialidades_SelectedValueChanged(object sender, EventArgs e)
        {
            var dropDownEspecialidades = (RadDropDownList)sender;
            if (dropDownEspecialidades.SelectedItem != null)
            {
                var especialidadSeleccionada = (EspecialidadMedicoVM)dropDownEspecialidades.SelectedItem.DataBoundItem;
                if (especialidadSeleccionada.EspecialidadId != -1)
                {
                    tbPrecioTurno.Text = especialidadSeleccionada.Precio.ToString("0.##");
                }
            }
        }
    }
}
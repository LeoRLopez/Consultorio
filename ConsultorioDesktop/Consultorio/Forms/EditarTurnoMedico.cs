using Consultorio.Modelo;
using Consultorio.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace Consultorio
{
    public partial class EditarTurnoMedico : Form
    {
        private Turno _turnoOriginal;
        private int horaTurno;
        private int minutosTurno;
        private bool _turnoFueModificado = false;

        public EditarTurnoMedico(int idTurno)
        {
            InitializeComponent();
            dtpFechaTurno.MinDate = DateTime.Now.Date; // No se puede sacar un turno para "ayer"
            using (var entidades = new ClinicaEntities())
            {
                this._turnoOriginal = entidades.Turno.Include(x => x.FormaDePago).Include(x => x.Medico).Include(x => x.Paciente)
                    .Include(x => x.Medico).Include(x => x.SegurosMedico).Include(x => x.Especialidad)
                    .First(x => x.IdTurno == idTurno);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            using (var entidades = new ClinicaEntities())
            {
                using (var entidadesTransaction = entidades.Database.BeginTransaction())
                {
                    try
                    {
                        var turnoDB = entidades.Turno.Single(x => x.IdTurno == this._turnoOriginal.IdTurno);
                        turnoDB.Atendido = chbAtendido.Checked;
                        turnoDB.Asistio = chbAsistio.Checked;
                        turnoDB.Descripcion = txtBoxNotas.Text;
                        turnoDB.Diagnostico = textboxDiagnostico.Text;
                        entidades.SaveChanges();
                        entidadesTransaction.Commit();
                        MessageBox.Show("Turno actualizado.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _turnoFueModificado = true;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        entidadesTransaction.Rollback();
                        MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void NuevoTurno_Load(object sender, EventArgs e)
        {
            CargarMedicos();
            CargarPacientes();
            CargarSegurosMedico();
            FiltrarCargarHorariosMedicoEnDropDown();
            CargarEspecialidesEnDropDown();
            CargarDatosEnPantalla();
        }
        private void CargarDatosEnPantalla()
        {
            try
            {
                using (var entidades = new ClinicaEntities())
                {
                    var turno = entidades.Turno.Include(x => x.FormaDePago).Include(x => x.Medico).Include(x => x.Paciente)
                        .Include(x => x.Medico).Include(x => x.SegurosMedico).Include(x => x.Especialidad)
                        .First(x => x.IdTurno == this._turnoOriginal.IdTurno);

                    dropDownListaPacientes.SelectedValue = turno.IdPaciente;
                    foreach (DataGridViewRow row in dgvMedicos.Rows)
                    {
                        // Index 0 es MedicoId
                        if (row.Cells[0].Value.ToString().Equals(turno.IdMedico.ToString()))
                        {
                            dgvMedicos.CurrentCell = dgvMedicos.Rows[row.Index].Cells[1];
                            row.Selected = true;
                            break;
                        }
                    }

                    chbAtendido.Checked = turno.Atendido;
                    chbAsistio.Checked = turno.Asistio;
                    dtpFechaTurno.Value = turno.FechaYHora.Date;
                    dropDownHoraTurno.SelectedValue = turno.FechaYHora.ToString("HH:mm");
                    CargarEspecialidesEnDropDown();
                    dropDownEspecialidades.SelectedValue = turno.IdEspecialidadMedico;
                    tbPrecioTurno.Text = turno.PrecioTurno.ToString("0.##");
                    radiobtnParticular.IsChecked = turno.IdFormaDePago == 1;/*Particular*/
                    radioBtnSeguroMedico.IsChecked = turno.IdFormaDePago == 2;/*Seguro Médico*/
                    dropDownSegurosMedicos.SelectedValue = turno.IdSeguroMedico;
                    txtBoxNotas.Text = turno.Descripcion;
                    textboxDiagnostico.Text = turno.Diagnostico;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    errorProvider.SetError(dgvMedicos, "Debe seleccionar un Medico");

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
            if (!_turnoFueModificado)
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
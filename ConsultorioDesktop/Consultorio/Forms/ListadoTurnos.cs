using Consultorio.Forms;
using Consultorio.Modelo;
using Consultorio.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Consultorio.Reportes
{
    public partial class ListadoTurnos : Form
    {
        private bool __esAdministrador = false;
        private int __idMedico;

        public ListadoTurnos(bool esAdministrador, int idMedico)
        {
            InitializeComponent();
            dtpDesde.Value = DateTime.Now.Date;
            dtpHasta.Value = DateTime.Now.AddMonths(1).Date;
            this.__esAdministrador = esAdministrador;
            this.__idMedico = idMedico;
            if (!esAdministrador)
            {
                btnAgregar.Visible = false;
                btnEliminar.Visible = false;
                dropDownMedicos.Enabled = false;
                btnFacturar.Visible = false;
            }
        }

        private void Pacientes_Load(object sender, EventArgs e)
        {
            CargarTurnos();
            CargarFormasDePago();
            CargarMedicos();
            CargarSegurosMedico();
        }

        private void CargarTurnos()
        {
            using (var entidades = new ClinicaEntities())
            {
                var turnos = new List<Turno>();
                if (this.__esAdministrador)
                {
                    turnos = entidades.Turno.ToList();
                }
                else if (this.__idMedico != -1)
                {
                    turnos = entidades.Turno.Where(x => x.IdMedico == this.__idMedico && (!x.Atendido && !x.Asistio)).ToList();
                }
                var __pacientesTurnoVM = new List<PacienteTurnoVM>();
                pacienteTurnoVMBindingSource.DataSource = turnos.Select(turno =>
                                    new PacienteTurnoVM
                                    {
                                        TurnoId = turno.IdTurno,
                                        PacienteId = turno.IdPaciente,
                                        MedicoId = turno.IdMedico,
                                        IdSeguroMedico = turno.IdSeguroMedico,
                                        PacienteNombreCompleto = turno.Paciente.Apellidos + ", " + turno.Paciente.Nombres,
                                        Edad = turno.Paciente.Edad.ToString(),
                                        MedicoNombreCompleto = turno.Medico.PersonalInterno.FirstOrDefault().Apellido + ", " + turno.Medico.PersonalInterno.FirstOrDefault().Nombre,
                                        NombreSeguroMedico = turno.SegurosMedico != null ? turno.SegurosMedico.Nombre : "",
                                        Asistio = turno.Asistio,
                                        Atendido = turno.Atendido,
                                        Descripcion = turno.Descripcion,
                                        Diagnostico = turno.Diagnostico,
                                        FechaHoraTurno = turno.FechaYHora,
                                        FormaDePagoId = turno.IdFormaDePago,
                                        FormaDePagoNombre = turno.FormaDePago.Nombre,
                                        Pagado = turno.IdFactura != null,
                                        PrecioTurno = turno.PrecioTurno
                                    }).OrderBy(x => x.FechaHoraTurno).ToList();
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            using (var entidades = new ClinicaEntities())
            {
                var turnos = new List<Turno>();

                // Si selecciona un medico tenemos que ir a buscar todos los turnos de ese medico
                if ((int)dropDownMedicos.SelectedValue != -1)
                {
                    foreach (var turno in entidades.Turno.Where(x => x.IdMedico == (int)dropDownMedicos.SelectedValue).ToList())
                    {
                        turnos.Add(turno);
                    }
                }
                else
                {
                    // caso contrario, solo traemos todos los turnos
                    turnos = entidades.Turno.ToList();
                }

                // Si selecciona una forma de pago, volvemos a filtrar la lista
                if ((int)dropDownFormasDePago.SelectedValue != -1)
                {
                    turnos = turnos.Where(x => x.IdFormaDePago == (int)dropDownFormasDePago.SelectedValue).ToList();
                }

                // Si selecciona un seguro medico, volvemos a filtrar la lista
                if ((int)dropDownSegurosMedicos.SelectedValue != -1)
                {
                    turnos = turnos.Where(x => x.IdSeguroMedico == (int)dropDownSegurosMedicos.SelectedValue).ToList();
                }

                // Lo mismo para la fecha Desde
                if (dtpDesde.Checked)
                {
                    turnos = turnos.Where(x => x.FechaYHora.Date >= dtpDesde.Value.Date).ToList();
                }

                // Igual para Hasta
                if (dtpHasta.Checked)
                {
                    turnos = turnos.Where(x => x.FechaYHora.Date <= dtpHasta.Value.Date).ToList();
                }

                if (!this.__esAdministrador)
                {
                    turnos = turnos.Where(x => x.IdMedico == this.__idMedico).ToList();
                }

                pacienteTurnoVMBindingSource.DataSource = turnos.Select(turno =>
                                new PacienteTurnoVM
                                {
                                    TurnoId = turno.IdTurno,
                                    PacienteId = turno.IdPaciente,
                                    MedicoId = turno.IdMedico,
                                    IdSeguroMedico = turno.IdSeguroMedico,
                                    PacienteNombreCompleto = turno.Paciente.Apellidos + ", " + turno.Paciente.Nombres,
                                    Edad = turno.Paciente.Edad.ToString(),
                                    MedicoNombreCompleto = turno.Medico.PersonalInterno.FirstOrDefault().Apellido + ", " + turno.Medico.PersonalInterno.FirstOrDefault().Nombre,
                                    NombreSeguroMedico = turno.SegurosMedico != null ? turno.SegurosMedico.Nombre : "",
                                    Asistio = turno.Asistio,
                                    Atendido = turno.Atendido,
                                    Descripcion = turno.Descripcion,
                                    Diagnostico = turno.Diagnostico,
                                    FechaHoraTurno = turno.FechaYHora,
                                    FormaDePagoId = turno.IdFormaDePago,
                                    FormaDePagoNombre = turno.FormaDePago.Nombre,
                                    Pagado = turno.IdFactura != null,
                                    PrecioTurno = turno.PrecioTurno
                                }).OrderBy(x => x.FechaHoraTurno).ToList();
            }
        }

        private void CargarSegurosMedico()
        {
            using (var entidades = new ClinicaEntities())
            {
                dropDownSegurosMedicos.ValueMember = "IdSeguroMedico";
                dropDownSegurosMedicos.DisplayMember = "Nombre";
                var segurosMedico = new List<SegurosMedico> { new SegurosMedico { IdSeguroMedico = -1, Nombre = "Todos los Seguros" } };
                segurosMedico.AddRange(entidades.SegurosMedico.OrderBy(x => x.Nombre).ToList());
                dropDownSegurosMedicos.DataSource = segurosMedico;
            }
        }

        private void CargarMedicos()
        {
            using (var entidades = new ClinicaEntities())
            {
                dropDownMedicos.ValueMember = "MedicoId";
                dropDownMedicos.DisplayMember = "NombreCompleto";
                var medicos = new List<MedicoVM> { new MedicoVM { MedicoId = -1, NombreCompleto = "Todos los Medicos" } };
                medicos.AddRange(entidades.Medico.Select(medico =>
                new MedicoVM
                {
                    MedicoId = medico.IdMedico,
                    Matricula = medico.MatriculaMedico,
                    NombreCompleto = medico.PersonalInterno.FirstOrDefault().Apellido + ", " + medico.PersonalInterno.FirstOrDefault().Nombre //+ " (" + medico.Especialidad + ")"
                }).OrderBy(x => x.NombreCompleto).ToList());
                dropDownMedicos.DataSource = medicos;
            }
        }

        private void CargarFormasDePago()
        {
            using (var entidades = new ClinicaEntities())
            {
                dropDownFormasDePago.ValueMember = "IdFormaDePago";
                dropDownFormasDePago.DisplayMember = "Nombre";
                var formasDePago = new List<FormaDePago> { new FormaDePago { IdFormaDePago = -1, Nombre = "Todas las Forma de Pago" } };
                formasDePago.AddRange(entidades.FormaDePago.OrderBy(x => x.Nombre).ToList());
                dropDownFormasDePago.DataSource = formasDePago;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarTurno nuevoTurno = new AgregarTurno();
            nuevoTurno.ShowDialog();
            CargarTurnos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvPacienteMedicoTurno.CurrentRow != null)
            {
                var turnoSeleccionado = ((PacienteTurnoVM)dgvPacienteMedicoTurno.CurrentRow.DataBoundItem);
                if (this.__esAdministrador)
                {
                    EditarTurnoAdmin formEditarTurnoAdmin = new EditarTurnoAdmin(turnoSeleccionado.TurnoId, __esAdministrador);
                    formEditarTurnoAdmin.ShowDialog();
                }
                else if (this.__idMedico != -1)
                {
                    EditarTurnoMedico formEditarTurnoMedico = new EditarTurnoMedico(turnoSeleccionado.TurnoId);
                    formEditarTurnoMedico.ShowDialog();
                }
                CargarTurnos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var respuestaUsuario = MessageBox.Show("Está seguro que desea eliminar el Turno?", "Confirmación ",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuestaUsuario == DialogResult.Yes)
            {
                try
                {
                    if (dgvPacienteMedicoTurno.CurrentRow != null)
                    {
                        var turnoSeleccionado = ((PacienteTurnoVM)dgvPacienteMedicoTurno.CurrentRow.DataBoundItem);
                        using (var entidades = new ClinicaEntities())
                        {
                            var turnoDB = entidades.Turno.First(x => x.IdTurno == turnoSeleccionado.TurnoId);
                            entidades.Turno.Remove(turnoDB);
                            entidades.SaveChanges();
                            CargarTurnos();
                            MessageBox.Show("Turno eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar una fila", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            if (dgvPacienteMedicoTurno.CurrentRow != null)
            {
                var turnoSeleccionado = ((PacienteTurnoVM)dgvPacienteMedicoTurno.CurrentRow.DataBoundItem);
                if (!turnoSeleccionado.Pagado)
                {
                    var deseaFacturarDialog = MessageBox.Show("Desea Facturar el Turno?", "Factura", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (deseaFacturarDialog == DialogResult.Yes)
                    {
                        var factura = new Factura
                        {
                            IdTurno = turnoSeleccionado.TurnoId,
                            Fecha = DateTime.Now,
                            IdFormaDePago = turnoSeleccionado.FormaDePagoId,
                            Monto = turnoSeleccionado.PrecioTurno
                        };
                        var formFacturacion = new AgregarFactura(factura);
                        formFacturacion.ShowDialog();
                    }
                    CargarTurnos();
                }
                else
                {
                    MessageBox.Show("El turno seleccionado ya ha sido Facturado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
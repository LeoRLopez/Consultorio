using Consultorio.Modelo;
using Consultorio.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls.Export;

namespace Consultorio.Reportes
{
    public partial class ReporteListadoTurnos : Form
    {
        public ReporteListadoTurnos()
        {
            InitializeComponent();
            dtpDesde.Value = DateTime.Now.Date;
            dtpHasta.Value = DateTime.Now.AddMonths(1).Date;
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
                pacienteTurnoVMBindingSource.DataSource = entidades.Turno.Select(turno =>
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
                                Pagado = turno.IdFactura != null
                            }).OrderBy(x => x.FechaHoraTurno).ToList();
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            using (var entidades = new ClinicaEntities())
            {
                var turnos = new List<Turno>(); ;

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
                                    Pagado = turno.IdFactura != null
                                }).OrderBy(x => x.FechaHoraTurno).ToList();
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            GridViewSpreadExport spreadExporter = new GridViewSpreadExport(this.dgvPacienteMedicoTurno, SpreadExportFormat.Xlsx);
            SpreadExportRenderer exportRenderer = new SpreadExportRenderer();
            var rutaEscritorioWindows = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            try
            {
                spreadExporter.RunExport(rutaEscritorioWindows + "\\Listado de Turnos.xlsx", exportRenderer, "Listado de Pacientes");
                MessageBox.Show("Listado de Turnos.xlsx guardado en el Escritorio", "Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Reporte", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
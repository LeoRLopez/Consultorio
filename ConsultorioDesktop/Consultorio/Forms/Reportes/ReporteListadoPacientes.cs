using Consultorio.Helpers;
using Consultorio.Modelo;
using Consultorio.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls.Export;

namespace Consultorio.Reportes
{
    public partial class ReporteListadoPacientes : Form
    {
        public ReporteListadoPacientes()
        {
            InitializeComponent();
        }

        private void Pacientes_Load(object sender, EventArgs e)
        {
            CargarPacientes();
            CargarFormasDePago();
            CargarMedicos();
            CargarSegurosMedico();
        }

        private void CargarPacientes()
        {
            using (var entidades = new ClinicaEntities())
            {
                pacienteVMBindingSource.DataSource = entidades.Paciente.ToList().Select(paciente =>
                new PacienteVM
                {
                    PacienteId = paciente.IdPaciente,
                    Edad = paciente.Edad.ToString(),
                    IdHistoriasClinicas = paciente.HistoriaClinica.Select(x => x.IdHistoriaClinica).ToList(),
                    NombreCompleto = paciente.Apellidos + ", " + paciente.Nombres,
                    NroDocumento = paciente.NumeroDocumento.ToString(),
                    Telefono = paciente.TelCelular,
                    Direccion = paciente.Direccion,
                    Email = paciente.Email,
                    Sexo = paciente.Sexo,
                    Donante = paciente.Donante ?? false,
                    Trasplantado = paciente.Transplantado ?? false
                }).ToList();
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            using (var entidades = new ClinicaEntities())
            {
                var pacientes = new List<Paciente>(); ;

                // Si selecciona un medico tenemos que ir a buscar todos los turnos de ese medico
                // y seleccionar los pacientes asociados a los mismos.
                if ((int)dropDownMedicos.SelectedValue != -1)
                {
                    foreach (var turno in entidades.Turno.Where(x => x.IdMedico == (int)dropDownMedicos.SelectedValue).DistinctBy(x => x.IdPaciente).ToList())
                    {
                        pacientes.Add(turno.Paciente);
                    }
                }
                else
                {
                    // caso contrario, solo traemos todos los pacientess de la tabla Paciente
                    pacientes = entidades.Paciente.ToList();
                }

                // Si selecciona una forma de pago, volvemos a filtrar la lista
                if ((int)dropDownFormasDePago.SelectedValue != -1)
                {
                    pacientes = pacientes.Where(x => x.IdFormaPagoPorDefecto == (int)dropDownFormasDePago.SelectedValue).ToList();
                }

                // Si selecciona un seguro medico, volvemos a filtrar la lista
                if ((int)dropDownSegurosMedicos.SelectedValue != -1)
                {
                    pacientes = pacientes.Where(x => x.IdSeguroMedico == (int)dropDownSegurosMedicos.SelectedValue).ToList();
                }

                pacienteVMBindingSource.DataSource = pacientes.Select(paciente =>
                 new PacienteVM
                 {
                     PacienteId = paciente.IdPaciente,
                     Edad = paciente.Edad.ToString(),
                     IdHistoriasClinicas = paciente.HistoriaClinica.Select(x=>x.IdHistoriaClinica).ToList(),
                     NombreCompleto = paciente.Apellidos + ", " + paciente.Nombres,
                     NroDocumento = paciente.NumeroDocumento.ToString(),
                     Telefono = paciente.TelCelular,
                     Direccion = paciente.Direccion,
                     Email = paciente.Email,
                     Sexo = paciente.Sexo
                 }).ToList();
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            GridViewSpreadExport spreadExporter = new GridViewSpreadExport(this.dgvPacientes, SpreadExportFormat.Xlsx);
            SpreadExportRenderer exportRenderer = new SpreadExportRenderer();
            var rutaEscritorioWindows = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            try
            {
                spreadExporter.RunExport(rutaEscritorioWindows + "\\Listado de Pacientes.xlsx", exportRenderer, "Listado de Pacientes");
                MessageBox.Show("Listado de Pacientes.xlsx guardado en el Escritorio", "Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
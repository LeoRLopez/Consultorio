using Consultorio.Modelo;
using Consultorio.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Consultorio
{
    public partial class ListadoPacientes : Form
    {
        private bool __esAdministrador = false;
        private int __idMedico;

        public ListadoPacientes(bool esAdministrador, int idMedico)
        {
            InitializeComponent();
            this.__esAdministrador = esAdministrador;
            this.__idMedico = idMedico;
        }

        private void btnRegistrarNuevoPaciente_Click(object sender, EventArgs e)
        {
            NuevoPaciente nuevoPaciente = new NuevoPaciente();
            nuevoPaciente.ShowDialog();
        }

        private void Pacientes_Load(object sender, EventArgs e)
        {
            using (var entidades = new ClinicaEntities())
            {
                var pacientes = new List<PacienteVM>();
                pacientes.AddRange(entidades.Paciente.Select(paciente =>
                new PacienteVM
                {
                    PacienteId = paciente.IdPaciente,
                    Edad = paciente.Edad.ToString(),
                    IdHistoriaClinica = paciente.IdHistoriaClinica,
                    NombreCompleto = paciente.Apellidos + ", " + paciente.Nombres,
                    NroDocumento = paciente.NumeroDocumento.ToString(),
                    Telefono = paciente.TelCelular,
                    Direccion = paciente.Direccion
                }).ToList());

                pacienteVMBindingSource.DataSource = pacientes;
            }
        }

        private void dgvPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPacientes.CurrentRow != null)
            {
                lblnombreApellido.Text = ((PacienteVM)dgvPacientes.CurrentRow.DataBoundItem).NombreCompleto;
                lblEdadSexo.Text = ((PacienteVM)dgvPacientes.CurrentRow.DataBoundItem).Edad;
                lblTelefono.Text = ((PacienteVM)dgvPacientes.CurrentRow.DataBoundItem).Telefono;
                lblDireccion.Text = ((PacienteVM)dgvPacientes.CurrentRow.DataBoundItem).Direccion;
                txtDiagnostico.Enabled = true;
                txtHistoriaClinica.Enabled = true;
                txtHistoriaClinica.Text = ((PacienteVM)dgvPacientes.CurrentRow.DataBoundItem).AntecedentesMedicos;
            }
        }

        private void btnCompletarConsulta_Click(object sender, EventArgs e)
        {

        }
    }
}
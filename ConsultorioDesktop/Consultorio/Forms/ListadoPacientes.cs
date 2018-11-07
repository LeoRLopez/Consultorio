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
            RefrescarDataGridViewPacientes();
        }

        private void RefrescarDataGridViewPacientes()
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
                    Direccion = paciente.Direccion,
                    Email = paciente.Email,
                    Sexo = paciente.Sexo
                }).ToList());

                pacienteVMBindingSource.DataSource = pacientes;
            }
        }

        private void dgvPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPacientes.CurrentRow != null)
            {
                var pacienteSeleccionado = ((PacienteVM)dgvPacientes.CurrentRow.DataBoundItem);
                lblNombreApellido.Text = pacienteSeleccionado.NombreCompleto;
                lblEdadSexo.Text = pacienteSeleccionado.Edad;
                lblTelefono.Text = pacienteSeleccionado.Telefono;
                lblDireccion.Text = pacienteSeleccionado.Direccion;
                txtDiagnostico.Enabled = true;
                txtHistoriaClinica.Enabled = true;
                txtHistoriaClinica.Text = pacienteSeleccionado.AntecedentesMedicos;
                lblGrupoSanguineo.Text = pacienteSeleccionado.GrupoSanguineo;

                if (pacienteSeleccionado.Trasplantado)
                {
                    lblTrasplantado.Text = "Es trasplantado";
                }
                else
                {
                    lblTrasplantado.Text = "No es trasplantado";
                }

                if (pacienteSeleccionado.Donante)
                {
                    lblDonante.Text = "Es donante";
                }
                else
                {
                    lblDonante.Text = "No es donante";
                }
            }
        }

        private void btnEditarPaciente_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.CurrentRow != null)
            {
                int idPacienteSeleccionado = ((PacienteVM)dgvPacientes.CurrentRow.DataBoundItem).PacienteId;
                var formEditarPaciente = new EditarPaciente(idPacienteSeleccionado);
                formEditarPaciente.ShowDialog();
                RefrescarDataGridViewPacientes();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            var formNuevoPaciente = new NuevoPaciente();
            formNuevoPaciente.ShowDialog();
            RefrescarDataGridViewPacientes();
        }
    }
}
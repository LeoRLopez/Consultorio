﻿using Consultorio.Helpers;
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

            btnEditarPaciente.Visible = esAdministrador;
            btnNuevoPaciente.Visible = esAdministrador;
        }

        private void btnRegistrarNuevoPaciente_Click(object sender, EventArgs e)
        {
            AgregarPaciente nuevoPaciente = new AgregarPaciente();
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
                var pacientes = new List<Paciente>();
                if (__idMedico == -1)
                {
                    pacientes = entidades.Paciente.ToList();
                }
                else
                {
                    var turnosMedicos = entidades.Turno.Where(x => x.IdMedico == __idMedico).ToList().Where(x => x.Atendido != false).ToList();
                    var idPacientes = turnosMedicos.DistinctBy(x => x.IdPaciente).Select(x => x.IdPaciente).ToList();
                    pacientes = entidades.Paciente.Where(x => idPacientes.Contains(x.IdPaciente)).ToList();
                }

                var pacientesVM = new List<PacienteVM>();
                pacientesVM.AddRange(pacientes.Select(paciente =>
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
                    GrupoSanguineo = paciente.GrupoSanguineo,
                    Donante = paciente.Donante ?? false,
                    Trasplantado = paciente.Transplantado ?? false
                }).ToList());

                pacienteVMBindingSource.DataSource = pacientesVM;
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

        private void btnNuevoPaciente_Click(object sender, EventArgs e)
        {
            var formNuevoPaciente = new AgregarPaciente();
            formNuevoPaciente.ShowDialog();
            RefrescarDataGridViewPacientes();
        }

        private void dgvPacientes_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (dgvPacientes.CurrentRow != null)
            {
                var pacienteSeleccionado = ((PacienteVM)dgvPacientes.CurrentRow.DataBoundItem);
                lblNombreApellido.Text = pacienteSeleccionado.NombreCompleto;
                lblEdadSexo.Text = pacienteSeleccionado.Edad;
                lblTelefono.Text = pacienteSeleccionado.Telefono;
                lblDireccion.Text = pacienteSeleccionado.Direccion;
                lblGrupoSanguineo.Text = "Grupo y factor sanguíneo: " + pacienteSeleccionado.GrupoSanguineo;

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

                CargarHistoriasClinicas(pacienteSeleccionado.PacienteId);
            }
        }

        private void CargarHistoriasClinicas(int idPaciente)
        {
            using (var entidades = new ClinicaEntities())
            {
                historiaClinicaBindingSource.DataSource = entidades.HistoriaClinica.Where(x => x.IdPaciente == idPaciente).OrderByDescending(x => x.FechaAtencion).ToList();
            }
        }
    }
}
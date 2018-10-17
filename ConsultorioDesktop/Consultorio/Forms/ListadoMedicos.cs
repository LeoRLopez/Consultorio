using Consultorio.Modelo;
using Consultorio.ViewModels;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Consultorio
{
    public partial class Medico : Form
    {
        public Medico()
        {
            InitializeComponent();
        }

        private void Medicos_Load(object sender, System.EventArgs e)
        {
            CargarMedicos();
        }

        private void CargarMedicos()
        {
            using (var entidades = new ClinicaEntities())
            {
                medicoVMBindingSource.DataSource = entidades.Medico.Select(medico =>
                new MedicoVM
                {
                    MedicoId = medico.IdMedico,
                    NombreCompleto = medico.PersonalInterno.FirstOrDefault().Apellido + ", " + medico.PersonalInterno.FirstOrDefault().Nombre,
                    //Especialidad = medico.Especialidad,
                    LunesHorario = medico.Horario.Nombre,
                    MartesHorario = medico.Horario1.Nombre,
                    MiercolesHorario = medico.Horario2.Nombre,
                    JuevesHorario = medico.Horario3.Nombre,
                    ViernesHorario = medico.Horario4.Nombre,
                    SabadoHorario = medico.Horario5.Nombre,
                    DomingoHorario = medico.Horario6.Nombre
                }).ToList();
            }
        }

        private void CargarPacientes(int idMedico)
        {
            using (var entidades = new ClinicaEntities())
            {
                var pacientes = new List<PacienteVM>();

                foreach (var turno in entidades.Turno.Where(turno => turno.IdMedico == idMedico).ToList())
                {
                    pacientes.Add(new PacienteVM
                    {
                        PacienteId = turno.Paciente.IdPaciente,
                        Edad = turno.Paciente.Edad.ToString(),
                        IdHistoriaClinica = turno.Paciente.IdHistoriaClinica,
                        NombreCompleto = turno.Paciente.Apellidos + ", " + turno.Paciente.Nombres,
                        NroDocumento = turno.Paciente.NumeroDocumento.ToString(),
                        Telefono = turno.Paciente.TelCelular
                    });
                }
                pacienteVMBindingSource.DataSource = pacientes;
                pacienteVMBindingSource.ResetBindings(false);
            }
        }

        private void dgvMedicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMedicos.CurrentRow != null)
            {
                int idMedicoSeleccionado = ((MedicoVM)dgvMedicos.CurrentRow.DataBoundItem).MedicoId;
                CargarPacientes(idMedicoSeleccionado);
            }
        }
    }
}
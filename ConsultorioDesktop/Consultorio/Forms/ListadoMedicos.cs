using Consultorio.Modelo;
using Consultorio.ViewModels;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using Consultorio.Helpers;

namespace Consultorio
{
    public partial class ListadoMedicos : Form
    {
        public ListadoMedicos()
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
                medicoVMBindingSource.DataSource = entidades.Medico.Include(x => x.MedicoEspecialidad).Select(medico =>
                  new MedicoVM
                  {
                      MedicoId = medico.IdMedico,
                      Matricula = medico.MatriculaMedico,
                      NombreCompleto = medico.PersonalInterno.FirstOrDefault().Apellido + ", " + medico.PersonalInterno.FirstOrDefault().Nombre,
                      EspecialidadesMedicoVM = medico.MedicoEspecialidad.Select(x => new EspecialidadMedicoVM
                      {
                          EspecialidadId = x.EspecialidadId,
                          NombrePrecio = x.Especialidad.Nombre,
                          Precio = x.Especialidad.PrecioPorDefecto
                      }).ToList(),
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
                        IdHistoriasClinicas = turno.Paciente.HistoriaClinica.Select(x=>x.IdHistoriaClinica).ToList(),
                        NombreCompleto = turno.Paciente.Apellidos + ", " + turno.Paciente.Nombres,
                        NroDocumento = turno.Paciente.NumeroDocumento.ToString(),
                        Telefono = turno.Paciente.TelCelular,
                        Email = turno.Paciente.Email,
                        Sexo = turno.Paciente.Sexo
                    });
                }
                // Usamos DistinctBy() para No mostrar Pacientes repetidos,
                // sino una sola fila para el mismo paciente que pudo haber sido atentido varias veces
                pacienteVMBindingSource.DataSource = pacientes.DistinctBy(x => x.PacienteId);
                pacienteVMBindingSource.ResetBindings(false);
            }
        }

        private void dgvMedicos_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (dgvMedicos.CurrentRow != null)
            {
                int idMedicoSeleccionado = ((MedicoVM)dgvMedicos.CurrentRow.DataBoundItem).MedicoId;
                CargarPacientes(idMedicoSeleccionado);
            }
        }
    }
}
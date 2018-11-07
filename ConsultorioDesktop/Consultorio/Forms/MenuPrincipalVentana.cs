using Consultorio.Modelo;
using Consultorio.ViewModels;
using System;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Windows.Forms;


namespace Consultorio
{
    public partial class MenuPrincipalVentana : Form
    {
        public MenuPrincipalVentana()
        {
            InitializeComponent();
        }

        private void btnRegistrarNuevoPaciente_Click(object sender, EventArgs e)
        {
            NuevoPaciente nuevoPaciente = new NuevoPaciente();
            nuevoPaciente.ShowDialog();
        }

        private void btnNuevoTurno_Click(object sender, EventArgs e)
        {
            NuevoTurno nuevoTurno = new NuevoTurno();
            nuevoTurno.ShowDialog();
            CargarTurnosEnPantalla();
        }

        private void VentanaInicio_Load(object sender, EventArgs e)
        {
            CargarTurnosEnPantalla();
        }

        private void CargarTurnosEnPantalla()
        {
            using (var entidades = new ClinicaEntities())
            {
                var turnosHoy = entidades.Turno.Where(turno => EntityFunctions.TruncateTime(turno.FechaYHora) == DateTime.Today.Date).OrderBy(x => x.FechaYHora).ToList();
                pacienteTurnoVMBindingSource.DataSource = turnosHoy.Select(turno => new PacienteTurnoVM
                {
                    PacienteId = turno.Paciente.IdPaciente,
                    TurnoId = turno.IdTurno,
                    MedicoId = turno.IdMedico,
                    Edad = turno.Paciente.Edad.ToString(),
                    PacienteNombreCompleto = turno.Paciente.Apellidos + ", " + turno.Paciente.Nombres,
                    MedicoNombreCompleto = turno.Medico.PersonalInterno.FirstOrDefault().Apellido + ", " + turno.Medico.PersonalInterno.FirstOrDefault().Nombre,
                    Especialidad = turno.Especialidad.Nombre,
                    FechaHoraTurno = turno.FechaYHora
                }).OrderBy(x => x.FechaHoraTurno).ThenBy(x => x.MedicoNombreCompleto).ThenBy(x => x.PacienteNombreCompleto).ThenBy(x => x.Edad);
                lblTotalTurnosHoy.Text = turnosHoy.Count.ToString();
                if (turnosHoy.Any())
                {
                    labelHoyPrimerTurno.Text = "Primero a las " + turnosHoy.First().FechaYHora.ToString("HH:mm");
                    labelHoyUltimoTurno.Text = "Último a las " + turnosHoy.Last().FechaYHora.ToString("HH:mm");
                }

                var mañana = DateTime.Today.AddDays(1).Date;
                var turnosMañana = entidades.Turno.Where(turno => EntityFunctions.TruncateTime(turno.FechaYHora) == mañana).OrderBy(x => x.FechaYHora).ToList();
                lblToralTurnosManiana.Text = turnosMañana.Count.ToString();
                if (turnosMañana.Any())
                {
                    labelManianaPrimerTurno.Text = "Primero a las " + turnosMañana.First().FechaYHora.ToString("HH:mm");
                    labelManianaUltimoTurno.Text = "Último a las " + turnosMañana.Last().FechaYHora.ToString("HH:mm");
                }
            }
        }
    }
}
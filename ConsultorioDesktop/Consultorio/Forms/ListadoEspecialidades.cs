using Consultorio.Forms;
using Consultorio.Modelo;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Consultorio
{
    public partial class ListadoEspecialidades : Form
    {
        public ListadoEspecialidades(bool __esAdministrador)
        {
            InitializeComponent();
        }

        public ListadoEspecialidades()
        {
            InitializeComponent();
        }

        private void ListadoDeEspecialidades_Load(object sender, EventArgs e)
        {
            RefrescarGridView();
        }

        private void RefrescarGridView()
        {
            using (var entidades = new ClinicaEntities())
            {
                especialidadBindingSource.DataSource = entidades.Especialidad.ToList().Select(x => new Especialidad
                {
                    EspecialidadId = x.EspecialidadId,
                    Nombre = x.Nombre,
                    PrecioPorDefecto = x.PrecioPorDefecto,
                    BajaLogica = !x.BajaLogica
                }).ToList();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxBuscar.Text))
            {
                // Retornar todos los registros porque no escribio nada para buscar
                RefrescarGridView();
                return;
            }
            using (var entidades = new ClinicaEntities())
            {
                especialidadBindingSource.DataSource = entidades.Especialidad.Where(
                    x => x.BajaLogica == false && x.Nombre.ToLower().Contains(txtBoxBuscar.Text.ToLower())).ToList();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var agregarEspecialidad = new AgregarEditarEspecialidad();
            agregarEspecialidad.ShowDialog();
            RefrescarGridView();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvEspecialidades.CurrentRow != null)
            {
                Especialidad especialidadSeleccionada = ((Especialidad)dgvEspecialidades.CurrentRow.DataBoundItem);
                var editarEspecialidad = new AgregarEditarEspecialidad(especialidadSeleccionada);
                editarEspecialidad.ShowDialog();
                RefrescarGridView();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnHabilitarDeshabilitar_Click(object sender, EventArgs e)
        {
            if (dgvEspecialidades.CurrentRow != null)
            {
                Especialidad especialidadSeleccionada = ((Especialidad)dgvEspecialidades.CurrentRow.DataBoundItem);
                using (var entidades = new ClinicaEntities())
                {
                    var especialidadDB = entidades.Especialidad.First(x => x.EspecialidadId == especialidadSeleccionada.EspecialidadId);
                    especialidadDB.BajaLogica = especialidadSeleccionada.BajaLogica;

                    entidades.SaveChanges();
                    MessageBox.Show("Realizado Correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefrescarGridView();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
using Consultorio.Modelo;
using System;
using System.Windows.Forms;

namespace Consultorio.Forms
{
    public partial class ListadoPersonalInterno : Form
    {
        public ListadoPersonalInterno()
        {
            InitializeComponent();
        }

        private void Forma_Pago_Load(object sender, EventArgs e)
        {
            RefrescarGridView();
        }

        private void RefrescarGridView()
        {
            using (var entidades = new ClinicaEntities())
            {
                
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

            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            var agregarEspecialidad = new AgregarEditarEspecialidad();
            agregarEspecialidad.ShowDialog();
            RefrescarGridView();
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (dgvPersonalInterno.CurrentRow != null)
            {
                PersonalInterno personalInternoSeleccionado = ((PersonalInterno)dgvPersonalInterno.CurrentRow.DataBoundItem);
                var editarEspecialidad = new EditarPersonalInterno(personalInternoSeleccionado.IdPersonal);
                editarEspecialidad.ShowDialog();
                RefrescarGridView();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            // Chequear si no se esta usando se setea a TRUE la columna BajaLogica, 
            // de lo contrario se muestra por pantalla un msj de que esta en uso
            //if (dgvEspecialidades.CurrentRow != null)
            //{
            //    Especialidad especialidadSeleccionada = ((Especialidad)dgvEspecialidades.CurrentRow.DataBoundItem);
            //    using (var entidades = new ClinicaEntities())
            //    {
            //        if (entidades.MedicoEspecialidad.Any(x => x.EspecialidadId == especialidadSeleccionada.EspecialidadId))
            //        {
            //            MessageBox.Show("No se puede eliminar esta especialidad ya que esta siendo utilizada por un medico", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        }
            //        else
            //        {
            //            var especialidadDB = entidades.Especialidad.First(x => x.EspecialidadId == especialidadSeleccionada.EspecialidadId);
            //            especialidadDB.BajaLogica = true;
            //            entidades.SaveChanges();
            //            MessageBox.Show("Especialidad eliminada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            RefrescarGridView();
            //        }
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Debe seleccionar una fila", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }
    }
}

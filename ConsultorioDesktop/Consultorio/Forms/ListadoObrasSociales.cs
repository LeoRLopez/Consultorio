using Consultorio.Forms;
using Consultorio.Modelo;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Consultorio
{
    public partial class ListadoObrasSociales : Form
    {
        public ListadoObrasSociales()
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
                segurosMedicoBindingSource.DataSource = entidades.SegurosMedico.Where(x => x.BajaLogica == false).ToList();
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
                segurosMedicoBindingSource.DataSource = entidades.SegurosMedico.Where(x => x.Nombre.ToLower().Contains(txtBoxBuscar.Text.ToLower())).ToList();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var agregarObraSocial = new AgregarEditarObraSocial();
            agregarObraSocial.ShowDialog();
            RefrescarGridView();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(dgvObrasSociales.CurrentRow != null)
            {
                SegurosMedico segurosMedicoSeleccionado = ((SegurosMedico)dgvObrasSociales.CurrentRow.DataBoundItem);
                var editarObraSocial = new AgregarEditarObraSocial(segurosMedicoSeleccionado);
                editarObraSocial.ShowDialog();
                RefrescarGridView();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Chequear si no se esta usando se setea a TRUE la columna BajaLogica, 
            // de lo contrario se muestra por pantalla un msj de que esta en uso
            if (dgvObrasSociales.CurrentRow != null)
            {
                SegurosMedico seguroMedicoSeleccionado = ((SegurosMedico)dgvObrasSociales.CurrentRow.DataBoundItem);
                using (var entidades = new ClinicaEntities())
                {
                    var SeguroMedicoDB = entidades.SegurosMedico.First(x => x.IdSeguroMedico == seguroMedicoSeleccionado.IdSeguroMedico);
                    SeguroMedicoDB.BajaLogica = true;
                    entidades.SaveChanges();
                    MessageBox.Show("Especialidad eliminada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
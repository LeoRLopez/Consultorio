using Consultorio.Modelo;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Consultorio.Forms
{
    public partial class ListadoBancos : Form
    {
        public ListadoBancos()
        {
            InitializeComponent();
        } 

        private void RefrescarGridView()
        {
            using (var entidades = new ClinicaEntities())
            {
                bancosBindingSource.DataSource = entidades.Bancos.Where(x => x.BajaLogica == false).ToList();
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
                bancosBindingSource.DataSource = entidades.Especialidad.Where(x => x.BajaLogica == false && x.Nombre.ToLower().Contains(txtBoxBuscar.Text.ToLower())).ToList();
            }
        }
   
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var agregarBanco = new AgregarEditarBancos();
            agregarBanco.ShowDialog();
            RefrescarGridView();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListadoBancos_Load(object sender, EventArgs e)
        {
            RefrescarGridView();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Crear Formulario para Añadir/Editar Registro
            if (dgvBancos.CurrentRow != null)
            {
                Bancos bancoSeleccionado = ((Bancos)dgvBancos.CurrentRow.DataBoundItem);
                var editarBanco = new AgregarEditarBancos(bancoSeleccionado);
                editarBanco.ShowDialog();
                RefrescarGridView();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvBancos.CurrentRow != null)
            {
                Bancos bancoSeleccionado = ((Bancos)dgvBancos.CurrentRow.DataBoundItem);
                using (var entidades = new ClinicaEntities())
                {
                    var bancoDB = entidades.Bancos.First(x => x.IdBanco == bancoSeleccionado.IdBanco);
                    bancoDB.BajaLogica = true;
                    entidades.SaveChanges();
                    MessageBox.Show("Banco Deshabilitado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefrescarGridView();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

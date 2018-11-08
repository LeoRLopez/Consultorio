using Consultorio.Modelo;
using System;
using System.Windows.Forms;

namespace Consultorio.Forms
{
    public partial class ListadoBancos : Form
    {
        public ListadoBancos()
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Crear Formulario para Añadir/Editar Registro
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Chequear si no se esta usando se setea a TRUE la columna BajaLogica, 
            // de lo contrario se muestra por pantalla un msj de que esta en uso
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
    }
}

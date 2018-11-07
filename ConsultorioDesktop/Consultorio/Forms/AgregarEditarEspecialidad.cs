using Consultorio.Modelo;
using System;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace Consultorio.Forms
{
    public partial class AgregarEditarEspecialidad : Form
    {
        private bool __esAgregar;
        private int __idEspecialidadEditandose;

        public AgregarEditarEspecialidad()
        {
            InitializeComponent();
            this.Text = "Agregar Especialidad";
            this.__esAgregar = true;
        }

        public AgregarEditarEspecialidad(Especialidad especialidad)
        {
            InitializeComponent();
            this.Text = "Editar Especialidad";
            this.__esAgregar = false;
            this.__idEspecialidadEditandose = especialidad.EspecialidadId;
            this.tbNombre.Text = especialidad.Nombre;
            this.tbPrecio.Text = especialidad.PrecioPorDefecto.ToString();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                if (!ValidarCamposObligatoriosPaciente())
                    return;
                using (var entidades = new ClinicaEntities())
                {
                    if (this.__esAgregar)
                    {
                        entidades.Especialidad.Add(new Especialidad { Nombre = tbNombre.Text, PrecioPorDefecto = decimal.Parse(tbPrecio.Text) });
                    }
                    else
                    {
                        var especialidadBD = entidades.Especialidad.First(x => x.EspecialidadId == this.__idEspecialidadEditandose);
                        especialidadBD.Nombre = tbNombre.Text;
                        especialidadBD.PrecioPorDefecto = decimal.Parse(tbPrecio.Text);
                    }
                    entidades.SaveChanges();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCamposObligatoriosPaciente()
        {
            decimal precio = -1;
            if (string.IsNullOrEmpty(tbNombre.Text) || !decimal.TryParse(tbPrecio.Text, out precio))
            {
                if (string.IsNullOrEmpty(tbNombre.Text))
                    errorProvider1.SetError(tbNombre, "Requerido");

                if (!decimal.TryParse(tbPrecio.Text, out precio))
                    errorProvider1.SetError(tbPrecio, "Precio Inválido");

                return false;
            }
            return true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbPrecioTurno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as RadTextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
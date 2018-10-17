using Consultorio.Modelo;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Consultorio
{
    public partial class Forma_Pago : Form
    {
        public Forma_Pago()
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
                segurosMedicoBindingSource.DataSource = entidades.SegurosMedico.ToList();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (!ValidarCamposObligatorios())
                return;

            using (var entities = new ClinicaEntities())
            {
                btnAgregar.Text = "Agregar";

                SegurosMedico seguro = entities.SegurosMedico.FirstOrDefault(
                                        x => x.Nombre.ToUpper() == txtBoxNombreSeguroMedico.Text.ToUpper().Trim());
                if (seguro != null)
                {
                    MessageBox.Show("Seguro Medico ya se encuentra ingresado", "TurnARG");
                }
                else
                {
                    var nuevoSeguro = new SegurosMedico();
                    nuevoSeguro.Nombre = txtBoxNombreSeguroMedico.Text.ToUpper().Trim();
                    entities.SegurosMedico.Add(nuevoSeguro);
                    entities.SaveChanges();
                    MessageBox.Show("Seguro Medico agregado", "TurnARG");
                    RefrescarGridView();
                }
            }
            txtBoxNombreSeguroMedico.Clear();
        }

        private bool ValidarCamposObligatorios()
        {
            if (string.IsNullOrEmpty(txtBoxNombreSeguroMedico.Text))
            {
                errorProvider1.SetError(txtBoxNombreSeguroMedico, "Ingrese un valor");
                return false;
            }
            return true;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (var entidades = new ClinicaEntities())
            {
                SegurosMedico seguro = entidades.SegurosMedico.FirstOrDefault(
                    x => x.Nombre == txtBoxBuscar.Text.Trim());
                if (seguro != null)
                {
                    txtBoxNombreSeguroMedico.Text = seguro.Nombre;
                    btnAgregar.Text = "Editar";
                }
                else
                {
                    MessageBox.Show("Seguro Medico no encontrado", "TurnARG");
                }
            }
            txtBoxBuscar.Clear();
        }
    }
}

using Consultorio.Modelo;
using System;
using System.Windows.Forms;
using System.Linq;

namespace Consultorio.Forms
{
    public partial class AgregarFactura : Form
    {
        private Factura _factura;

        public AgregarFactura(Factura factura)
        {
            InitializeComponent();
            this._factura = factura;
            this.DialogResult = DialogResult.Cancel;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                if (!ValidarCamposObligatorios())
                    return;

                using (var entidades = new ClinicaEntities())
                {
                    DateTime vencimiento;
                    if (DateTime.TryParse(tbFechaVto.Text, out vencimiento))
                    {
                        var tarjeta = new Tarjetas
                        {
                            BajaLogica = false,
                            FechaVto = vencimiento,
                            Nombre = tbNombreTarjeta.Text,
                            NumeroTarjeta = tbNroTarjeta.Text,
                            Titular = tbTitular.Text
                        };
                        entidades.Tarjetas.Add(tarjeta);
                        entidades.SaveChanges();
                        this._factura.IdTarjeta = tarjeta.IdTarjeta;
                        this._factura.Descripcion = tbDescripcion.Text;
                        entidades.Factura.Add(this._factura);
                        var turnoDB = entidades.Turno.First(x => x.IdTurno == this._factura.IdTurno);
                        turnoDB.IdFactura = this._factura.IdFactura;
                        entidades.SaveChanges();
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        errorProvider1.SetError(tbFechaVto, "Fecha Incorrecta");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCamposObligatorios()
        {
            if (string.IsNullOrEmpty(tbTitular.Text) || string.IsNullOrEmpty(tbNroTarjeta.Text) || string.IsNullOrEmpty(tbFechaVto.Text)
                || string.IsNullOrEmpty(tbNombreTarjeta.Text))
            {
                if (string.IsNullOrEmpty(tbTitular.Text))
                    errorProvider1.SetError(tbTitular, "Requerido");

                if (string.IsNullOrEmpty(tbNroTarjeta.Text))
                    errorProvider1.SetError(tbNroTarjeta, "Requerido");

                if (string.IsNullOrEmpty(tbFechaVto.Text))
                    errorProvider1.SetError(tbFechaVto, "Requerido");

                if (string.IsNullOrEmpty(tbNombreTarjeta.Text))
                    errorProvider1.SetError(tbNombreTarjeta, "Requerido");

                return false;
            }
            return true;
        }

        private void tbNroTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

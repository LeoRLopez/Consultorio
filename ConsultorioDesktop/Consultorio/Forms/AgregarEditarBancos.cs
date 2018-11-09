using Consultorio.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultorio.Forms
{
    public partial class AgregarEditarBancos : Form
    {
        private bool __esAgregar;
        private int __idBancoEditandose;

        public AgregarEditarBancos()
        {
            InitializeComponent();
            this.Text = "Agregar Banco";
            this.__esAgregar = true;
        }


        public AgregarEditarBancos(Bancos bancos)
        {
            InitializeComponent();
            this.Text = "Editar Especialidad";
            this.__esAgregar = false;
            this.__idBancoEditandose = bancos.IdBanco;
            this.tbNombre.Text = bancos.Nombre;
            this.tbCodigoBCRA.Text = bancos.CodigoBCRA.ToString();

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
                    if (this.__esAgregar)
                    {
                        entidades.Bancos.Add(new Bancos { Nombre = tbNombre.Text, CodigoBCRA = int.Parse(tbCodigoBCRA.Text) });
                    }
                    else
                    {
                        var bancoDB = entidades.Bancos.First(x => x.IdBanco == this.__idBancoEditandose);
                        bancoDB.Nombre = tbNombre.Text;
                        bancoDB.CodigoBCRA = int.Parse(tbCodigoBCRA.Text);
                    }
                    entidades.SaveChanges();
                    MessageBox.Show("Realizado Correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCamposObligatorios()
        {
            decimal precio = -1;
            if (string.IsNullOrEmpty(tbNombre.Text) || !decimal.TryParse(tbCodigoBCRA.Text, out precio))
            {
                if (string.IsNullOrEmpty(tbNombre.Text))
                    errorProvider1.SetError(tbNombre, "Requerido");

                if (!decimal.TryParse(tbCodigoBCRA.Text, out precio))
                    errorProvider1.SetError(tbCodigoBCRA, "Código Inválido");

                return false;
            }
            return true;
        }
    }
}

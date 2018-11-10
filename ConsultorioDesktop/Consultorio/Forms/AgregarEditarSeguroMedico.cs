using Consultorio.Modelo;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Consultorio.Forms
{
    public partial class AgregarEditarSeguroMedico : Form
    {
        private bool __esAgregar;
        private int __idObraSocialEditandose;

        public AgregarEditarSeguroMedico()
        {
            InitializeComponent();
            this.Text = "Agregar Seguro Médico";
            this.__esAgregar = true;
        }

        public AgregarEditarSeguroMedico(SegurosMedico segurosMedico)
        {
            InitializeComponent();
            this.Text = "Editar Seguro Médico";
            this.__esAgregar = false;
            this.__idObraSocialEditandose = segurosMedico.IdSeguroMedico;
            this.tbNombre.Text = segurosMedico.Nombre;
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
                        entidades.SegurosMedico.Add(new SegurosMedico { Nombre = tbNombre.Text });
                    }
                    else
                    {
                        var seguroMedicoBD = entidades.SegurosMedico.First(x => x.IdSeguroMedico == this.__idObraSocialEditandose);
                        seguroMedicoBD.Nombre = tbNombre.Text;
                    }
                    entidades.SaveChanges();
                    this.Close();
                }
                MessageBox.Show("Realizado Correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCamposObligatorios()
        {
            if (string.IsNullOrEmpty(tbNombre.Text))
            {
                if (string.IsNullOrEmpty(tbNombre.Text))
                    errorProvider1.SetError(tbNombre, "Requerido");

                return false;
            }
            return true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
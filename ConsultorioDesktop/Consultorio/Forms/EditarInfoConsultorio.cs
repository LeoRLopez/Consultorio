using Consultorio.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultorio.Forms
{
    public partial class EditarInfoConsultorio : Form
    {
        public EditarInfoConsultorio()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Los datos no Guardados se perderán","Atención", MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            this.Close();
        }


        private bool ValidarCamposObligatorios()
        {
            if (string.IsNullOrEmpty(tbNombreConsultorio.Text) || string.IsNullOrEmpty(tbDireccion.Text) || string.IsNullOrEmpty(tbTelefono.Text)
                || string.IsNullOrEmpty(tbEmail.Text) || string.IsNullOrEmpty(tbDiasyHorarios.Text))
            {
                if (string.IsNullOrEmpty(tbNombreConsultorio.Text))
                    errorProvider1.SetError(tbNombreConsultorio, "Requerido");

                if (string.IsNullOrEmpty(tbDireccion.Text))
                    errorProvider1.SetError(tbDireccion, "Requerido");

                if (string.IsNullOrEmpty(tbTelefono.Text))
                    errorProvider1.SetError(tbTelefono, "Requerido");

                if (string.IsNullOrEmpty(tbEmail.Text))
                    errorProvider1.SetError(tbEmail, "Requerido");

                if (string.IsNullOrEmpty(tbDiasyHorarios.Text))
                    errorProvider1.SetError(tbDiasyHorarios, "Requerido");

                return false;
            }
            return true;
        }

        private void EditarInfoConsultorio_Load(object sender, EventArgs e)
        {
            using (var entidades = new ClinicaEntities())
            {
                var info = entidades.InfoConsultorio.First();
                tbNombreConsultorio.Text = info.NombreConsultorio;
                tbTelefono.Text = info.Telefono;
                tbEmail.Text = info.Email;
                tbDireccion.Text = info.Dirección;
                tbDiasyHorarios.Text = info.DiasyHorariosAtencion;
                tbWeb.Text = info.Web;
            }

        }

        private void GuardarTodo()
        {
            try
            {
                errorProvider1.Clear();
                if (!ValidarCamposObligatorios())
                    return;


                using (var entidades = new ClinicaEntities())
                {
                    var nuevaInfo = entidades.InfoConsultorio.First();
                    nuevaInfo.NombreConsultorio = tbNombreConsultorio.Text;
                    nuevaInfo.Email = tbEmail.Text;
                    nuevaInfo.Dirección = tbDireccion.Text;
                    nuevaInfo.Telefono = tbTelefono.Text;
                    nuevaInfo.Web = tbWeb.Text;
                    nuevaInfo.DiasyHorariosAtencion = tbDiasyHorarios.Text;

                    entidades.Entry(nuevaInfo).State = EntityState.Modified;
                    entidades.SaveChanges();
                    MessageBox.Show("Datos Editados con Éxito", "TurnARG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardarTodo_Click(object sender, EventArgs e)
        {
            GuardarTodo();
        }
    }
}

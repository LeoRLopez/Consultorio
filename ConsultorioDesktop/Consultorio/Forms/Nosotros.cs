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
    public partial class Nosotros : Form
    {
        public Nosotros(bool __esAdministrador)
        {
            InitializeComponent();
            btnEditar.Visible = __esAdministrador;
        }

        private void Nosotros_Load(object sender, EventArgs e)
        {
            using (var entidades = new ClinicaEntities())
            {
                var infoConsultorio = entidades.InfoConsultorio.First();
                lblNombre.Text = infoConsultorio.NombreConsultorio.ToString();
                lblTelefono.Text = "Telefono/s: " + infoConsultorio.Telefono.ToString();
                lblEmail.Text = "Email: " + infoConsultorio.Email.ToString();
                lblDireccion.Text = "Dirección: " + infoConsultorio.Dirección.ToString();
                lblDiasAtencion.Text = "Horarios de atención: " + infoConsultorio.DiasyHorariosAtencion.ToString();
                lblWeb.Text = "Web: " + infoConsultorio.Web.ToString();
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var ventanaEditarInfo = new EditarInfoConsultorio();
            ventanaEditarInfo.ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

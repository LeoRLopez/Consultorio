using Consultorio.Modelo;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Consultorio
{
    public partial class InicioSesion : Form
    {
        public event EventHandler<EventArgs> SesionIniciada;

        public InicioSesion()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (!ValidarCamposObligatorios())
            {
                return;
            }

            using (var entidades = new ClinicaEntities())
            {
                var nombreUsuario = txtBoxUsuario.Text.ToLower().Trim();
                var contraseñaUsuario = txtBoxContraseña.Text.ToLower().Trim();

                var usuarioDB = entidades.Usuario.FirstOrDefault(u => u.NombreUsuario.ToLower() == nombreUsuario && u.Contrasenia.ToLower() == contraseñaUsuario);

                if (usuarioDB == null)
                {
                    MessageBox.Show("Usuario o Contraseña invalidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (SesionIniciada != null)
                {
                    SesionIniciada.Invoke(this, new IniciarSesionEventArgs
                    {
                        UsuarioId = usuarioDB.IdUsuario,
                        NombreUsuario = usuarioDB.NombreUsuario,
                        Contraseña = usuarioDB.Contrasenia,
                        EsAdministrador = usuarioDB.EsAdministrador,
                        IdMedico = usuarioDB.PersonalInterno.FirstOrDefault() == null ? null : usuarioDB.PersonalInterno.First().IdMedico
                    });
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool ValidarCamposObligatorios()
        {
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(txtBoxUsuario.Text.Trim()) || string.IsNullOrEmpty(txtBoxContraseña.Text.Trim()))
            {
                if (string.IsNullOrEmpty(txtBoxUsuario.Text.Trim()))
                {
                    errorProvider1.SetError(txtBoxUsuario, "Requerido");
                }
                if (string.IsNullOrEmpty(txtBoxContraseña.Text.Trim()))
                {
                    errorProvider1.SetError(txtBoxContraseña, "Requerido");
                }
                return false;
            }

            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void lblOlvidoContraseña_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Si olvidó su Usuario/Contraseña o no posee una, deberá contactar al Administrador del Sistema",
                "TurnARG", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
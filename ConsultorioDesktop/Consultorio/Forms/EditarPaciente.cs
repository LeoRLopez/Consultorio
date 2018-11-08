using Consultorio.Modelo;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using System.Data.Entity;

namespace Consultorio
{
    public partial class EditarPaciente : Form
    {
        private Paciente __paciente;

        public EditarPaciente(int idPaciente)
        {
            InitializeComponent();
            using (var entidades = new ClinicaEntities())
            {
                this.__paciente = entidades.Paciente.Include(x => x.Ciudad).Include(x => x.HistoriaClinica).First(x => x.IdPaciente == idPaciente);
            }
        }

        private void CargarDatosEnPantalla()
        {
            this.txtBoxNombre.Text = this.__paciente.Nombres;
            this.txtBoxApellido.Text = this.__paciente.Apellidos;
            this.txtBoxDocumento.Text = this.__paciente.NumeroDocumento.ToString();
            this.txtBoxTelefono.Text = this.__paciente.TelCelular;
            this.radioBtnMasculino.IsChecked = this.__paciente.Sexo == "Masculino";
            this.radioBtnFemenino.IsChecked = this.__paciente.Sexo == "Femenino";
            this.dateTimePickerNacimiento.Value = this.__paciente.FechaNacimiento;
            this.txtBoxDireccion.Text = this.__paciente.Direccion;
            this.txtBoxEmail.Text = this.__paciente.Email;
            this.dropDownPais.SelectedValue = this.__paciente.IdPais;
            this.dropDownProvincia.SelectedValue = this.__paciente.IdProvincia;
            this.dropDownDepartamento.SelectedValue = this.__paciente.Ciudad.DepartamentoId;
            this.dropDownCiudad.SelectedValue = this.__paciente.IdCiudad;
            this.txtBoxCodigoPostal.Text = this.__paciente.CodigoPostal;
            this.txtBoxAntecedentesMedicos.Text = this.__paciente.HistoriaClinica.AntecedentesMedicos;
            this.dropDownGrupoSanguineo.SelectedValue = this.__paciente.HistoriaClinica.GrupoSanguineo.Trim();
            this.checkBoxDonante.Checked = this.__paciente.HistoriaClinica.Donante;
            this.checkBoxTrasplantado.Checked = this.__paciente.HistoriaClinica.Transplantado;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Los registros sin guardar se perderán. ¿Deas salir de todas maneras?", "TurnARG",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private static int CalculateAge(DateTime dateOfBirth)
        {
            int age = 0;
            age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age = age - 1;

            return age;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider.Clear();

                if (!ValidarCamposObligatoriosPaciente())
                    return;

                using (var entidades = new ClinicaEntities())
                {
                    var pacienteBD = entidades.Paciente.Single(x => x.IdPaciente == this.__paciente.IdPaciente);
                    pacienteBD.Nombres = txtBoxNombre.Text.ToUpper();
                    pacienteBD.Apellidos = txtBoxApellido.Text.ToUpper();
                    pacienteBD.Email = txtBoxEmail.Text;
                    pacienteBD.NumeroDocumento = Int64.Parse(txtBoxDocumento.Text);
                    pacienteBD.FechaNacimiento = dateTimePickerNacimiento.Value;
                    pacienteBD.Edad = CalculateAge(dateTimePickerNacimiento.Value);
                    pacienteBD.Sexo = radioBtnMasculino.IsChecked ? "Masculino" : "Femenino";
                    pacienteBD.TelCelular = txtBoxTelefono.Text.Trim();
                    pacienteBD.Direccion = txtBoxDireccion.Text;
                    pacienteBD.CodigoPostal = txtBoxCodigoPostal.Text;
                    pacienteBD.IdCiudad = (int)dropDownCiudad.SelectedValue;
                    pacienteBD.IdProvincia = (int)dropDownProvincia.SelectedValue;
                    pacienteBD.IdPais = (int)dropDownPais.SelectedValue;

                    if (!ValidarCamposObligatoriosHistoriaClinica())
                        return;
                    var historiaClinicaBD = entidades.HistoriaClinica.Single(x => x.IdHistoriaClinica == pacienteBD.IdHistoriaClinica);


                    historiaClinicaBD.UltimaActualizacion = DateTime.Now;
                    historiaClinicaBD.AntecedentesMedicos = txtBoxAntecedentesMedicos.Text.Trim();
                    historiaClinicaBD.Donante = checkBoxDonante.Checked;
                    historiaClinicaBD.Transplantado = checkBoxTrasplantado.Checked;
                    historiaClinicaBD.GrupoSanguineo = dropDownGrupoSanguineo.Text;


                    // Actualizar el Usuario existente en la tabla AspNetUsers asi se puede seguir logueando en la Web con el nuevo Email
                    var userStore = new UserStore<IdentityUser>(new IdentityDbContext("IdentityDBConnection"));
                    var manager = new UserManager<IdentityUser>(userStore);
                    var usuarioExistente = manager.FindByEmail(this.__paciente.Email);
                    usuarioExistente.UserName = pacienteBD.Email;
                    usuarioExistente.Email = pacienteBD.Email;
                    IdentityResult result = manager.Update(usuarioExistente);
                    if (result.Succeeded)
                    {
                        entidades.SaveChanges();
                        MessageBox.Show("Paciente Editado con Éxito", "TurnARG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error Editando el Paciente: " + Environment.NewLine + string.Join(Environment.NewLine, result.Errors.ToArray()), "TurnARG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCamposObligatoriosHistoriaClinica()
        {

            if (string.IsNullOrEmpty(txtBoxAntecedentesMedicos.Text) || string.IsNullOrEmpty(dropDownGrupoSanguineo.SelectedItem.Text))
            {
                if (string.IsNullOrEmpty(txtBoxAntecedentesMedicos.Text))
                    errorProvider.SetError(txtBoxAntecedentesMedicos, "Requerido");

                if (string.IsNullOrEmpty(dropDownGrupoSanguineo.SelectedItem.Text))
                    errorProvider.SetError(dropDownGrupoSanguineo, "Requerido");

                return false;
            }

            return true;
        }

        private void dropDownPais_SelectedValueChanged(object sender, EventArgs e)
        {
            var comboPais = (RadDropDownList)sender;
            if (comboPais.SelectedItem != null)
            {
                var paisSeleccionado = (Pais)comboPais.SelectedItem.DataBoundItem;
                if (paisSeleccionado.PaisId != -1)
                {
                    using (var entidades = new ClinicaEntities())
                    {
                        var provincias = new List<Provincia>() { new Provincia { ProvinciaId = -1, Nombre = "Seleccione una Provincia" } };
                        provincias.AddRange(entidades.Pais.First(x => x.PaisId == paisSeleccionado.PaisId).Provincia.ToList());
                        dropDownProvincia.DisplayMember = "Nombre";
                        dropDownProvincia.ValueMember = "ProvinciaId";
                        dropDownProvincia.DataSource = provincias;
                    }
                }
                else
                {
                    dropDownProvincia.DataSource = null;
                }
                dropDownDepartamento.DataSource = null;
                dropDownCiudad.DataSource = null;
                txtBoxCodigoPostal.Clear();
            }
        }

        private void dropDownProvincia_SelectedValueChanged(object sender, EventArgs e)
        {
            var comboProvincia = (RadDropDownList)sender;
            if (comboProvincia.SelectedItem != null)
            {
                var provinciaSeleccionada = (Provincia)comboProvincia.SelectedItem.DataBoundItem;
                if (provinciaSeleccionada.ProvinciaId != -1)
                {
                    using (var entidades = new ClinicaEntities())
                    {
                        var departamentos = new List<Departamento>() { new Departamento { DepartamentoId = -1, Nombre = "Seleccione un Departamento" } };
                        departamentos.AddRange(entidades.Departamento.Where(x => x.ProvinciaId == provinciaSeleccionada.ProvinciaId).ToList());
                        dropDownDepartamento.DisplayMember = "Nombre";
                        dropDownDepartamento.ValueMember = "DepartamentoId";
                        dropDownDepartamento.DataSource = departamentos;
                    }
                }
                else
                {
                    dropDownDepartamento.DataSource = null;
                }
                dropDownCiudad.DataSource = null;
                txtBoxCodigoPostal.Clear();
            }
        }

        private void dropDownDepartamento_SelectedValueChanged(object sender, EventArgs e)
        {
            var comboDepartamento = (RadDropDownList)sender;
            if (comboDepartamento.SelectedItem != null)
            {
                var departamentoSeleccionado = (Departamento)comboDepartamento.SelectedItem.DataBoundItem;
                if (departamentoSeleccionado.DepartamentoId != -1)
                {
                    using (var entidades = new ClinicaEntities())
                    {
                        var ciudades = new List<Ciudad>() { new Ciudad { CiudadId = -1, Nombre = "Seleccione una Ciudad" } };
                        ciudades.AddRange(entidades.Ciudad.Where(x => x.DepartamentoId == departamentoSeleccionado.DepartamentoId).ToList());
                        dropDownCiudad.DisplayMember = "Nombre";
                        dropDownCiudad.ValueMember = "CiudadId";
                        dropDownCiudad.DataSource = ciudades;
                    }
                }
                else
                {
                    dropDownCiudad.DataSource = null;
                }
                txtBoxCodigoPostal.Clear();
            }
        }

        private void dropDownCiudad_SelectedValueChanged(object sender, EventArgs e)
        {
            var comboCiudad = (RadDropDownList)sender;
            if (comboCiudad.SelectedItem != null)
            {
                var ciudadSeleccionada = (Ciudad)comboCiudad.SelectedItem.DataBoundItem;
                if (ciudadSeleccionada.CiudadId != -1)
                    txtBoxCodigoPostal.Text = ciudadSeleccionada.CodigoPostal.ToString();
            }
            else
            {
                txtBoxCodigoPostal.Clear();
            }
        }

        private void NuevoPaciente_Load(object sender, EventArgs e)
        {
            using (var entidades = new ClinicaEntities())
            {
                var paises = new List<Pais>() { new Pais { PaisId = 1, Nombre = "ARGENTINA" } };
                paises.AddRange(entidades.Pais.ToList());
                dropDownPais.DisplayMember = "Nombre";
                dropDownPais.ValueMember = "PaisId";
                dropDownPais.DataSource = paises.ToList();
            }
            CargarDatosEnPantalla();
        }

        private bool ValidarCamposObligatoriosPaciente()
        {
            var idPaisSeleccionado = dropDownPais.SelectedValue != null ? (int)dropDownPais.SelectedValue : -1;
            var idProvinciaSeleccionado = dropDownProvincia.SelectedValue != null ? (int)dropDownProvincia.SelectedValue : -1;
            var idDepartamentoSeleccionado = dropDownDepartamento.SelectedValue != null ? (int)dropDownDepartamento.SelectedValue : -1;
            var idCiudadSeleccionada = dropDownCiudad.SelectedValue != null ? (int)dropDownCiudad.SelectedValue : -1;

            if (string.IsNullOrEmpty(txtBoxNombre.Text) || string.IsNullOrEmpty(txtBoxApellido.Text)
                || string.IsNullOrEmpty(txtBoxDocumento.Text) || string.IsNullOrEmpty(txtBoxEmail.Text)
                || string.IsNullOrEmpty(txtBoxDireccion.Text) || string.IsNullOrEmpty(txtBoxCodigoPostal.Text)
                || idPaisSeleccionado == -1 || idProvinciaSeleccionado == -1 || idDepartamentoSeleccionado == -1 || idCiudadSeleccionada == -1)
            {
                if (string.IsNullOrEmpty(txtBoxNombre.Text))
                    errorProvider.SetError(txtBoxNombre, "Requerido");

                if (string.IsNullOrEmpty(txtBoxApellido.Text))
                    errorProvider.SetError(txtBoxApellido, "Requerido");

                if (string.IsNullOrEmpty(txtBoxDocumento.Text))
                    errorProvider.SetError(txtBoxDocumento, "Requerido");

                if (string.IsNullOrEmpty(txtBoxEmail.Text))
                    errorProvider.SetError(txtBoxEmail, "Requerido");

                if (string.IsNullOrEmpty(txtBoxDireccion.Text))
                    errorProvider.SetError(txtBoxDireccion, "Requerido");

                if (string.IsNullOrEmpty(txtBoxCodigoPostal.Text))
                    errorProvider.SetError(txtBoxCodigoPostal, "Requerido");

                if (idPaisSeleccionado == -1)
                    errorProvider.SetError(dropDownPais, "Debe seleccionar un Pais");

                if (idProvinciaSeleccionado == -1)
                    errorProvider.SetError(dropDownProvincia, "Debe seleccionar una Provincia");

                if (idDepartamentoSeleccionado == -1)
                    errorProvider.SetError(dropDownDepartamento, "Debe seleccionar un Departamento");

                if (idCiudadSeleccionada == -1)
                    errorProvider.SetError(dropDownCiudad, "Debe seleccionar una Ciudad");

                return false;
            }
            //Validar formato del Email
            try
            {
                MailAddress email = new MailAddress(txtBoxEmail.Text);
            }
            catch (FormatException)
            {
                errorProvider.SetError(txtBoxEmail, "Email inválido.");
                return false;
            }

            if (!Int64.TryParse(txtBoxDocumento.Text, out long documento))
            {
                errorProvider.SetError(txtBoxDocumento, "Debe ingresar solo Números");
                return false;
            }

            if (txtBoxDocumento.Text.Length < 6)
            {
                errorProvider.SetError(txtBoxDocumento, "Debe poseer al menos 6 digitos");
                return false;
            }

            return true;
        }

        private void txtBoxDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
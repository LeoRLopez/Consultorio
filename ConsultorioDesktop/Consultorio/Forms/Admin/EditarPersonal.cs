using Consultorio.Modelo;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Windows.Forms;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;
using System.Data.Entity;

namespace Consultorio
{
    public partial class EditarPersonal : Form
    {
        private Boolean __esMedico = false;
        private List<Especialidad> __especialidadesMedico;
        private PersonalInterno __personalInterno;

        public EditarPersonal(int idPersonalInterno) : base()
        {
            InitializeComponent();
            using (var entidades = new ClinicaEntities())
            {
                this.__personalInterno = entidades.PersonalInterno.Include(x => x.Medico).Include(x => x.Usuario).Include(x => x.Ciudad).First(x => x.IdPersonal == idPersonalInterno);
            }
        }

        private void CargarDatosEnPantalla(PersonalInterno personalInterno)
        {
            // Cargar Campos del Personal Interno
            this.txtBoxNombre.Text = personalInterno.Nombre;
            this.txtBoxApellido.Text = personalInterno.Apellido;
            this.txtBoxDocumento.Text = personalInterno.NumeroDocumento.ToString();
            this.txtBoxTelefono.Text = personalInterno.TelCel;
            this.radioButtonMasculino.IsChecked = personalInterno.Sexo == "Masculino";
            this.radioButtonFemenino.IsChecked = personalInterno.Sexo == "Femenino";
            this.dateTimePickerNacimiento.Value = personalInterno.FechaNacimiento;
            this.txtBoxDireccion.Text = personalInterno.Direccion;
            this.txtBoxEmail.Text = personalInterno.Email;
            this.dropDownPais.SelectedValue = personalInterno.IdPais;
            this.dropDownProvincia.SelectedValue = personalInterno.IdProvincia;
            this.dropDownDepartamento.SelectedValue = personalInterno.Ciudad.DepartamentoId;
            this.dropDownCiudad.SelectedValue = personalInterno.IdCiudad;
            this.tbCodigoPostal.Text = personalInterno.Ciudad.CodigoPostal.ToString();

            // Cargar campos del Usuario
            if (personalInterno.Usuario != null)
            {
                this.txtBoxUsuario.Text = personalInterno.Usuario.NombreUsuario;
                this.txtBoxContraseña.Text = personalInterno.Usuario.Contrasenia;
                this.chbEsAdmin.Checked = personalInterno.Usuario.EsAdministrador;
            }

            // Cargar Campos del Medico
            if (personalInterno.Medico != null)
            {
                this.RdBtnSiMedico.IsChecked = true;
                this.RdBtnNoMedico.IsChecked = false;
                this.__esMedico = true;
                this.txtBoxMatricula.Text = personalInterno.Medico.MatriculaMedico;
                foreach (var medicoEspecialidad in personalInterno.Medico.MedicoEspecialidad.ToList())
                {
                    var especialidadMedico = medicoEspecialidad.Especialidad.Nombre + " $" + medicoEspecialidad.Especialidad.PrecioPorDefecto.ToString("00.##");
                    var index = listViewEspecialidades.Items.IndexOfKey(especialidadMedico);
                    listViewEspecialidades.Items[index].Checked = true;
                }
                this.ddlHorariosLunes.SelectedValue = personalInterno.Medico.LunesHorarioId;
                this.ddlHorariosMartes.SelectedValue = personalInterno.Medico.MartesHorarioId;
                this.ddlHorariosMiercoles.SelectedValue = personalInterno.Medico.MiercolesHorarioId;
                this.ddlHorariosJueves.SelectedValue = personalInterno.Medico.JuevesHorarioId;
                this.ddlHorariosViernes.SelectedValue = personalInterno.Medico.ViernesHorarioId;
            }
            else
            {
                this.RdBtnSiMedico.IsChecked = false;
                this.RdBtnNoMedico.IsChecked = true;
                this.__esMedico = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea salir?.Los datos no guardados se perderán.", "TurnARG",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

        private void btnGuardaar_Click(object sender, EventArgs e)
        {

            using (var entidades = new ClinicaEntities())
            {
                using (var entidadesTransaction = entidades.Database.BeginTransaction())
                {
                    try
                    {
                        errorProvider.Clear();

                        if (!ValidarCamposObligatoriosPersonalInterno())
                            return;

                        int? idCiudadSeleccionada = dropDownCiudad.SelectedValue == null ? null : (int?)dropDownCiudad.SelectedValue;
                        int? idDepartamentoSeleccionado = dropDownDepartamento.SelectedValue == null ? null : (int?)dropDownDepartamento.SelectedValue;
                        int? idProvinciaSeleccionada = dropDownProvincia.SelectedValue == null ? null : (int?)dropDownProvincia.SelectedValue;
                        int? idPaisSeleccionado = dropDownPais.SelectedValue == null ? null : (int?)dropDownPais.SelectedValue;

                        var personalInternoDB = entidades.PersonalInterno.First(x => x.IdPersonal == this.__personalInterno.IdPersonal);
                        personalInternoDB.Activo = true;
                        personalInternoDB.Bajalogica = false;
                        personalInternoDB.Apellido = txtBoxApellido.Text;
                        personalInternoDB.Nombre = txtBoxNombre.Text;
                        personalInternoDB.FechaNacimiento = dateTimePickerNacimiento.Value;
                        personalInternoDB.NumeroDocumento = Int64.Parse(txtBoxDocumento.Text);
                        personalInternoDB.Email = txtBoxEmail.Text;
                        personalInternoDB.Direccion = txtBoxDireccion.Text;
                        personalInternoDB.TelCel = txtBoxTelefono.Text;
                        personalInternoDB.Sexo = radioButtonMasculino.IsChecked ? "Masculino" : "Femenino";
                        personalInternoDB.EstadoCivil = txtBoxEstadoCivil.Text;
                        personalInternoDB.Edad = CalculateAge(dateTimePickerNacimiento.Value);
                        personalInternoDB.IdCiudad = idCiudadSeleccionada != -1 ? idCiudadSeleccionada : null;
                        personalInternoDB.IdProvincia = idProvinciaSeleccionada != -1 ? idProvinciaSeleccionada : null;
                        personalInternoDB.IdPais = idPaisSeleccionado != -1 ? idPaisSeleccionado : null;
                        entidades.SaveChanges();

                        if (!ValidarCamposObligatoriosUsuarioDelSistema())
                            return;

                        var usuarioDB = entidades.Usuario.First(x => x.IdUsuario == this.__personalInterno.IdUsuario);
                        usuarioDB.Contrasenia = txtBoxContraseña.Text;
                        usuarioDB.NombreUsuario = txtBoxUsuario.Text;
                        usuarioDB.EsAdministrador = chbEsAdmin.Checked;
                        usuarioDB.BajaLogica = false;
                        entidades.SaveChanges();

                        if (this.__esMedico)
                        {
                            if (!ValidarCamposObligatoriosMedico())
                                return;

                            List<MedicoEspecialidad> especialidadesSeleccionadas = new List<MedicoEspecialidad>();
                            foreach (var item in listViewEspecialidades.CheckedItems)
                            {
                                string nombreEspecialidad = (item as ListViewItem).Text.Split('$')[0].Trim();
                                int especialidadId = this.__especialidadesMedico.First(x => x.Nombre == nombreEspecialidad).EspecialidadId;
                                especialidadesSeleccionadas.Add(new MedicoEspecialidad { EspecialidadId = especialidadId });
                            }

                            // Si no es nulo es porque ya era un medico, entonces actualizamos el registro
                            if (this.__personalInterno.IdMedico != null)
                            {
                                var medicoDB = entidades.Medico.First(x => x.IdMedico == this.__personalInterno.IdMedico);
                                medicoDB.MatriculaMedico = txtBoxMatricula.Text;
                                medicoDB.LunesHorarioId = (int)ddlHorariosLunes.SelectedValue;
                                medicoDB.MartesHorarioId = (int)ddlHorariosMartes.SelectedValue;
                                medicoDB.MiercolesHorarioId = (int)ddlHorariosMiercoles.SelectedValue;
                                medicoDB.JuevesHorarioId = (int)ddlHorariosJueves.SelectedValue;
                                medicoDB.ViernesHorarioId = (int)ddlHorariosViernes.SelectedValue;
                                medicoDB.SabadoHorarioId = 1;// No atiende
                                medicoDB.DomingoHorarioId = 1;// No atiende

                                // Eliminar las Especialidades actuales del medico
                                medicoDB.MedicoEspecialidad.Clear();
                                entidades.SaveChanges();

                                // Insertar las especialidades seleccionadas
                                medicoDB.MedicoEspecialidad = especialidadesSeleccionadas;
                                entidades.SaveChanges();
                            }
                            else
                            {
                                // Si era nulo es porque el Personal interno no estaba asociado a un Medico
                                // entonces debemos insertar un nuevo registro de Medico
                                var medico = new Medico
                                {
                                    MatriculaMedico = txtBoxMatricula.Text,
                                    LunesHorarioId = (int)ddlHorariosLunes.SelectedValue,
                                    MartesHorarioId = (int)ddlHorariosMartes.SelectedValue,
                                    MiercolesHorarioId = (int)ddlHorariosMiercoles.SelectedValue,
                                    JuevesHorarioId = (int)ddlHorariosJueves.SelectedValue,
                                    ViernesHorarioId = (int)ddlHorariosViernes.SelectedValue,
                                    SabadoHorarioId = 1,// No atiende
                                    DomingoHorarioId = 1,// No atiende
                                    MedicoEspecialidad = especialidadesSeleccionadas
                                };
                                personalInternoDB.Medico = medico;
                                entidades.SaveChanges();
                            }
                        }

                        // Actualizar el Usuario existente en la tabla AspNetUsers asi se puede seguir logueando en la Web con el nuevo Email
                        var userStore = new UserStore<IdentityUser>(new IdentityDbContext("IdentityDBConnection"));
                        var manager = new UserManager<IdentityUser>(userStore);
                        var usuarioExistente = manager.FindByEmail(personalInternoDB.Email);
                        usuarioExistente.UserName = personalInternoDB.Email;
                        usuarioExistente.Email = personalInternoDB.Email;
                        IdentityResult result = manager.Update(usuarioExistente);

                        if (result.Succeeded)
                        {
                            // Asignar el usuario al Rol correspondiente
                            usuarioExistente = manager.FindByName(usuarioExistente.UserName);

                            if (usuarioDB.EsAdministrador)
                            {
                                if (!manager.IsInRole(usuarioExistente.Id, "Admin"))
                                    manager.AddToRole(usuarioExistente.Id, "Admin");
                            }
                            else if (this.__esMedico)
                            {
                                if (!manager.IsInRole(usuarioExistente.Id, "Medico"))
                                    manager.AddToRole(usuarioExistente.Id, "Medico");
                            }
                            else
                            {
                                if (!manager.IsInRole(usuarioExistente.Id, "Usuario"))
                                    manager.AddToRole(usuarioExistente.Id, "Usuario");
                            }

                            entidades.SaveChanges();
                            entidadesTransaction.Commit();

                            MessageBox.Show("Personal Actualizado con Éxito", "TurnARG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            entidadesTransaction.Rollback();
                            MessageBox.Show("Hubo un error Actualizando el Personal: " + Environment.NewLine + string.Join(Environment.NewLine, result.Errors.ToArray()), "TurnARG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        entidadesTransaction.Rollback();
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private bool ValidarCamposObligatoriosPersonalInterno()
        {
            if (string.IsNullOrEmpty(txtBoxNombre.Text) || string.IsNullOrEmpty(txtBoxApellido.Text) || string.IsNullOrEmpty(txtBoxDocumento.Text)
                || string.IsNullOrEmpty(txtBoxEmail.Text))
            {
                if (string.IsNullOrEmpty(txtBoxNombre.Text))
                    errorProvider.SetError(txtBoxNombre, "Requerido");

                if (string.IsNullOrEmpty(txtBoxApellido.Text))
                    errorProvider.SetError(txtBoxApellido, "Requerido");

                if (string.IsNullOrEmpty(txtBoxDocumento.Text))
                    errorProvider.SetError(txtBoxDocumento, "Requerido");

                if (string.IsNullOrEmpty(txtBoxEmail.Text))
                    errorProvider.SetError(txtBoxEmail, "Requerido");

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

            return true;
        }

        private bool ValidarCamposObligatoriosUsuarioDelSistema()
        {
            if (string.IsNullOrEmpty(txtBoxUsuario.Text) || string.IsNullOrEmpty(txtBoxContraseña.Text))
            {
                if (string.IsNullOrEmpty(txtBoxUsuario.Text))
                    errorProvider.SetError(txtBoxUsuario, "Requerido");

                if (string.IsNullOrEmpty(txtBoxContraseña.Text))
                    errorProvider.SetError(txtBoxContraseña, "Requerido");

                return false;
            }

            if (txtBoxContraseña.Text.Length < 6)
            {
                errorProvider.SetError(txtBoxContraseña, "Debe poseer al menos 6 caracteres");
                return false;
            }

            return true;
        }

        private bool ValidarCamposObligatoriosMedico()
        {
            if (string.IsNullOrEmpty(txtBoxMatricula.Text) || listViewEspecialidades.CheckedItems.Count == 0)
            {
                if (string.IsNullOrEmpty(txtBoxMatricula.Text))
                    errorProvider.SetError(txtBoxMatricula, "Requerido");

                if (listViewEspecialidades.CheckedItems.Count == 0)
                    errorProvider.SetError(listViewEspecialidades, "Al menos 1 Especialidad es Requerida");

                return false;
            }
            return true;
        }

        private void CargarDiasYHorariosDeAtencion()
        {
            using (var entidades = new ClinicaEntities())
            {
                CargarHorarios(ddlHorariosLunes, entidades.Horario.ToList());
                CargarHorarios(ddlHorariosMartes, entidades.Horario.ToList());
                CargarHorarios(ddlHorariosMiercoles, entidades.Horario.ToList());
                CargarHorarios(ddlHorariosJueves, entidades.Horario.ToList());
                CargarHorarios(ddlHorariosViernes, entidades.Horario.ToList());
            }
        }

        private void CargarHorarios(RadDropDownList dropDown, List<Horario> horarios)
        {
            dropDown.DisplayMember = "Nombre";
            dropDown.ValueMember = "IdHorario";
            dropDown.DataSource = horarios;
        }

        private void NuevoUsuario_Load(object sender, EventArgs e)
        {
            using (var entidades = new ClinicaEntities())
            {
                var paises = new List<Pais>() { new Pais { PaisId = 1, Nombre = "ARGENTINA" } };
                paises.AddRange(entidades.Pais.ToList());
                dropDownPais.DisplayMember = "Nombre";
                dropDownPais.ValueMember = "PaisId";
                dropDownPais.DataSource = paises.ToList();
            }
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
                tbCodigoPostal.Clear();
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
                tbCodigoPostal.Clear();
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
                tbCodigoPostal.Clear();
            }
        }

        private void dropDownCiudad_SelectedValueChanged(object sender, EventArgs e)
        {
            var comboCiudad = (RadDropDownList)sender;
            if (comboCiudad.SelectedItem != null)
            {
                var ciudadSeleccionada = (Ciudad)comboCiudad.SelectedItem.DataBoundItem;
                if (ciudadSeleccionada.CiudadId != -1)
                    tbCodigoPostal.Text = ciudadSeleccionada.CodigoPostal.ToString();
            }
            else
            {
                tbCodigoPostal.Clear();
            }

        }

        private void RdBtnSiMedico_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            switch (args.ToggleState)
            {
                case ToggleState.Indeterminate:
                case ToggleState.Off:
                    __esMedico = false;
                    txtBoxMatricula.Clear();
                    listViewEspecialidades.Items.Clear();
                    ddlHorariosLunes.Text = string.Empty;
                    ddlHorariosMartes.Text = string.Empty;
                    ddlHorariosMiercoles.Text = string.Empty;
                    ddlHorariosJueves.Text = string.Empty;
                    ddlHorariosViernes.Text = string.Empty;
                    panelMedico.Enabled = false;
                    break;
                case ToggleState.On:
                    __esMedico = true;
                    panelMedico.Enabled = true;
                    CargarDiasYHorariosDeAtencion();
                    CargarEspecialidades();
                    break;
            }
        }

        private void CargarEspecialidades()
        {
            using (var entidades = new ClinicaEntities())
            {
                this.__especialidadesMedico = entidades.Especialidad.ToList();
                foreach (var especialidad in __especialidadesMedico)
                    listViewEspecialidades.Items.Add(new ListViewItem(especialidad.Nombre + " $" + especialidad.PrecioPorDefecto.ToString("00.##")));
            }
        }

        private void txtBoxDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBoxEmail_TextChanged(object sender, EventArgs e)
        {
            txtBoxUsuario.Text = txtBoxEmail.Text;
        }

        private void txtBoxDocumento_TextChanged(object sender, EventArgs e)
        {
            txtBoxContraseña.Text = txtBoxDocumento.Text;
        }
    }
}
using Consultorio.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Windows.Forms;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;

namespace Consultorio
{
    public partial class NuevoPersonal : Form
    {
        private Boolean __esMedico = false;
        private List<Especialidad> __especialidadesMedico;

        public NuevoPersonal() : base()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea salir?.Los datos no guardados se perderán.", "TurnARG",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnGuardaar_Click(object sender, EventArgs e)
        {
            ErrPersonal.Clear();

            if (!ValidarCamposObligatoriosPersonalInterno())
                return;

            //Validar formato del Email, si es que se ingreso algun valor
            if (!string.IsNullOrEmpty(txtBoxEmail.Text))
            {
                try
                {
                    MailAddress email = new MailAddress(txtBoxEmail.Text);
                }
                catch (FormatException)
                {
                    ErrPersonal.SetError(txtBoxEmail, "Email inválido.");
                    return;
                }
            }

            var personalInterno = new PersonalInterno
            {
                Activo = true,
                Apellido = txtBoxApellido.Text,
                Nombre = txtBoxNombre.Text,
                FechaNacimiento = dateTimePickerNacimiento.Value
            };

            int documento;
            bool res = Int32.TryParse(txtBoxDocumento.Text, out documento);
            if (res)
            {
                personalInterno.NumeroDocumento = documento;
            }
            else
            {
                ErrPersonal.SetError(txtBoxDocumento, "Debe ingresar solo Números");
            }

            if (!ValidarCamposObligatoriosUsuarioDelSistema())
                return;

            var usuario = new Usuario
            {
                Contrasenia = txtBoxContraseña.Text,
                NombreUsuario = txtBoxUsuario.Text,
                EsAdministrador = chbEsAdmin.Checked,
            };

            personalInterno.Usuario = usuario;

            if (this.__esMedico)
            {
                if (!ValidarCamposObligatoriosMedico())
                    return;

                List<MedicoEspecialidad> especialidadesSeleccionadas = new List<MedicoEspecialidad>();
                foreach (var item in listViewEspecialidades.CheckedItems)
                {
                    string nombreEspecialidad = (item as ListViewItem).Text.Split('-')[0];
                    int especialidadId = this.__especialidadesMedico.First(x => x.Nombre == nombreEspecialidad).EspecialidadId;
                    especialidadesSeleccionadas.Add(new MedicoEspecialidad { EspecialidadId = especialidadId });
                }

                var medico = new Modelo.Medico
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

                personalInterno.Medico = medico;
            }

            try
            {
                using (var entidades = new ClinicaEntities())
                {
                    entidades.PersonalInterno.Add(personalInterno);
                    entidades.SaveChanges();
                    MessageBox.Show("Personal Agregado con Exito", "TurnARG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCamposObligatoriosPersonalInterno()
        {
            if (string.IsNullOrEmpty(txtBoxNombre.Text) || string.IsNullOrEmpty(txtBoxApellido.Text) || string.IsNullOrEmpty(txtBoxDocumento.Text)
                || string.IsNullOrEmpty(txtBoxDireccion.Text) || string.IsNullOrEmpty(txtBoxTelefono.Text))
            {
                if (string.IsNullOrEmpty(txtBoxNombre.Text))
                    ErrPersonal.SetError(txtBoxNombre, "Requerido");

                if (string.IsNullOrEmpty(txtBoxApellido.Text))
                    ErrPersonal.SetError(txtBoxApellido, "Requerido");

                if (string.IsNullOrEmpty(txtBoxDocumento.Text))
                    ErrPersonal.SetError(txtBoxDocumento, "Requerido");

                if (string.IsNullOrEmpty(txtBoxDireccion.Text))
                    ErrPersonal.SetError(txtBoxDireccion, "Requerido");

                if (string.IsNullOrEmpty(txtBoxTelefono.Text))
                    ErrPersonal.SetError(txtBoxTelefono, "Requerido");

                return false;
            }
            return true;
        }

        private bool ValidarCamposObligatoriosUsuarioDelSistema()
        {
            if (string.IsNullOrEmpty(txtBoxUsuario.Text) || string.IsNullOrEmpty(txtBoxContraseña.Text))
            {
                if (string.IsNullOrEmpty(txtBoxUsuario.Text))
                    ErrPersonal.SetError(txtBoxUsuario, "Requerido");

                if (string.IsNullOrEmpty(txtBoxContraseña.Text))
                    ErrPersonal.SetError(txtBoxContraseña, "Requerido");

                return false;
            }
            return true;
        }

        private bool ValidarCamposObligatoriosMedico()
        {
            if (string.IsNullOrEmpty(txtBoxMatricula.Text) || listViewEspecialidades.CheckedItems.Count == 0)
            {
                if (string.IsNullOrEmpty(txtBoxMatricula.Text))
                    ErrPersonal.SetError(txtBoxMatricula, "Requerido");

                if (listViewEspecialidades.CheckedItems.Count == 0)
                    ErrPersonal.SetError(listViewEspecialidades, "Al menos 1 Especialidad es Requerida");

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
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
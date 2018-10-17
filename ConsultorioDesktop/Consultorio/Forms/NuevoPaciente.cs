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
using Telerik.WinControls.UI;

namespace Consultorio
{
    public partial class NuevoPaciente : Form
    {
        public NuevoPaciente()
        {
            InitializeComponent();
        }

        //Le agregue la funcionalidad de que, cuando un registro sea distinto de "" que lo limpie;
        //Si se vuelve a apretar cancelar, la ventana se cerraria;
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Los registros sin guardar se perderán. ¿Salir?", "TurnARG", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                this.Close();
            }
        }
       
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            errProvider.Clear();

            if (!validarDatosNuevoPaciente())
                return;

            var nuevoPaciente = new Paciente
            {
                Nombres = txtBoxNombre.Text.ToUpper(),
                Apellidos = txtBoxApellido.Text.ToUpper(),
                FechaNacimiento = dateTimePickerNacimiento.Value,
                PrimeraAtencion = true,
                TelCelular = txtBoxTelefono.Text.Trim(),
            };

            int documento;
            bool res = Int32.TryParse(txtBoxDocumento.Text, out documento);
            if (res)
            {
                nuevoPaciente.NumeroDocumento = documento;
            }
            else
            {
                errProvider.SetError(txtBoxDocumento, "Debe ingresar solo Números");
            }

            DateTime today = DateTime.Today;
            int age = today.Year - dateTimePickerNacimiento.Value.Year;
            if (dateTimePickerNacimiento.Value > today.AddYears(-age)) age--;

            if (radioBtnFemenino.IsChecked)
            {
                nuevoPaciente.Sexo = radioBtnFemenino.Text;
            }
            else
            {
                nuevoPaciente.Sexo = radioBtnMasculino.Text;
            }

            var nuevaHistoriaClinica = new HistoriaClinica
            {
                AntecedentesMedicos = txtBoxAntecedentesMedicos.Text.Trim(),
                FechaInicio = DateTime.Today,
                UltimaActualizacion = DateTime.Today,
            };

            if(dropDownGrupoSanguineo.SelectedValue != null)
            {
                nuevaHistoriaClinica.GrupoSanguineo = dropDownGrupoSanguineo.Text;
            }

            if (checkBoxDonante.Checked)
            {
                nuevaHistoriaClinica.Donante = true;
            }else
            {
                nuevaHistoriaClinica.Donante = false;
            }

            if (checkBoxTrasplantado.Checked)
            {
                nuevaHistoriaClinica.Transplantado = true;
            }
            else
            {
                nuevaHistoriaClinica.Transplantado = false;
            }

            nuevoPaciente.HistoriaClinica = nuevaHistoriaClinica;

            Pais pais = new Pais { Nombre = dropDownPais.SelectedItem.Text };
            Provincia provincia = new Provincia { Nombre = dropDownProvincia.SelectedItem.Text };
            Departamento departamento = new Departamento { Nombre = dropDownDepartamento.SelectedItem.Text };
            Ciudad ciudad = new Ciudad { Nombre = dropDownCiudad.SelectedItem.Text };

            nuevoPaciente.Direccion = txtBoxDireccion.Text.Trim();
            nuevoPaciente.Pais = pais;
            nuevoPaciente.Provincia = provincia;
            nuevoPaciente.Ciudad = ciudad;
            nuevoPaciente.CodigoPostal = txtBoxCodigoPostal.Text;



            try
            {
                using (var entidades = new ClinicaEntities())
                {
                    entidades.Paciente.Add(nuevoPaciente);
                    entidades.SaveChanges();
                    MessageBox.Show("Paciente Agregado con Exito", "TurnARG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }

        private bool validarDatosNuevoPaciente()
        {
            if (string.IsNullOrEmpty(txtBoxNombre.Text) || string.IsNullOrEmpty(txtBoxApellido.Text)
                || string.IsNullOrEmpty(dropDownProvincia.Text) || string.IsNullOrEmpty(dropDownProvincia.Text)
                || string.IsNullOrEmpty(dropDownDepartamento.Text) || string.IsNullOrEmpty(dropDownProvincia.Text)
                || string.IsNullOrEmpty(txtBoxDocumento.Text) || string.IsNullOrEmpty(txtBoxTelefono.Text))
            {
                if (string.IsNullOrEmpty(txtBoxNombre.Text))
                    errProvider.SetError(txtBoxNombre, "Requerido");

                if (string.IsNullOrEmpty(txtBoxApellido.Text))
                    errProvider.SetError(txtBoxApellido, "Requerido");

                if (string.IsNullOrEmpty(dropDownProvincia.Text))
                    errProvider.SetError(dropDownProvincia, "Requerido");

                if (string.IsNullOrEmpty(dropDownDepartamento.Text))
                    errProvider.SetError(dropDownDepartamento, "Requerido");

                if (string.IsNullOrEmpty(dropDownProvincia.Text))
                    errProvider.SetError(dropDownProvincia, "Requerido");

                if (string.IsNullOrEmpty(txtBoxDocumento.Text))
                    errProvider.SetError(txtBoxDocumento, "Requerido");

                if (string.IsNullOrEmpty(txtBoxTelefono.Text))
                    errProvider.SetError(txtBoxTelefono, "Requerido");

                return false;
            }
            return true;

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
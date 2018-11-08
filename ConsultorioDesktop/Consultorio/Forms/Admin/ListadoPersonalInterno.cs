using Consultorio.Modelo;
using System;
using System.Windows.Forms;
using System.Linq;
using Consultorio.ViewModels;
using System.Collections.Generic;
using System.Data.Entity;

namespace Consultorio.Forms
{
    public partial class ListadoPersonalInterno : Form
    {
        public ListadoPersonalInterno()
        {
            InitializeComponent();
        }

        private void ListadoPersonalInterno_Load(object sender, EventArgs e)
        {
            RefrescarGridView();
        }

        private void RefrescarGridView()
        {
            using (var entidades = new ClinicaEntities())
            {
                var listaPersonalInterno = entidades.PersonalInterno.Include(x => x.Usuario).Include(x => x.Medico).Include(x => x.Medico.MedicoEspecialidad)
                                                    .Where(x => x.Bajalogica == false).ToList();
                personalInternoVMBindingSource.DataSource = ConstruirListaDePersonalInternoVM(listaPersonalInterno);
            }
        }

        private List<PersonalInternoVM> ConstruirListaDePersonalInternoVM(List<PersonalInterno> listaPersonalInterno)
        {
            var listaPersonalInternoVM = new List<PersonalInternoVM>();
            foreach (var personalInterno in listaPersonalInterno)
            {
                var personalInternoVM = new PersonalInternoVM
                {
                    PersonalInternoId = personalInterno.IdPersonal,
                    Edad = personalInterno.Edad.ToString(),
                    Email = personalInterno.Email,
                    NombreCompleto = personalInterno.Apellido + ", " + personalInterno.Nombre,
                    Telefono = personalInterno.TelCel
                };
                if (personalInterno.IdUsuario != null)
                {
                    personalInternoVM.UsuarioSistema = personalInterno.Usuario.NombreUsuario;
                    personalInternoVM.Rol = personalInterno.Usuario.EsAdministrador ? "Admin" : "Secretario/a";
                }
                if (personalInterno.IdMedico != null)
                {
                    personalInternoVM.Matricula = personalInterno.Medico.MatriculaMedico;
                    personalInternoVM.Rol = personalInterno.Usuario.EsAdministrador ? "Admin" : "Médico/a";
                    var especialidades = personalInterno.Medico.MedicoEspecialidad.Select(x => new EspecialidadMedicoVM
                    {
                        EspecialidadId = x.EspecialidadId,
                        NombrePrecio = x.Especialidad.Nombre,
                        Precio = x.Especialidad.PrecioPorDefecto
                    }).ToList();
                    personalInternoVM.Especialidades = string.Join(", ", especialidades.Select(x => x.NombrePrecio).ToArray());
                }
                listaPersonalInternoVM.Add(personalInternoVM);
            }
            return listaPersonalInternoVM;
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            var agregarPersonalInterno = new AgregarPersonalInterno();
            agregarPersonalInterno.ShowDialog();
            RefrescarGridView();
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (dgvPersonalInterno.CurrentRow != null)
            {
                var personalInternoVMSeleccionado = ((PersonalInternoVM)dgvPersonalInterno.CurrentRow.DataBoundItem);
                var editarEspecialidad = new EditarPersonalInterno(personalInternoVMSeleccionado.PersonalInternoId);
                editarEspecialidad.ShowDialog();
                RefrescarGridView();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxBuscar.Text))
            {
                // Retornar todos los registros porque no escribio nada para buscar
                RefrescarGridView();
                return;
            }
            using (var entidades = new ClinicaEntities())
            {
                var listaFiltradaDePersonalInterno = entidades.PersonalInterno.Where(x =>
                                                             x.Bajalogica == false && (
                                                             x.Nombre.ToLower().Contains(txtBoxBuscar.Text.ToLower()) ||
                                                             x.Apellido.ToLower().Contains(txtBoxBuscar.Text.ToLower()))).ToList();
                personalInternoVMBindingSource.DataSource = ConstruirListaDePersonalInternoVM(listaFiltradaDePersonalInterno);
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            // Chequear si no se esta usando se setea a TRUE la columna BajaLogica, 
            // de lo contrario se muestra por pantalla un msj de que esta en uso
            //if (dgvEspecialidades.CurrentRow != null)
            //{
            //    Especialidad especialidadSeleccionada = ((Especialidad)dgvEspecialidades.CurrentRow.DataBoundItem);
            //    using (var entidades = new ClinicaEntities())
            //    {
            //        if (entidades.MedicoEspecialidad.Any(x => x.EspecialidadId == especialidadSeleccionada.EspecialidadId))
            //        {
            //            MessageBox.Show("No se puede eliminar esta especialidad ya que esta siendo utilizada por un medico", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        }
            //        else
            //        {
            //            var especialidadDB = entidades.Especialidad.First(x => x.EspecialidadId == especialidadSeleccionada.EspecialidadId);
            //            especialidadDB.BajaLogica = true;
            //            entidades.SaveChanges();
            //            MessageBox.Show("Especialidad eliminada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            RefrescarGridView();
            //        }
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Debe seleccionar una fila", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

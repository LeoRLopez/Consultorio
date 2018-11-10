using Consultorio.Forms;
using Consultorio.Modelo;
using System;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls.Export;

namespace Consultorio
{
    public partial class ListadoSegurosMedicos : Form
    {
        public ListadoSegurosMedicos(bool __esAdministrador)
        {
            InitializeComponent();

            btnEditar.Visible = __esAdministrador;
            btnHabilitar.Visible = __esAdministrador;
        }

        private void Forma_Pago_Load(object sender, EventArgs e)
        {
            RefrescarGridView();
        }

        private void RefrescarGridView()
        {
            using (var entidades = new ClinicaEntities())
            {
                segurosMedicoBindingSource.DataSource = entidades.SegurosMedico.ToList().Select(x => new SegurosMedico
                {
                    IdSeguroMedico = x.IdSeguroMedico,
                    Nombre = x.Nombre,
                    BajaLogica = !x.BajaLogica
                }).ToList();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxBuscar.Text))
            {
                // Retornar todos los registros porque no escribio nada para buscar
                RefrescarGridView();
                return;
            }
            using (var entidades = new ClinicaEntities())
            {
                segurosMedicoBindingSource.DataSource = entidades.SegurosMedico.Where(x => x.Nombre.ToLower().Contains(txtBoxBuscar.Text.ToLower())).ToList();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var agregarObraSocial = new AgregarEditarSeguroMedico();
            agregarObraSocial.ShowDialog();
            RefrescarGridView();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(dgvObrasSociales.CurrentRow != null)
            {
                SegurosMedico segurosMedicoSeleccionado = ((SegurosMedico)dgvObrasSociales.CurrentRow.DataBoundItem);
                var editarObraSocial = new AgregarEditarSeguroMedico(segurosMedicoSeleccionado);
                editarObraSocial.ShowDialog();
                RefrescarGridView();
            }
        }

        private void btnHabilitarDeshabilitar_Click(object sender, EventArgs e)
        {
            if (dgvObrasSociales.CurrentRow != null)
            {
                SegurosMedico seguroMedicoSeleccionado = ((SegurosMedico)dgvObrasSociales.CurrentRow.DataBoundItem);
                using (var entidades = new ClinicaEntities())
                {
                    var SeguroMedicoDB = entidades.SegurosMedico.First(x => x.IdSeguroMedico == seguroMedicoSeleccionado.IdSeguroMedico);
                    SeguroMedicoDB.BajaLogica = seguroMedicoSeleccionado.BajaLogica;

                    entidades.SaveChanges();
                    MessageBox.Show("Realizado Correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefrescarGridView();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            GridViewSpreadExport spreadExporter = new GridViewSpreadExport(this.dgvObrasSociales, SpreadExportFormat.Xlsx);
            SpreadExportRenderer exportRenderer = new SpreadExportRenderer();
            var rutaEscritorioWindows = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            try
            {
                spreadExporter.RunExport(rutaEscritorioWindows + "\\Listado de Obras Sociales.xlsx", exportRenderer, "Listado de Pacientes");
                MessageBox.Show("Listado de Obras Sociales.xlsx guardado en el Escritorio", "Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Reporte", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
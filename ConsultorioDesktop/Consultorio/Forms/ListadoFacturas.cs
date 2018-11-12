using Consultorio.Modelo;
using Consultorio.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;

namespace Consultorio.Reportes
{
    public partial class ListadoFacturas : Form
    {
        public ListadoFacturas()
        {
            InitializeComponent();
            dtpDesde.Value = DateTime.Now.Date;
            dtpHasta.Value = DateTime.Now.AddMonths(1).Date;
        }

        private void Pacientes_Load(object sender, EventArgs e)
        {
            CargarTurnos();
            CargarFormasDePago();
            CargarMedicos();
        }

        private void CargarTurnos()
        {
            using (var entidades = new ClinicaEntities())
            {
                var facturasVM = new List<FacturaTurnoVM>();
                foreach (var factura in entidades.Factura.Include(x => x.FormaDePago).Include(x => x.Turno).Include(x => x.Tarjetas).ToList())
                {
                    facturasVM.Add(new FacturaTurnoVM
                    {
                        DescripcionFactura = factura.Descripcion,
                        FechaFactura = factura.Fecha,
                        FechaTurno = factura.Turno.First().FechaYHora,
                        FormaDePago = factura.Turno.First().FormaDePago.Nombre,
                        IdFactura = factura.IdFactura,
                        IdFormaDePago = factura.Turno.First().IdFormaDePago,
                        IdMedico = factura.Turno.First().IdMedico,
                        IdPaciente = factura.Turno.First().IdPaciente,
                        IdTarjeta = factura.IdTarjeta,
                        IdTurno = factura.Turno.First().IdTurno,
                        MedicoNombreCompleto = factura.Turno.First().Medico.PersonalInterno.First().Apellido + ", " + factura.Turno.First().Medico.PersonalInterno.First().Nombre,
                        MontoFactura = factura.Monto,
                        PacienteNombreCompleto = factura.Turno.First().Paciente.Apellidos + ", " + factura.Turno.First().Paciente.Nombres,
                        TarjetaNombre = factura.Tarjetas.Nombre
                    });
                }
                facturaTurnoVMBindingSource.DataSource = facturasVM.OrderByDescending(x => x.FechaFactura).ToList();
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            using (var entidades = new ClinicaEntities())
            {
                var facturasVM = new List<FacturaTurnoVM>();
                foreach (var factura in entidades.Factura.Include(x => x.FormaDePago).Include(x => x.Turno).Include(x => x.Tarjetas).ToList())
                {
                    facturasVM.Add(new FacturaTurnoVM
                    {
                        DescripcionFactura = factura.Descripcion,
                        FechaFactura = factura.Fecha,
                        FechaTurno = factura.Turno.First().FechaYHora,
                        FormaDePago = factura.Turno.First().FormaDePago.Nombre,
                        IdFactura = factura.IdFactura,
                        IdFormaDePago = factura.Turno.First().IdFormaDePago,
                        IdMedico = factura.Turno.First().IdMedico,
                        IdPaciente = factura.Turno.First().IdPaciente,
                        IdTarjeta = factura.IdTarjeta,
                        IdTurno = factura.Turno.First().IdTurno,
                        MedicoNombreCompleto = factura.Turno.First().Medico.PersonalInterno.First().Apellido + ", " + factura.Turno.First().Medico.PersonalInterno.First().Nombre,
                        MontoFactura = factura.Monto,
                        PacienteNombreCompleto = factura.Turno.First().Paciente.Apellidos + ", " + factura.Turno.First().Paciente.Nombres,
                        TarjetaNombre = factura.Tarjetas.Nombre
                    });
                }

                // Si selecciona un medico tenemos que ir a buscar todos las facturas de ese medico
                if ((int)dropDownMedicos.SelectedValue != -1)
                {
                    facturasVM = facturasVM.Where(x => x.IdMedico == (int)dropDownMedicos.SelectedValue).ToList();
                }

                // Si selecciona una forma de pago, volvemos a filtrar la lista
                if ((int)dropDownFormasDePago.SelectedValue != -1)
                {
                    facturasVM = facturasVM.Where(x => x.IdFormaDePago == (int)dropDownFormasDePago.SelectedValue).ToList();
                }

                // Lo mismo para la fecha Desde
                if (dtpDesde.Checked)
                {
                    facturasVM = facturasVM.Where(x => x.FechaFactura.Date >= dtpDesde.Value.Date).ToList();
                }

                // Igual para Hasta
                if (dtpHasta.Checked)
                {
                    facturasVM = facturasVM.Where(x => x.FechaFactura.Date <= dtpHasta.Value.Date).ToList();
                }

                facturaTurnoVMBindingSource.DataSource = facturasVM.OrderByDescending(x => x.FechaFactura).ToList();
            }
        }

        private void CargarMedicos()
        {
            using (var entidades = new ClinicaEntities())
            {
                dropDownMedicos.ValueMember = "MedicoId";
                dropDownMedicos.DisplayMember = "NombreCompleto";
                var medicos = new List<MedicoVM> { new MedicoVM { MedicoId = -1, NombreCompleto = "Todos los Medicos" } };
                medicos.AddRange(entidades.Medico.Select(medico =>
                new MedicoVM
                {
                    MedicoId = medico.IdMedico,
                    Matricula = medico.MatriculaMedico,
                    NombreCompleto = medico.PersonalInterno.FirstOrDefault().Apellido + ", " + medico.PersonalInterno.FirstOrDefault().Nombre //+ " (" + medico.Especialidad + ")"
                }).OrderBy(x => x.NombreCompleto).ToList());
                dropDownMedicos.DataSource = medicos;
            }
        }

        private void CargarFormasDePago()
        {
            using (var entidades = new ClinicaEntities())
            {
                dropDownFormasDePago.ValueMember = "IdFormaDePago";
                dropDownFormasDePago.DisplayMember = "Nombre";
                var formasDePago = new List<FormaDePago> { new FormaDePago { IdFormaDePago = -1, Nombre = "Todas las Forma de Pago" } };
                formasDePago.AddRange(entidades.FormaDePago.OrderBy(x => x.Nombre).ToList());
                dropDownFormasDePago.DataSource = formasDePago;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarTurno nuevoTurno = new AgregarTurno();
            nuevoTurno.ShowDialog();
            CargarTurnos();
        }
    }
}
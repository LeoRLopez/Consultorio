namespace Consultorio.Reportes
{
    partial class ListadoFacturas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelOpciones = new Telerik.WinControls.UI.RadPanel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.btnFiltrar = new Telerik.WinControls.UI.RadButton();
            this.dropDownFormasDePago = new Telerik.WinControls.UI.RadDropDownList();
            this.lblFormaDePago = new System.Windows.Forms.Label();
            this.labelMedico = new Telerik.WinControls.UI.RadLabel();
            this.dropDownMedicos = new Telerik.WinControls.UI.RadDropDownList();
            this.object_b5eba493_7d85_4956_839f_e2e31e6ce190 = new Telerik.WinControls.RootRadElement();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.idFacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTurnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMedicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFormaDePagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTarjetaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaTurnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacienteNombreCompletoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicoNombreCompletoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoFacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormaDePago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionFacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TarjetaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturaTurnoVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelOpciones)).BeginInit();
            this.panelOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFiltrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownFormasDePago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelMedico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownMedicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaTurnoVMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOpciones
            // 
            this.panelOpciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            this.panelOpciones.Controls.Add(this.radLabel2);
            this.panelOpciones.Controls.Add(this.radLabel1);
            this.panelOpciones.Controls.Add(this.dtpHasta);
            this.panelOpciones.Controls.Add(this.dtpDesde);
            this.panelOpciones.Controls.Add(this.btnFiltrar);
            this.panelOpciones.Controls.Add(this.dropDownFormasDePago);
            this.panelOpciones.Controls.Add(this.lblFormaDePago);
            this.panelOpciones.Controls.Add(this.labelMedico);
            this.panelOpciones.Controls.Add(this.dropDownMedicos);
            this.panelOpciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOpciones.Location = new System.Drawing.Point(0, 0);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(1188, 168);
            this.panelOpciones.TabIndex = 0;
            this.panelOpciones.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radLabel2
            // 
            this.radLabel2.BackColor = System.Drawing.Color.Transparent;
            this.radLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(265, 59);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(39, 17);
            this.radLabel2.TabIndex = 11;
            this.radLabel2.Text = "Hasta";
            this.radLabel2.ThemeName = "MedicalAppTheme";
            // 
            // radLabel1
            // 
            this.radLabel1.BackColor = System.Drawing.Color.Transparent;
            this.radLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(265, 12);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(42, 17);
            this.radLabel1.TabIndex = 22;
            this.radLabel1.Text = "Desde";
            this.radLabel1.ThemeName = "MedicalAppTheme";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Checked = false;
            this.dtpHasta.CustomFormat = "dd/MM/yyyy";
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHasta.Location = new System.Drawing.Point(265, 82);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.ShowCheckBox = true;
            this.dtpHasta.Size = new System.Drawing.Size(140, 20);
            this.dtpHasta.TabIndex = 21;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Checked = false;
            this.dtpDesde.CustomFormat = "dd/MM/yyyy";
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDesde.Location = new System.Drawing.Point(265, 33);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.ShowCheckBox = true;
            this.dtpDesde.Size = new System.Drawing.Size(140, 20);
            this.dtpDesde.TabIndex = 20;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(265, 116);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(140, 38);
            this.btnFiltrar.TabIndex = 18;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.ThemeName = "ControlDefault";
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnFiltrar.GetChildAt(0))).UseSmallImageList = true;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnFiltrar.GetChildAt(0))).Image = null;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnFiltrar.GetChildAt(0))).Text = "Filtrar";
            ((Telerik.WinControls.Layouts.ImageAndTextLayoutPanel)(this.btnFiltrar.GetChildAt(0).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnFiltrar.GetChildAt(0).GetChildAt(1).GetChildAt(0))).StretchHorizontally = false;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnFiltrar.GetChildAt(0).GetChildAt(1).GetChildAt(0))).StretchVertically = false;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnFiltrar.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageLayout = System.Windows.Forms.ImageLayout.Center;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnFiltrar.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ScaleSize = new System.Drawing.Size(25, 25);
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnFiltrar.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnFiltrar.GetChildAt(0).GetChildAt(1).GetChildAt(0))).CustomFontSize = 15F;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnFiltrar.GetChildAt(0).GetChildAt(1).GetChildAt(0))).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.Auto;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnFiltrar.GetChildAt(0).GetChildAt(1).GetChildAt(0))).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnFiltrar.GetChildAt(0).GetChildAt(1).GetChildAt(0))).PositionOffset = new System.Drawing.SizeF(10F, 0F);
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnFiltrar.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ClickMode = Telerik.WinControls.ClickMode.Release;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.btnFiltrar.GetChildAt(0).GetChildAt(1).GetChildAt(1))).LineLimit = false;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.btnFiltrar.GetChildAt(0).GetChildAt(1).GetChildAt(1))).CustomFontSize = 15F;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.btnFiltrar.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dropDownFormasDePago
            // 
            this.dropDownFormasDePago.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.dropDownFormasDePago.DisplayMember = "Apellidos";
            this.dropDownFormasDePago.EnableKineticScrolling = true;
            this.dropDownFormasDePago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropDownFormasDePago.Location = new System.Drawing.Point(20, 82);
            this.dropDownFormasDePago.Name = "dropDownFormasDePago";
            this.dropDownFormasDePago.Size = new System.Drawing.Size(222, 19);
            this.dropDownFormasDePago.TabIndex = 17;
            this.dropDownFormasDePago.ThemeName = "MedicalAppTheme";
            this.dropDownFormasDePago.ValueMember = "IdPaciente";
            // 
            // lblFormaDePago
            // 
            this.lblFormaDePago.AutoSize = true;
            this.lblFormaDePago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaDePago.Location = new System.Drawing.Point(20, 64);
            this.lblFormaDePago.Name = "lblFormaDePago";
            this.lblFormaDePago.Size = new System.Drawing.Size(92, 15);
            this.lblFormaDePago.TabIndex = 15;
            this.lblFormaDePago.Text = "Forma de Pago";
            // 
            // labelMedico
            // 
            this.labelMedico.BackColor = System.Drawing.Color.Transparent;
            this.labelMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMedico.Location = new System.Drawing.Point(20, 12);
            this.labelMedico.Name = "labelMedico";
            this.labelMedico.Size = new System.Drawing.Size(46, 17);
            this.labelMedico.TabIndex = 10;
            this.labelMedico.Text = "Medico";
            this.labelMedico.ThemeName = "MedicalAppTheme";
            // 
            // dropDownMedicos
            // 
            this.dropDownMedicos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.dropDownMedicos.DisplayMember = "Apellidos";
            this.dropDownMedicos.EnableKineticScrolling = true;
            this.dropDownMedicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropDownMedicos.Location = new System.Drawing.Point(20, 33);
            this.dropDownMedicos.Name = "dropDownMedicos";
            this.dropDownMedicos.Size = new System.Drawing.Size(222, 19);
            this.dropDownMedicos.TabIndex = 11;
            this.dropDownMedicos.ThemeName = "MedicalAppTheme";
            this.dropDownMedicos.ValueMember = "IdPaciente";
            // 
            // object_b5eba493_7d85_4956_839f_e2e31e6ce190
            // 
            this.object_b5eba493_7d85_4956_839f_e2e31e6ce190.Name = "object_b5eba493_7d85_4956_839f_e2e31e6ce190";
            this.object_b5eba493_7d85_4956_839f_e2e31e6ce190.StretchHorizontally = true;
            this.object_b5eba493_7d85_4956_839f_e2e31e6ce190.StretchVertically = true;
            // 
            // radPanel1
            // 
            this.radPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radPanel1.BackColor = System.Drawing.Color.Snow;
            this.radPanel1.Controls.Add(this.dgvFacturas);
            this.radPanel1.Controls.Add(this.panelOpciones);
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(1188, 588);
            this.radPanel1.TabIndex = 1;
            this.radPanel1.Text = "radPanel1";
            this.radPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.AllowUserToAddRows = false;
            this.dgvFacturas.AllowUserToDeleteRows = false;
            this.dgvFacturas.AutoGenerateColumns = false;
            this.dgvFacturas.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFacturaDataGridViewTextBoxColumn,
            this.idTurnoDataGridViewTextBoxColumn,
            this.idPacienteDataGridViewTextBoxColumn,
            this.idMedicoDataGridViewTextBoxColumn,
            this.idFormaDePagoDataGridViewTextBoxColumn,
            this.idTarjetaDataGridViewTextBoxColumn,
            this.fechaTurnoDataGridViewTextBoxColumn,
            this.pacienteNombreCompletoDataGridViewTextBoxColumn,
            this.medicoNombreCompletoDataGridViewTextBoxColumn,
            this.fechaFacturaDataGridViewTextBoxColumn,
            this.montoFacturaDataGridViewTextBoxColumn,
            this.FormaDePago,
            this.descripcionFacturaDataGridViewTextBoxColumn,
            this.TarjetaNombre});
            this.dgvFacturas.DataSource = this.facturaTurnoVMBindingSource;
            this.dgvFacturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFacturas.Location = new System.Drawing.Point(0, 168);
            this.dgvFacturas.MultiSelect = false;
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.ReadOnly = true;
            this.dgvFacturas.RowHeadersVisible = false;
            this.dgvFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFacturas.Size = new System.Drawing.Size(1188, 420);
            this.dgvFacturas.TabIndex = 1;
            // 
            // idFacturaDataGridViewTextBoxColumn
            // 
            this.idFacturaDataGridViewTextBoxColumn.DataPropertyName = "IdFactura";
            this.idFacturaDataGridViewTextBoxColumn.HeaderText = "IdFactura";
            this.idFacturaDataGridViewTextBoxColumn.Name = "idFacturaDataGridViewTextBoxColumn";
            this.idFacturaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idFacturaDataGridViewTextBoxColumn.Visible = false;
            // 
            // idTurnoDataGridViewTextBoxColumn
            // 
            this.idTurnoDataGridViewTextBoxColumn.DataPropertyName = "IdTurno";
            this.idTurnoDataGridViewTextBoxColumn.HeaderText = "IdTurno";
            this.idTurnoDataGridViewTextBoxColumn.Name = "idTurnoDataGridViewTextBoxColumn";
            this.idTurnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTurnoDataGridViewTextBoxColumn.Visible = false;
            // 
            // idPacienteDataGridViewTextBoxColumn
            // 
            this.idPacienteDataGridViewTextBoxColumn.DataPropertyName = "IdPaciente";
            this.idPacienteDataGridViewTextBoxColumn.HeaderText = "IdPaciente";
            this.idPacienteDataGridViewTextBoxColumn.Name = "idPacienteDataGridViewTextBoxColumn";
            this.idPacienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPacienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // idMedicoDataGridViewTextBoxColumn
            // 
            this.idMedicoDataGridViewTextBoxColumn.DataPropertyName = "IdMedico";
            this.idMedicoDataGridViewTextBoxColumn.HeaderText = "IdMedico";
            this.idMedicoDataGridViewTextBoxColumn.Name = "idMedicoDataGridViewTextBoxColumn";
            this.idMedicoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idMedicoDataGridViewTextBoxColumn.Visible = false;
            // 
            // idFormaDePagoDataGridViewTextBoxColumn
            // 
            this.idFormaDePagoDataGridViewTextBoxColumn.DataPropertyName = "IdFormaDePago";
            this.idFormaDePagoDataGridViewTextBoxColumn.HeaderText = "IdFormaDePago";
            this.idFormaDePagoDataGridViewTextBoxColumn.Name = "idFormaDePagoDataGridViewTextBoxColumn";
            this.idFormaDePagoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idFormaDePagoDataGridViewTextBoxColumn.Visible = false;
            // 
            // idTarjetaDataGridViewTextBoxColumn
            // 
            this.idTarjetaDataGridViewTextBoxColumn.DataPropertyName = "IdTarjeta";
            this.idTarjetaDataGridViewTextBoxColumn.HeaderText = "IdTarjeta";
            this.idTarjetaDataGridViewTextBoxColumn.Name = "idTarjetaDataGridViewTextBoxColumn";
            this.idTarjetaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTarjetaDataGridViewTextBoxColumn.Visible = false;
            // 
            // fechaTurnoDataGridViewTextBoxColumn
            // 
            this.fechaTurnoDataGridViewTextBoxColumn.DataPropertyName = "FechaTurno";
            this.fechaTurnoDataGridViewTextBoxColumn.HeaderText = "Fecha Turno";
            this.fechaTurnoDataGridViewTextBoxColumn.Name = "fechaTurnoDataGridViewTextBoxColumn";
            this.fechaTurnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaTurnoDataGridViewTextBoxColumn.Width = 150;
            // 
            // pacienteNombreCompletoDataGridViewTextBoxColumn
            // 
            this.pacienteNombreCompletoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pacienteNombreCompletoDataGridViewTextBoxColumn.DataPropertyName = "PacienteNombreCompleto";
            this.pacienteNombreCompletoDataGridViewTextBoxColumn.HeaderText = "Paciente";
            this.pacienteNombreCompletoDataGridViewTextBoxColumn.Name = "pacienteNombreCompletoDataGridViewTextBoxColumn";
            this.pacienteNombreCompletoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // medicoNombreCompletoDataGridViewTextBoxColumn
            // 
            this.medicoNombreCompletoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.medicoNombreCompletoDataGridViewTextBoxColumn.DataPropertyName = "MedicoNombreCompleto";
            this.medicoNombreCompletoDataGridViewTextBoxColumn.HeaderText = "Médico";
            this.medicoNombreCompletoDataGridViewTextBoxColumn.Name = "medicoNombreCompletoDataGridViewTextBoxColumn";
            this.medicoNombreCompletoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaFacturaDataGridViewTextBoxColumn
            // 
            this.fechaFacturaDataGridViewTextBoxColumn.DataPropertyName = "FechaFactura";
            this.fechaFacturaDataGridViewTextBoxColumn.HeaderText = "Fecha Factura";
            this.fechaFacturaDataGridViewTextBoxColumn.Name = "fechaFacturaDataGridViewTextBoxColumn";
            this.fechaFacturaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaFacturaDataGridViewTextBoxColumn.Width = 150;
            // 
            // montoFacturaDataGridViewTextBoxColumn
            // 
            this.montoFacturaDataGridViewTextBoxColumn.DataPropertyName = "MontoFactura";
            this.montoFacturaDataGridViewTextBoxColumn.HeaderText = "Total";
            this.montoFacturaDataGridViewTextBoxColumn.Name = "montoFacturaDataGridViewTextBoxColumn";
            this.montoFacturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormaDePago
            // 
            this.FormaDePago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FormaDePago.DataPropertyName = "FormaDePago";
            this.FormaDePago.HeaderText = "Forma de Pago";
            this.FormaDePago.Name = "FormaDePago";
            this.FormaDePago.ReadOnly = true;
            // 
            // descripcionFacturaDataGridViewTextBoxColumn
            // 
            this.descripcionFacturaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcionFacturaDataGridViewTextBoxColumn.DataPropertyName = "DescripcionFactura";
            this.descripcionFacturaDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.descripcionFacturaDataGridViewTextBoxColumn.Name = "descripcionFacturaDataGridViewTextBoxColumn";
            this.descripcionFacturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TarjetaNombre
            // 
            this.TarjetaNombre.DataPropertyName = "TarjetaNombre";
            this.TarjetaNombre.HeaderText = "Tarjeta";
            this.TarjetaNombre.Name = "TarjetaNombre";
            this.TarjetaNombre.ReadOnly = true;
            this.TarjetaNombre.Width = 150;
            // 
            // facturaTurnoVMBindingSource
            // 
            this.facturaTurnoVMBindingSource.DataSource = typeof(Consultorio.ViewModels.FacturaTurnoVM);
            // 
            // ListadoFacturas
            // 
            this.AcceptButton = this.btnFiltrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1188, 590);
            this.Controls.Add(this.radPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListadoFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Turnos";
            this.Load += new System.EventHandler(this.Pacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelOpciones)).EndInit();
            this.panelOpciones.ResumeLayout(false);
            this.panelOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFiltrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownFormasDePago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelMedico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownMedicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaTurnoVMBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel panelOpciones;
        private Telerik.WinControls.RootRadElement object_b5eba493_7d85_4956_839f_e2e31e6ce190;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadLabel labelMedico;
        private Telerik.WinControls.UI.RadDropDownList dropDownMedicos;
        private System.Windows.Forms.Label lblFormaDePago;
        private Telerik.WinControls.UI.RadDropDownList dropDownFormasDePago;
        private Telerik.WinControls.UI.RadButton btnFiltrar;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private System.Windows.Forms.DataGridView dgvFacturas;
        private System.Windows.Forms.BindingSource facturaTurnoVMBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTurnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFormaDePagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTarjetaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaTurnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacienteNombreCompletoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicoNombreCompletoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoFacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormaDePago;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionFacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TarjetaNombre;
    }
}
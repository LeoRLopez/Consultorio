namespace Consultorio.Reportes
{
    partial class ReporteListadoPacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteListadoPacientes));
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.panelOpciones = new Telerik.WinControls.UI.RadPanel();
            this.btnVolver = new Telerik.WinControls.UI.RadButton();
            this.btnFiltrar = new Telerik.WinControls.UI.RadButton();
            this.dropDownFormasDePago = new Telerik.WinControls.UI.RadDropDownList();
            this.dropDownSegurosMedicos = new Telerik.WinControls.UI.RadDropDownList();
            this.lblSeguroMedico = new System.Windows.Forms.Label();
            this.lblFormaDePago = new System.Windows.Forms.Label();
            this.labelMedico = new Telerik.WinControls.UI.RadLabel();
            this.dropDownMedicos = new Telerik.WinControls.UI.RadDropDownList();
            this.btnExportar = new Telerik.WinControls.UI.RadButton();
            this.object_b5eba493_7d85_4956_839f_e2e31e6ce190 = new Telerik.WinControls.RootRadElement();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.dgvPacientes = new Telerik.WinControls.UI.RadGridView();
            this.pacienteVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelOpciones)).BeginInit();
            this.panelOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFiltrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownFormasDePago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownSegurosMedicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelMedico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownMedicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExportar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteVMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOpciones
            // 
            this.panelOpciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            this.panelOpciones.Controls.Add(this.btnVolver);
            this.panelOpciones.Controls.Add(this.btnFiltrar);
            this.panelOpciones.Controls.Add(this.dropDownFormasDePago);
            this.panelOpciones.Controls.Add(this.dropDownSegurosMedicos);
            this.panelOpciones.Controls.Add(this.lblSeguroMedico);
            this.panelOpciones.Controls.Add(this.lblFormaDePago);
            this.panelOpciones.Controls.Add(this.labelMedico);
            this.panelOpciones.Controls.Add(this.dropDownMedicos);
            this.panelOpciones.Controls.Add(this.btnExportar);
            this.panelOpciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOpciones.Location = new System.Drawing.Point(0, 0);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(683, 168);
            this.panelOpciones.TabIndex = 0;
            this.panelOpciones.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVolver
            // 
            this.btnVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(532, 57);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(104, 44);
            this.btnVolver.TabIndex = 19;
            this.btnVolver.Text = "Volver";
            this.btnVolver.ThemeName = "ControlDefault";
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnVolver.GetChildAt(0))).UseSmallImageList = true;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnVolver.GetChildAt(0))).Image = null;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnVolver.GetChildAt(0))).Text = "Volver";
            ((Telerik.WinControls.Layouts.ImageAndTextLayoutPanel)(this.btnVolver.GetChildAt(0).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnVolver.GetChildAt(0).GetChildAt(1).GetChildAt(0))).StretchHorizontally = false;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnVolver.GetChildAt(0).GetChildAt(1).GetChildAt(0))).StretchVertically = false;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnVolver.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageLayout = System.Windows.Forms.ImageLayout.Center;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnVolver.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ScaleSize = new System.Drawing.Size(25, 25);
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnVolver.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnVolver.GetChildAt(0).GetChildAt(1).GetChildAt(0))).CustomFontSize = 15F;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnVolver.GetChildAt(0).GetChildAt(1).GetChildAt(0))).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.Auto;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnVolver.GetChildAt(0).GetChildAt(1).GetChildAt(0))).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnVolver.GetChildAt(0).GetChildAt(1).GetChildAt(0))).PositionOffset = new System.Drawing.SizeF(10F, 0F);
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnVolver.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ClickMode = Telerik.WinControls.ClickMode.Release;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.btnVolver.GetChildAt(0).GetChildAt(1).GetChildAt(1))).LineLimit = false;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.btnVolver.GetChildAt(0).GetChildAt(1).GetChildAt(1))).CustomFontSize = 15F;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.btnVolver.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(258, 57);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(97, 44);
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
            this.dropDownFormasDePago.Location = new System.Drawing.Point(20, 73);
            this.dropDownFormasDePago.Name = "dropDownFormasDePago";
            this.dropDownFormasDePago.Size = new System.Drawing.Size(222, 19);
            this.dropDownFormasDePago.TabIndex = 17;
            this.dropDownFormasDePago.ThemeName = "MedicalAppTheme";
            this.dropDownFormasDePago.ValueMember = "IdPaciente";
            // 
            // dropDownSegurosMedicos
            // 
            this.dropDownSegurosMedicos.DisplayMember = "Nombre";
            this.dropDownSegurosMedicos.EnableKineticScrolling = true;
            this.dropDownSegurosMedicos.Location = new System.Drawing.Point(20, 113);
            this.dropDownSegurosMedicos.Name = "dropDownSegurosMedicos";
            this.dropDownSegurosMedicos.Size = new System.Drawing.Size(222, 20);
            this.dropDownSegurosMedicos.SortStyle = Telerik.WinControls.Enumerations.SortStyle.Ascending;
            this.dropDownSegurosMedicos.TabIndex = 14;
            this.dropDownSegurosMedicos.ThemeName = "ControlDefault";
            this.dropDownSegurosMedicos.ValueMember = "IdSeguroMedico";
            // 
            // lblSeguroMedico
            // 
            this.lblSeguroMedico.AutoSize = true;
            this.lblSeguroMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeguroMedico.Location = new System.Drawing.Point(20, 95);
            this.lblSeguroMedico.Name = "lblSeguroMedico";
            this.lblSeguroMedico.Size = new System.Drawing.Size(91, 15);
            this.lblSeguroMedico.TabIndex = 16;
            this.lblSeguroMedico.Text = "Seguro Médico";
            // 
            // lblFormaDePago
            // 
            this.lblFormaDePago.AutoSize = true;
            this.lblFormaDePago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaDePago.Location = new System.Drawing.Point(20, 55);
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
            // btnExportar
            // 
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.Image = ((System.Drawing.Image)(resources.GetObject("btnExportar.Image")));
            this.btnExportar.Location = new System.Drawing.Point(382, 57);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(115, 44);
            this.btnExportar.TabIndex = 2;
            this.btnExportar.Text = "       Exportar";
            this.btnExportar.ThemeName = "ControlDefault";
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnExportar.GetChildAt(0))).UseSmallImageList = true;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnExportar.GetChildAt(0))).Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnExportar.GetChildAt(0))).Text = "       Exportar";
            ((Telerik.WinControls.Layouts.ImageAndTextLayoutPanel)(this.btnExportar.GetChildAt(0).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnExportar.GetChildAt(0).GetChildAt(1).GetChildAt(0))).StretchHorizontally = false;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnExportar.GetChildAt(0).GetChildAt(1).GetChildAt(0))).StretchVertically = false;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnExportar.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageLayout = System.Windows.Forms.ImageLayout.Center;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnExportar.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ScaleSize = new System.Drawing.Size(25, 25);
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnExportar.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnExportar.GetChildAt(0).GetChildAt(1).GetChildAt(0))).CustomFontSize = 15F;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnExportar.GetChildAt(0).GetChildAt(1).GetChildAt(0))).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.Auto;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnExportar.GetChildAt(0).GetChildAt(1).GetChildAt(0))).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnExportar.GetChildAt(0).GetChildAt(1).GetChildAt(0))).PositionOffset = new System.Drawing.SizeF(10F, 0F);
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnExportar.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ClickMode = Telerik.WinControls.ClickMode.Release;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.btnExportar.GetChildAt(0).GetChildAt(1).GetChildAt(1))).LineLimit = false;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.btnExportar.GetChildAt(0).GetChildAt(1).GetChildAt(1))).CustomFontSize = 15F;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.btnExportar.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // object_b5eba493_7d85_4956_839f_e2e31e6ce190
            // 
            this.object_b5eba493_7d85_4956_839f_e2e31e6ce190.Name = "object_b5eba493_7d85_4956_839f_e2e31e6ce190";
            this.object_b5eba493_7d85_4956_839f_e2e31e6ce190.StretchHorizontally = true;
            this.object_b5eba493_7d85_4956_839f_e2e31e6ce190.StretchVertically = true;
            // 
            // radPanel1
            // 
            this.radPanel1.BackColor = System.Drawing.Color.Snow;
            this.radPanel1.Controls.Add(this.dgvPacientes);
            this.radPanel1.Controls.Add(this.panelOpciones);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(683, 642);
            this.radPanel1.TabIndex = 1;
            this.radPanel1.Text = "radPanel1";
            this.radPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.BackColor = System.Drawing.Color.Snow;
            this.dgvPacientes.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvPacientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPacientes.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dgvPacientes.ForeColor = System.Drawing.Color.Black;
            this.dgvPacientes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvPacientes.Location = new System.Drawing.Point(0, 168);
            // 
            // 
            // 
            this.dgvPacientes.MasterTemplate.AllowAddNewRow = false;
            this.dgvPacientes.MasterTemplate.AllowColumnChooser = false;
            this.dgvPacientes.MasterTemplate.AllowColumnReorder = false;
            this.dgvPacientes.MasterTemplate.AllowColumnResize = false;
            this.dgvPacientes.MasterTemplate.AllowDeleteRow = false;
            this.dgvPacientes.MasterTemplate.AllowDragToGroup = false;
            this.dgvPacientes.MasterTemplate.AllowEditRow = false;
            this.dgvPacientes.MasterTemplate.AllowRowResize = false;
            this.dgvPacientes.MasterTemplate.AutoGenerateColumns = false;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "PacienteId";
            gridViewDecimalColumn1.HeaderText = "PacienteId";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "PacienteId";
            gridViewDecimalColumn2.DataType = typeof(System.Nullable<int>);
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "IdHistoriaClinica";
            gridViewDecimalColumn2.HeaderText = "IdHistoriaClinica";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.IsVisible = false;
            gridViewDecimalColumn2.Name = "IdHistoriaClinica";
            gridViewTextBoxColumn1.AllowGroup = false;
            gridViewTextBoxColumn1.AllowResize = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "NombreCompleto";
            gridViewTextBoxColumn1.HeaderText = "Paciente";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "NombreCompleto";
            gridViewTextBoxColumn1.VisibleInColumnChooser = false;
            gridViewTextBoxColumn1.Width = 250;
            gridViewTextBoxColumn2.AllowGroup = false;
            gridViewTextBoxColumn2.AllowResize = false;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "NroDocumento";
            gridViewTextBoxColumn2.HeaderText = "Nro. Documento";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "NroDocumento";
            gridViewTextBoxColumn2.VisibleInColumnChooser = false;
            gridViewTextBoxColumn2.Width = 100;
            gridViewTextBoxColumn3.AllowGroup = false;
            gridViewTextBoxColumn3.AllowResize = false;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "Edad";
            gridViewTextBoxColumn3.HeaderText = "Edad";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "Edad";
            gridViewTextBoxColumn3.VisibleInColumnChooser = false;
            gridViewTextBoxColumn4.AllowGroup = false;
            gridViewTextBoxColumn4.AllowResize = false;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "Telefono";
            gridViewTextBoxColumn4.HeaderText = "Telefono";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "Telefono";
            gridViewTextBoxColumn4.VisibleInColumnChooser = false;
            gridViewTextBoxColumn4.Width = 85;
            gridViewTextBoxColumn5.AllowGroup = false;
            gridViewTextBoxColumn5.AllowResize = false;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "Direccion";
            gridViewTextBoxColumn5.HeaderText = "Dirección";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "Direccion";
            gridViewTextBoxColumn5.VisibleInColumnChooser = false;
            gridViewTextBoxColumn5.Width = 180;
            this.dgvPacientes.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewDecimalColumn2,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5});
            this.dgvPacientes.MasterTemplate.DataSource = this.pacienteVMBindingSource;
            this.dgvPacientes.MasterTemplate.EnableGrouping = false;
            this.dgvPacientes.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.ReadOnly = true;
            this.dgvPacientes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvPacientes.Size = new System.Drawing.Size(683, 474);
            this.dgvPacientes.TabIndex = 14;
            this.dgvPacientes.Text = "radGridView1";
            // 
            // pacienteVMBindingSource
            // 
            this.pacienteVMBindingSource.DataSource = typeof(Consultorio.ViewModels.PacienteVM);
            // 
            // ReporteListadoPacientes
            // 
            this.AcceptButton = this.btnFiltrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            this.CancelButton = this.btnVolver;
            this.ClientSize = new System.Drawing.Size(683, 642);
            this.Controls.Add(this.radPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReporteListadoPacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Pacientes";
            this.Load += new System.EventHandler(this.Pacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelOpciones)).EndInit();
            this.panelOpciones.ResumeLayout(false);
            this.panelOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFiltrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownFormasDePago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownSegurosMedicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelMedico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownMedicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExportar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteVMBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel panelOpciones;
        private Telerik.WinControls.RootRadElement object_b5eba493_7d85_4956_839f_e2e31e6ce190;
        private Telerik.WinControls.UI.RadButton btnExportar;
        private System.Windows.Forms.BindingSource pacienteVMBindingSource;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadDropDownList dropDownSegurosMedicos;
        private System.Windows.Forms.Label lblSeguroMedico;
        private Telerik.WinControls.UI.RadLabel labelMedico;
        private Telerik.WinControls.UI.RadDropDownList dropDownMedicos;
        private System.Windows.Forms.Label lblFormaDePago;
        private Telerik.WinControls.UI.RadDropDownList dropDownFormasDePago;
        private Telerik.WinControls.UI.RadButton btnFiltrar;
        private Telerik.WinControls.UI.RadButton btnVolver;
        private Telerik.WinControls.UI.RadGridView dgvPacientes;
    }
}
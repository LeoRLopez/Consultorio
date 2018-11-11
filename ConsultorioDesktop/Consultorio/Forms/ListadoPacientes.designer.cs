namespace Consultorio
{
    partial class ListadoPacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoPacientes));
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.panelListaPacientes = new Telerik.WinControls.UI.RadPanel();
            this.panelPacienteSeleccionado = new Telerik.WinControls.UI.RadPanel();
            this.lblGrupoSanguineo = new Telerik.WinControls.UI.RadLabel();
            this.lblTrasplantado = new Telerik.WinControls.UI.RadLabel();
            this.lblDonante = new Telerik.WinControls.UI.RadLabel();
            this.lblTelefono = new Telerik.WinControls.UI.RadLabel();
            this.lblDireccion = new Telerik.WinControls.UI.RadLabel();
            this.lblDiagnostico = new Telerik.WinControls.UI.RadLabel();
            this.txtDiagnostico = new Telerik.WinControls.UI.RadTextBox();
            this.txtHistoriaClinica = new Telerik.WinControls.UI.RadTextBox();
            this.lblEdadSexo = new Telerik.WinControls.UI.RadLabel();
            this.lblNombreApellido = new System.Windows.Forms.Label();
            this.Afecciones = new Telerik.WinControls.UI.RadLabel();
            this.pictureBoxFotoPaciente = new System.Windows.Forms.PictureBox();
            this.object_b5eba493_7d85_4956_839f_e2e31e6ce190 = new Telerik.WinControls.RootRadElement();
            this.btnEditarPaciente = new Telerik.WinControls.UI.RadButton();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.dgvPacientes = new Telerik.WinControls.UI.RadGridView();
            this.pacienteVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelListaPacientes)).BeginInit();
            this.panelListaPacientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPacienteSeleccionado)).BeginInit();
            this.panelPacienteSeleccionado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblGrupoSanguineo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTrasplantado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDonante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDireccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDiagnostico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiagnostico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHistoriaClinica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEdadSexo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Afecciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoPaciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditarPaciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteVMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelListaPacientes
            // 
            this.panelListaPacientes.BackColor = System.Drawing.Color.Snow;
            this.panelListaPacientes.Controls.Add(this.dgvPacientes);
            this.panelListaPacientes.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelListaPacientes.Location = new System.Drawing.Point(0, 0);
            this.panelListaPacientes.Name = "panelListaPacientes";
            this.panelListaPacientes.Size = new System.Drawing.Size(640, 532);
            this.panelListaPacientes.TabIndex = 0;
            this.panelListaPacientes.Text = "panelListaPacientes";
            this.panelListaPacientes.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelPacienteSeleccionado
            // 
            this.panelPacienteSeleccionado.BackColor = System.Drawing.Color.Snow;
            this.panelPacienteSeleccionado.Controls.Add(this.lblGrupoSanguineo);
            this.panelPacienteSeleccionado.Controls.Add(this.lblTrasplantado);
            this.panelPacienteSeleccionado.Controls.Add(this.lblDonante);
            this.panelPacienteSeleccionado.Controls.Add(this.lblTelefono);
            this.panelPacienteSeleccionado.Controls.Add(this.lblDireccion);
            this.panelPacienteSeleccionado.Controls.Add(this.lblDiagnostico);
            this.panelPacienteSeleccionado.Controls.Add(this.txtDiagnostico);
            this.panelPacienteSeleccionado.Controls.Add(this.txtHistoriaClinica);
            this.panelPacienteSeleccionado.Controls.Add(this.lblEdadSexo);
            this.panelPacienteSeleccionado.Controls.Add(this.lblNombreApellido);
            this.panelPacienteSeleccionado.Controls.Add(this.Afecciones);
            this.panelPacienteSeleccionado.Controls.Add(this.pictureBoxFotoPaciente);
            this.panelPacienteSeleccionado.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPacienteSeleccionado.Location = new System.Drawing.Point(640, 0);
            this.panelPacienteSeleccionado.Name = "panelPacienteSeleccionado";
            this.panelPacienteSeleccionado.Size = new System.Drawing.Size(310, 429);
            this.panelPacienteSeleccionado.TabIndex = 1;
            // 
            // lblGrupoSanguineo
            // 
            this.lblGrupoSanguineo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupoSanguineo.Location = new System.Drawing.Point(7, 94);
            this.lblGrupoSanguineo.Name = "lblGrupoSanguineo";
            this.lblGrupoSanguineo.Size = new System.Drawing.Size(112, 18);
            this.lblGrupoSanguineo.TabIndex = 13;
            this.lblGrupoSanguineo.Text = "Grupo Sanguineo";
            // 
            // lblTrasplantado
            // 
            this.lblTrasplantado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrasplantado.Location = new System.Drawing.Point(7, 142);
            this.lblTrasplantado.Name = "lblTrasplantado";
            this.lblTrasplantado.Size = new System.Drawing.Size(85, 18);
            this.lblTrasplantado.TabIndex = 12;
            this.lblTrasplantado.Text = "Trasplantado";
            // 
            // lblDonante
            // 
            this.lblDonante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonante.Location = new System.Drawing.Point(7, 118);
            this.lblDonante.Name = "lblDonante";
            this.lblDonante.Size = new System.Drawing.Size(57, 18);
            this.lblDonante.TabIndex = 11;
            this.lblDonante.Text = "Donante";
            // 
            // lblTelefono
            // 
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(116, 47);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(59, 18);
            this.lblTelefono.TabIndex = 8;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblDireccion
            // 
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(116, 68);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(63, 18);
            this.lblDireccion.TabIndex = 8;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblDiagnostico
            // 
            this.lblDiagnostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiagnostico.Location = new System.Drawing.Point(7, 329);
            this.lblDiagnostico.Name = "lblDiagnostico";
            this.lblDiagnostico.Size = new System.Drawing.Size(77, 18);
            this.lblDiagnostico.TabIndex = 10;
            this.lblDiagnostico.Text = "Diagnóstico";
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiagnostico.AutoSize = false;
            this.txtDiagnostico.Enabled = false;
            this.txtDiagnostico.Location = new System.Drawing.Point(7, 353);
            this.txtDiagnostico.Multiline = true;
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(291, 73);
            this.txtDiagnostico.TabIndex = 9;
            // 
            // txtHistoriaClinica
            // 
            this.txtHistoriaClinica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHistoriaClinica.AutoSize = false;
            this.txtHistoriaClinica.Enabled = false;
            this.txtHistoriaClinica.Location = new System.Drawing.Point(7, 206);
            this.txtHistoriaClinica.Multiline = true;
            this.txtHistoriaClinica.Name = "txtHistoriaClinica";
            this.txtHistoriaClinica.Size = new System.Drawing.Size(291, 117);
            this.txtHistoriaClinica.TabIndex = 8;
            // 
            // lblEdadSexo
            // 
            this.lblEdadSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdadSexo.Location = new System.Drawing.Point(116, 26);
            this.lblEdadSexo.Name = "lblEdadSexo";
            this.lblEdadSexo.Size = new System.Drawing.Size(80, 18);
            this.lblEdadSexo.TabIndex = 7;
            this.lblEdadSexo.Text = "Edad y sexo";
            // 
            // lblNombreApellido
            // 
            this.lblNombreApellido.AutoSize = true;
            this.lblNombreApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreApellido.Location = new System.Drawing.Point(116, 7);
            this.lblNombreApellido.Name = "lblNombreApellido";
            this.lblNombreApellido.Size = new System.Drawing.Size(120, 16);
            this.lblNombreApellido.TabIndex = 6;
            this.lblNombreApellido.Text = "Nombre y Apellido";
            // 
            // Afecciones
            // 
            this.Afecciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Afecciones.Location = new System.Drawing.Point(6, 182);
            this.Afecciones.Name = "Afecciones";
            this.Afecciones.Size = new System.Drawing.Size(96, 18);
            this.Afecciones.TabIndex = 4;
            this.Afecciones.Text = "Historia Clínica";
            // 
            // pictureBoxFotoPaciente
            // 
            this.pictureBoxFotoPaciente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxFotoPaciente.BackgroundImage")));
            this.pictureBoxFotoPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxFotoPaciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxFotoPaciente.Location = new System.Drawing.Point(6, 7);
            this.pictureBoxFotoPaciente.Name = "pictureBoxFotoPaciente";
            this.pictureBoxFotoPaciente.Size = new System.Drawing.Size(101, 81);
            this.pictureBoxFotoPaciente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFotoPaciente.TabIndex = 0;
            this.pictureBoxFotoPaciente.TabStop = false;
            // 
            // object_b5eba493_7d85_4956_839f_e2e31e6ce190
            // 
            this.object_b5eba493_7d85_4956_839f_e2e31e6ce190.Name = "object_b5eba493_7d85_4956_839f_e2e31e6ce190";
            this.object_b5eba493_7d85_4956_839f_e2e31e6ce190.StretchHorizontally = true;
            this.object_b5eba493_7d85_4956_839f_e2e31e6ce190.StretchVertically = true;
            // 
            // btnEditarPaciente
            // 
            this.btnEditarPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPaciente.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarPaciente.Image")));
            this.btnEditarPaciente.Location = new System.Drawing.Point(646, 485);
            this.btnEditarPaciente.Name = "btnEditarPaciente";
            this.btnEditarPaciente.Size = new System.Drawing.Size(292, 44);
            this.btnEditarPaciente.TabIndex = 2;
            this.btnEditarPaciente.Text = "     Editar Paciente Seleccionado";
            this.btnEditarPaciente.ThemeName = "ControlDefault";
            this.btnEditarPaciente.Click += new System.EventHandler(this.btnEditarPaciente_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnEditarPaciente.GetChildAt(0))).UseSmallImageList = true;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnEditarPaciente.GetChildAt(0))).Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnEditarPaciente.GetChildAt(0))).Text = "     Editar Paciente Seleccionado";
            ((Telerik.WinControls.Layouts.ImageAndTextLayoutPanel)(this.btnEditarPaciente.GetChildAt(0).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnEditarPaciente.GetChildAt(0).GetChildAt(1).GetChildAt(0))).StretchHorizontally = false;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnEditarPaciente.GetChildAt(0).GetChildAt(1).GetChildAt(0))).StretchVertically = false;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnEditarPaciente.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageLayout = System.Windows.Forms.ImageLayout.Center;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnEditarPaciente.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ScaleSize = new System.Drawing.Size(25, 25);
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnEditarPaciente.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnEditarPaciente.GetChildAt(0).GetChildAt(1).GetChildAt(0))).CustomFontSize = 15F;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnEditarPaciente.GetChildAt(0).GetChildAt(1).GetChildAt(0))).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.Auto;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnEditarPaciente.GetChildAt(0).GetChildAt(1).GetChildAt(0))).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnEditarPaciente.GetChildAt(0).GetChildAt(1).GetChildAt(0))).PositionOffset = new System.Drawing.SizeF(10F, 0F);
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnEditarPaciente.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ClickMode = Telerik.WinControls.ClickMode.Release;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.btnEditarPaciente.GetChildAt(0).GetChildAt(1).GetChildAt(1))).LineLimit = false;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.btnEditarPaciente.GetChildAt(0).GetChildAt(1).GetChildAt(1))).CustomFontSize = 15F;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.btnEditarPaciente.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radButton1
            // 
            this.radButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radButton1.Image = ((System.Drawing.Image)(resources.GetObject("radButton1.Image")));
            this.radButton1.Location = new System.Drawing.Point(647, 435);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(291, 44);
            this.radButton1.TabIndex = 3;
            this.radButton1.Text = "Nuevo Paciente";
            this.radButton1.ThemeName = "ControlDefault";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).UseSmallImageList = true;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).Text = "Nuevo Paciente";
            ((Telerik.WinControls.Layouts.ImageAndTextLayoutPanel)(this.radButton1.GetChildAt(0).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.radButton1.GetChildAt(0).GetChildAt(1).GetChildAt(0))).StretchHorizontally = false;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.radButton1.GetChildAt(0).GetChildAt(1).GetChildAt(0))).StretchVertically = false;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.radButton1.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageLayout = System.Windows.Forms.ImageLayout.Center;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.radButton1.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ScaleSize = new System.Drawing.Size(25, 25);
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.radButton1.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.radButton1.GetChildAt(0).GetChildAt(1).GetChildAt(0))).CustomFontSize = 15F;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.radButton1.GetChildAt(0).GetChildAt(1).GetChildAt(0))).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.Auto;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.radButton1.GetChildAt(0).GetChildAt(1).GetChildAt(0))).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.radButton1.GetChildAt(0).GetChildAt(1).GetChildAt(0))).PositionOffset = new System.Drawing.SizeF(10F, 0F);
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.radButton1.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ClickMode = Telerik.WinControls.ClickMode.Release;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radButton1.GetChildAt(0).GetChildAt(1).GetChildAt(1))).LineLimit = false;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radButton1.GetChildAt(0).GetChildAt(1).GetChildAt(1))).CustomFontSize = 15F;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radButton1.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPacientes.EnableKineticScrolling = true;
            this.dgvPacientes.Location = new System.Drawing.Point(0, 0);
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
            this.dgvPacientes.MasterTemplate.AllowRowReorder = true;
            this.dgvPacientes.MasterTemplate.AllowRowResize = false;
            this.dgvPacientes.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "NombreCompleto";
            gridViewTextBoxColumn1.HeaderText = "Nombre";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "NombreCompleto";
            gridViewTextBoxColumn1.Width = 216;
            gridViewTextBoxColumn2.FieldName = "Edad";
            gridViewTextBoxColumn2.HeaderText = "Edad";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "Edad";
            gridViewTextBoxColumn2.Width = 62;
            gridViewTextBoxColumn3.FieldName = "Email";
            gridViewTextBoxColumn3.HeaderText = "Email";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "Email";
            gridViewTextBoxColumn3.Width = 214;
            gridViewTextBoxColumn4.FieldName = "Telefono";
            gridViewTextBoxColumn4.HeaderText = "Telefono";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "Telefono";
            gridViewTextBoxColumn4.Width = 126;
            this.dgvPacientes.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.dgvPacientes.MasterTemplate.DataSource = this.pacienteVMBindingSource;
            this.dgvPacientes.MasterTemplate.HorizontalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysHide;
            this.dgvPacientes.MasterTemplate.SearchRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            this.dgvPacientes.MasterTemplate.VerticalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysHide;
            this.dgvPacientes.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.ReadOnly = true;
            this.dgvPacientes.ShowGroupPanel = false;
            this.dgvPacientes.ShowGroupPanelScrollbars = false;
            this.dgvPacientes.Size = new System.Drawing.Size(640, 532);
            this.dgvPacientes.TabIndex = 23;
            this.dgvPacientes.Text = "radGridView1";
            this.dgvPacientes.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.dgvPacientes_CellClick);
            // 
            // pacienteVMBindingSource
            // 
            this.pacienteVMBindingSource.DataSource = typeof(Consultorio.ViewModels.PacienteVM);
            // 
            // ListadoPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(950, 532);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.btnEditarPaciente);
            this.Controls.Add(this.panelPacienteSeleccionado);
            this.Controls.Add(this.panelListaPacientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListadoPacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Pacientes";
            this.Load += new System.EventHandler(this.Pacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelListaPacientes)).EndInit();
            this.panelListaPacientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelPacienteSeleccionado)).EndInit();
            this.panelPacienteSeleccionado.ResumeLayout(false);
            this.panelPacienteSeleccionado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblGrupoSanguineo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTrasplantado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDonante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDireccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDiagnostico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiagnostico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHistoriaClinica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEdadSexo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Afecciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoPaciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditarPaciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteVMBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel panelListaPacientes;
        private Telerik.WinControls.UI.RadPanel panelPacienteSeleccionado;
        private System.Windows.Forms.PictureBox pictureBoxFotoPaciente;
        private Telerik.WinControls.UI.RadLabel Afecciones;
        private Telerik.WinControls.RootRadElement object_b5eba493_7d85_4956_839f_e2e31e6ce190;
        private Telerik.WinControls.UI.RadButton btnEditarPaciente;
        private System.Windows.Forms.Label lblNombreApellido;
        private Telerik.WinControls.UI.RadLabel lblEdadSexo;
        private Telerik.WinControls.UI.RadTextBox txtDiagnostico;
        private Telerik.WinControls.UI.RadTextBox txtHistoriaClinica;
        private Telerik.WinControls.UI.RadLabel lblDiagnostico;
        private Telerik.WinControls.UI.RadLabel lblTelefono;
        private Telerik.WinControls.UI.RadLabel lblDireccion;
        private System.Windows.Forms.BindingSource pacienteVMBindingSource;
        private Telerik.WinControls.UI.RadLabel lblTrasplantado;
        private Telerik.WinControls.UI.RadLabel lblDonante;
        private Telerik.WinControls.UI.RadLabel lblGrupoSanguineo;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadGridView dgvPacientes;
    }
}
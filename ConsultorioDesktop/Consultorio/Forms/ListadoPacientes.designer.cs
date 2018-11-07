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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoPacientes));
            this.panelListaPacientes = new Telerik.WinControls.UI.RadPanel();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
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
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.pacienteIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCompletoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idHistoriaClinicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacienteVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelListaPacientes)).BeginInit();
            this.panelListaPacientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
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
            // dgvPacientes
            // 
            this.dgvPacientes.AllowUserToAddRows = false;
            this.dgvPacientes.AllowUserToDeleteRows = false;
            this.dgvPacientes.AllowUserToResizeRows = false;
            this.dgvPacientes.AutoGenerateColumns = false;
            this.dgvPacientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvPacientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPacientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvPacientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPacientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pacienteIdDataGridViewTextBoxColumn,
            this.nombreCompletoDataGridViewTextBoxColumn,
            this.edadDataGridViewTextBoxColumn,
            this.Sexo,
            this.nroDocumentoDataGridViewTextBoxColumn,
            this.Email,
            this.telefonoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.idHistoriaClinicaDataGridViewTextBoxColumn});
            this.dgvPacientes.DataSource = this.pacienteVMBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPacientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPacientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPacientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.dgvPacientes.Location = new System.Drawing.Point(0, 0);
            this.dgvPacientes.MultiSelect = false;
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.ReadOnly = true;
            this.dgvPacientes.RowHeadersVisible = false;
            this.dgvPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPacientes.Size = new System.Drawing.Size(640, 532);
            this.dgvPacientes.TabIndex = 12;
            this.dgvPacientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPacientes_CellClick);
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
            this.panelPacienteSeleccionado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPacienteSeleccionado.Location = new System.Drawing.Point(640, 133);
            this.panelPacienteSeleccionado.Name = "panelPacienteSeleccionado";
            this.panelPacienteSeleccionado.Size = new System.Drawing.Size(310, 399);
            this.panelPacienteSeleccionado.TabIndex = 1;
            // 
            // lblGrupoSanguineo
            // 
            this.lblGrupoSanguineo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGrupoSanguineo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupoSanguineo.Location = new System.Drawing.Point(116, 91);
            this.lblGrupoSanguineo.Name = "lblGrupoSanguineo";
            this.lblGrupoSanguineo.Size = new System.Drawing.Size(112, 18);
            this.lblGrupoSanguineo.TabIndex = 13;
            this.lblGrupoSanguineo.Text = "Grupo Sanguineo";
            // 
            // lblTrasplantado
            // 
            this.lblTrasplantado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTrasplantado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrasplantado.Location = new System.Drawing.Point(16, 119);
            this.lblTrasplantado.Name = "lblTrasplantado";
            this.lblTrasplantado.Size = new System.Drawing.Size(85, 18);
            this.lblTrasplantado.TabIndex = 12;
            this.lblTrasplantado.Text = "Trasplantado";
            // 
            // lblDonante
            // 
            this.lblDonante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonante.Location = new System.Drawing.Point(30, 95);
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
            this.lblDiagnostico.Location = new System.Drawing.Point(7, 292);
            this.lblDiagnostico.Name = "lblDiagnostico";
            this.lblDiagnostico.Size = new System.Drawing.Size(77, 18);
            this.lblDiagnostico.TabIndex = 10;
            this.lblDiagnostico.Text = "Diagnóstico";
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.AutoSize = false;
            this.txtDiagnostico.Enabled = false;
            this.txtDiagnostico.Location = new System.Drawing.Point(7, 314);
            this.txtDiagnostico.Multiline = true;
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(291, 73);
            this.txtDiagnostico.TabIndex = 9;
            // 
            // txtHistoriaClinica
            // 
            this.txtHistoriaClinica.AutoSize = false;
            this.txtHistoriaClinica.Enabled = false;
            this.txtHistoriaClinica.Location = new System.Drawing.Point(7, 169);
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
            this.Afecciones.Location = new System.Drawing.Point(7, 145);
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
            this.btnEditarPaciente.Location = new System.Drawing.Point(646, 53);
            this.btnEditarPaciente.Name = "btnEditarPaciente";
            this.btnEditarPaciente.Size = new System.Drawing.Size(303, 44);
            this.btnEditarPaciente.TabIndex = 2;
            this.btnEditarPaciente.Text = "Editar Paciente Seleccionado";
            this.btnEditarPaciente.ThemeName = "ControlDefault";
            this.btnEditarPaciente.Click += new System.EventHandler(this.btnEditarPaciente_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnEditarPaciente.GetChildAt(0))).UseSmallImageList = true;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnEditarPaciente.GetChildAt(0))).Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnEditarPaciente.GetChildAt(0))).Text = "Editar Paciente Seleccionado";
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
            // Sexo
            // 
            this.Sexo.DataPropertyName = "Sexo";
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            this.Sexo.Width = 70;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 135;
            // 
            // radButton1
            // 
            this.radButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radButton1.Image = ((System.Drawing.Image)(resources.GetObject("radButton1.Image")));
            this.radButton1.Location = new System.Drawing.Point(647, 3);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(303, 44);
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
            // pacienteIdDataGridViewTextBoxColumn
            // 
            this.pacienteIdDataGridViewTextBoxColumn.DataPropertyName = "PacienteId";
            this.pacienteIdDataGridViewTextBoxColumn.HeaderText = "PacienteId";
            this.pacienteIdDataGridViewTextBoxColumn.Name = "pacienteIdDataGridViewTextBoxColumn";
            this.pacienteIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.pacienteIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreCompletoDataGridViewTextBoxColumn
            // 
            this.nombreCompletoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreCompletoDataGridViewTextBoxColumn.DataPropertyName = "NombreCompleto";
            this.nombreCompletoDataGridViewTextBoxColumn.HeaderText = "Paciente";
            this.nombreCompletoDataGridViewTextBoxColumn.Name = "nombreCompletoDataGridViewTextBoxColumn";
            this.nombreCompletoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // edadDataGridViewTextBoxColumn
            // 
            this.edadDataGridViewTextBoxColumn.DataPropertyName = "Edad";
            this.edadDataGridViewTextBoxColumn.HeaderText = "Edad";
            this.edadDataGridViewTextBoxColumn.Name = "edadDataGridViewTextBoxColumn";
            this.edadDataGridViewTextBoxColumn.ReadOnly = true;
            this.edadDataGridViewTextBoxColumn.Width = 50;
            // 
            // nroDocumentoDataGridViewTextBoxColumn
            // 
            this.nroDocumentoDataGridViewTextBoxColumn.DataPropertyName = "NroDocumento";
            this.nroDocumentoDataGridViewTextBoxColumn.HeaderText = "Documento";
            this.nroDocumentoDataGridViewTextBoxColumn.Name = "nroDocumentoDataGridViewTextBoxColumn";
            this.nroDocumentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nroDocumentoDataGridViewTextBoxColumn.Width = 80;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Dirección";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            this.direccionDataGridViewTextBoxColumn.Visible = false;
            // 
            // idHistoriaClinicaDataGridViewTextBoxColumn
            // 
            this.idHistoriaClinicaDataGridViewTextBoxColumn.DataPropertyName = "IdHistoriaClinica";
            this.idHistoriaClinicaDataGridViewTextBoxColumn.HeaderText = "IdHistoriaClinica";
            this.idHistoriaClinicaDataGridViewTextBoxColumn.Name = "idHistoriaClinicaDataGridViewTextBoxColumn";
            this.idHistoriaClinicaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idHistoriaClinicaDataGridViewTextBoxColumn.Visible = false;
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ListadoPacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pacientes";
            this.Load += new System.EventHandler(this.Pacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelListaPacientes)).EndInit();
            this.panelListaPacientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.BindingSource pacienteVMBindingSource;
        private Telerik.WinControls.UI.RadLabel lblTrasplantado;
        private Telerik.WinControls.UI.RadLabel lblDonante;
        private Telerik.WinControls.UI.RadLabel lblGrupoSanguineo;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacienteIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCompletoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idHistoriaClinicaDataGridViewTextBoxColumn;
        private Telerik.WinControls.UI.RadButton radButton1;
    }
}
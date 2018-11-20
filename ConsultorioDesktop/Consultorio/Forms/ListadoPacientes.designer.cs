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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoPacientes));
            this.panelListaPacientes = new Telerik.WinControls.UI.RadPanel();
            this.dgvPacientes = new Telerik.WinControls.UI.RadGridView();
            this.pacienteVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelPacienteSeleccionado = new Telerik.WinControls.UI.RadPanel();
            this.lblGrupoSanguineo = new Telerik.WinControls.UI.RadLabel();
            this.lblTrasplantado = new Telerik.WinControls.UI.RadLabel();
            this.lblDonante = new Telerik.WinControls.UI.RadLabel();
            this.lblTelefono = new Telerik.WinControls.UI.RadLabel();
            this.lblDireccion = new Telerik.WinControls.UI.RadLabel();
            this.dgvHistoriasClinicas = new System.Windows.Forms.DataGridView();
            this.idHistoriaClinicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaAtencionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTurnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historiaClinicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblEdadSexo = new Telerik.WinControls.UI.RadLabel();
            this.lblNombreApellido = new System.Windows.Forms.Label();
            this.lblDetallesConsulta = new Telerik.WinControls.UI.RadLabel();
            this.pictureBoxFotoPaciente = new System.Windows.Forms.PictureBox();
            this.object_b5eba493_7d85_4956_839f_e2e31e6ce190 = new Telerik.WinControls.RootRadElement();
            this.btnEditarPaciente = new Telerik.WinControls.UI.RadButton();
            this.btnNuevoPaciente = new Telerik.WinControls.UI.RadButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelListaPacientes)).BeginInit();
            this.panelListaPacientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteVMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelPacienteSeleccionado)).BeginInit();
            this.panelPacienteSeleccionado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblGrupoSanguineo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTrasplantado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDonante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDireccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoriasClinicas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historiaClinicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEdadSexo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDetallesConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoPaciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditarPaciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevoPaciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelListaPacientes
            // 
            this.panelListaPacientes.BackColor = System.Drawing.Color.Snow;
            this.panelListaPacientes.Controls.Add(this.dgvPacientes);
            this.panelListaPacientes.Location = new System.Drawing.Point(0, 0);
            this.panelListaPacientes.Name = "panelListaPacientes";
            this.panelListaPacientes.Size = new System.Drawing.Size(640, 515);
            this.panelListaPacientes.TabIndex = 0;
            this.panelListaPacientes.Text = "panelListaPacientes";
            this.panelListaPacientes.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
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
            gridViewTextBoxColumn1.Width = 277;
            gridViewTextBoxColumn2.FieldName = "Edad";
            gridViewTextBoxColumn2.HeaderText = "Edad";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "Edad";
            gridViewTextBoxColumn2.Width = 74;
            gridViewTextBoxColumn3.FieldName = "Email";
            gridViewTextBoxColumn3.HeaderText = "Email";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "Email";
            gridViewTextBoxColumn3.Width = 270;
            this.dgvPacientes.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3});
            this.dgvPacientes.MasterTemplate.DataSource = this.pacienteVMBindingSource;
            this.dgvPacientes.MasterTemplate.HorizontalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysHide;
            this.dgvPacientes.MasterTemplate.SearchRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            this.dgvPacientes.MasterTemplate.VerticalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysHide;
            this.dgvPacientes.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.ReadOnly = true;
            this.dgvPacientes.ShowGroupPanel = false;
            this.dgvPacientes.ShowGroupPanelScrollbars = false;
            this.dgvPacientes.Size = new System.Drawing.Size(640, 515);
            this.dgvPacientes.TabIndex = 23;
            this.dgvPacientes.Text = "radGridView1";
            this.dgvPacientes.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.dgvPacientes_CellClick);
            // 
            // pacienteVMBindingSource
            // 
            this.pacienteVMBindingSource.DataSource = typeof(Consultorio.ViewModels.PacienteVM);
            // 
            // panelPacienteSeleccionado
            // 
            this.panelPacienteSeleccionado.BackColor = System.Drawing.Color.Snow;
            this.panelPacienteSeleccionado.Controls.Add(this.lblGrupoSanguineo);
            this.panelPacienteSeleccionado.Controls.Add(this.dgvHistoriasClinicas);
            this.panelPacienteSeleccionado.Controls.Add(this.lblTrasplantado);
            this.panelPacienteSeleccionado.Controls.Add(this.lblDonante);
            this.panelPacienteSeleccionado.Controls.Add(this.lblTelefono);
            this.panelPacienteSeleccionado.Controls.Add(this.lblDireccion);
            this.panelPacienteSeleccionado.Controls.Add(this.lblEdadSexo);
            this.panelPacienteSeleccionado.Controls.Add(this.lblNombreApellido);
            this.panelPacienteSeleccionado.Controls.Add(this.lblDetallesConsulta);
            this.panelPacienteSeleccionado.Controls.Add(this.pictureBoxFotoPaciente);
            this.panelPacienteSeleccionado.Location = new System.Drawing.Point(640, 0);
            this.panelPacienteSeleccionado.Name = "panelPacienteSeleccionado";
            this.panelPacienteSeleccionado.Size = new System.Drawing.Size(536, 578);
            this.panelPacienteSeleccionado.TabIndex = 1;
            // 
            // lblGrupoSanguineo
            // 
            this.lblGrupoSanguineo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupoSanguineo.Location = new System.Drawing.Point(7, 95);
            this.lblGrupoSanguineo.Name = "lblGrupoSanguineo";
            this.lblGrupoSanguineo.Size = new System.Drawing.Size(112, 18);
            this.lblGrupoSanguineo.TabIndex = 13;
            this.lblGrupoSanguineo.Text = "Grupo Sanguineo";
            // 
            // lblTrasplantado
            // 
            this.lblTrasplantado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrasplantado.Location = new System.Drawing.Point(7, 143);
            this.lblTrasplantado.Name = "lblTrasplantado";
            this.lblTrasplantado.Size = new System.Drawing.Size(85, 18);
            this.lblTrasplantado.TabIndex = 12;
            this.lblTrasplantado.Text = "Trasplantado";
            // 
            // lblDonante
            // 
            this.lblDonante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonante.Location = new System.Drawing.Point(7, 119);
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
            // dgvHistoriasClinicas
            // 
            this.dgvHistoriasClinicas.AllowUserToAddRows = false;
            this.dgvHistoriasClinicas.AllowUserToDeleteRows = false;
            this.dgvHistoriasClinicas.AutoGenerateColumns = false;
            this.dgvHistoriasClinicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoriasClinicas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idHistoriaClinicaDataGridViewTextBoxColumn,
            this.fechaAtencionDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.idPacienteDataGridViewTextBoxColumn,
            this.idTurnoDataGridViewTextBoxColumn});
            this.dgvHistoriasClinicas.DataSource = this.historiaClinicaBindingSource;
            this.dgvHistoriasClinicas.Location = new System.Drawing.Point(7, 198);
            this.dgvHistoriasClinicas.Name = "dgvHistoriasClinicas";
            this.dgvHistoriasClinicas.ReadOnly = true;
            this.dgvHistoriasClinicas.RowHeadersVisible = false;
            this.dgvHistoriasClinicas.Size = new System.Drawing.Size(526, 377);
            this.dgvHistoriasClinicas.TabIndex = 1;
            // 
            // idHistoriaClinicaDataGridViewTextBoxColumn
            // 
            this.idHistoriaClinicaDataGridViewTextBoxColumn.DataPropertyName = "IdHistoriaClinica";
            this.idHistoriaClinicaDataGridViewTextBoxColumn.HeaderText = "IdHistoriaClinica";
            this.idHistoriaClinicaDataGridViewTextBoxColumn.Name = "idHistoriaClinicaDataGridViewTextBoxColumn";
            this.idHistoriaClinicaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idHistoriaClinicaDataGridViewTextBoxColumn.Visible = false;
            // 
            // fechaAtencionDataGridViewTextBoxColumn
            // 
            this.fechaAtencionDataGridViewTextBoxColumn.DataPropertyName = "FechaAtencion";
            this.fechaAtencionDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaAtencionDataGridViewTextBoxColumn.Name = "fechaAtencionDataGridViewTextBoxColumn";
            this.fechaAtencionDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaAtencionDataGridViewTextBoxColumn.Width = 80;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idPacienteDataGridViewTextBoxColumn
            // 
            this.idPacienteDataGridViewTextBoxColumn.DataPropertyName = "IdPaciente";
            this.idPacienteDataGridViewTextBoxColumn.HeaderText = "IdPaciente";
            this.idPacienteDataGridViewTextBoxColumn.Name = "idPacienteDataGridViewTextBoxColumn";
            this.idPacienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPacienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // idTurnoDataGridViewTextBoxColumn
            // 
            this.idTurnoDataGridViewTextBoxColumn.DataPropertyName = "IdTurno";
            this.idTurnoDataGridViewTextBoxColumn.HeaderText = "IdTurno";
            this.idTurnoDataGridViewTextBoxColumn.Name = "idTurnoDataGridViewTextBoxColumn";
            this.idTurnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTurnoDataGridViewTextBoxColumn.Visible = false;
            // 
            // historiaClinicaBindingSource
            // 
            this.historiaClinicaBindingSource.DataSource = typeof(Consultorio.Modelo.HistoriaClinica);
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
            // lblDetallesConsulta
            // 
            this.lblDetallesConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetallesConsulta.Location = new System.Drawing.Point(6, 174);
            this.lblDetallesConsulta.Name = "lblDetallesConsulta";
            this.lblDetallesConsulta.Size = new System.Drawing.Size(113, 18);
            this.lblDetallesConsulta.TabIndex = 4;
            this.lblDetallesConsulta.Text = "Historias Clinicas:";
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
            this.btnEditarPaciente.Location = new System.Drawing.Point(331, 534);
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
            // btnNuevoPaciente
            // 
            this.btnNuevoPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoPaciente.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoPaciente.Image")));
            this.btnNuevoPaciente.Location = new System.Drawing.Point(12, 534);
            this.btnNuevoPaciente.Name = "btnNuevoPaciente";
            this.btnNuevoPaciente.Size = new System.Drawing.Size(291, 44);
            this.btnNuevoPaciente.TabIndex = 3;
            this.btnNuevoPaciente.Text = "Nuevo Paciente";
            this.btnNuevoPaciente.ThemeName = "ControlDefault";
            this.btnNuevoPaciente.Click += new System.EventHandler(this.btnNuevoPaciente_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnNuevoPaciente.GetChildAt(0))).UseSmallImageList = true;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnNuevoPaciente.GetChildAt(0))).Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnNuevoPaciente.GetChildAt(0))).Text = "Nuevo Paciente";
            ((Telerik.WinControls.Layouts.ImageAndTextLayoutPanel)(this.btnNuevoPaciente.GetChildAt(0).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnNuevoPaciente.GetChildAt(0).GetChildAt(1).GetChildAt(0))).StretchHorizontally = false;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnNuevoPaciente.GetChildAt(0).GetChildAt(1).GetChildAt(0))).StretchVertically = false;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnNuevoPaciente.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageLayout = System.Windows.Forms.ImageLayout.Center;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnNuevoPaciente.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ScaleSize = new System.Drawing.Size(25, 25);
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnNuevoPaciente.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnNuevoPaciente.GetChildAt(0).GetChildAt(1).GetChildAt(0))).CustomFontSize = 15F;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnNuevoPaciente.GetChildAt(0).GetChildAt(1).GetChildAt(0))).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.Auto;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnNuevoPaciente.GetChildAt(0).GetChildAt(1).GetChildAt(0))).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnNuevoPaciente.GetChildAt(0).GetChildAt(1).GetChildAt(0))).PositionOffset = new System.Drawing.SizeF(10F, 0F);
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnNuevoPaciente.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ClickMode = Telerik.WinControls.ClickMode.Release;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.btnNuevoPaciente.GetChildAt(0).GetChildAt(1).GetChildAt(1))).LineLimit = false;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.btnNuevoPaciente.GetChildAt(0).GetChildAt(1).GetChildAt(1))).CustomFontSize = 15F;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.btnNuevoPaciente.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ListadoPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1188, 590);
            this.Controls.Add(this.btnNuevoPaciente);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteVMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelPacienteSeleccionado)).EndInit();
            this.panelPacienteSeleccionado.ResumeLayout(false);
            this.panelPacienteSeleccionado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblGrupoSanguineo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTrasplantado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDonante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDireccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoriasClinicas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historiaClinicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEdadSexo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDetallesConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoPaciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditarPaciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevoPaciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel panelListaPacientes;
        private Telerik.WinControls.UI.RadPanel panelPacienteSeleccionado;
        private System.Windows.Forms.PictureBox pictureBoxFotoPaciente;
        private Telerik.WinControls.UI.RadLabel lblDetallesConsulta;
        private Telerik.WinControls.RootRadElement object_b5eba493_7d85_4956_839f_e2e31e6ce190;
        private Telerik.WinControls.UI.RadButton btnEditarPaciente;
        private System.Windows.Forms.Label lblNombreApellido;
        private Telerik.WinControls.UI.RadLabel lblEdadSexo;
        private Telerik.WinControls.UI.RadLabel lblTelefono;
        private Telerik.WinControls.UI.RadLabel lblDireccion;
        private System.Windows.Forms.BindingSource pacienteVMBindingSource;
        private Telerik.WinControls.UI.RadLabel lblTrasplantado;
        private Telerik.WinControls.UI.RadLabel lblDonante;
        private Telerik.WinControls.UI.RadLabel lblGrupoSanguineo;
        private Telerik.WinControls.UI.RadButton btnNuevoPaciente;
        private Telerik.WinControls.UI.RadGridView dgvPacientes;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource historiaClinicaBindingSource;
        private System.Windows.Forms.DataGridView dgvHistoriasClinicas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idHistoriaClinicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAtencionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTurnoDataGridViewTextBoxColumn;
    }
}
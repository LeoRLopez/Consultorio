namespace Consultorio
{
    partial class ListadoMedicos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelListaPacientes = new Telerik.WinControls.UI.RadPanel();
            this.dgvMedicos = new System.Windows.Forms.DataGridView();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.dgvPacientesMedico = new System.Windows.Forms.DataGridView();
            this.dataFilterDescriptorItem1 = new Telerik.WinControls.UI.DataFilterDescriptorItem();
            this.dataFilterDescriptorItem2 = new Telerik.WinControls.UI.DataFilterDescriptorItem();
            this.dataFilterDescriptorItem3 = new Telerik.WinControls.UI.DataFilterDescriptorItem();
            this.dataFilterDescriptorItem4 = new Telerik.WinControls.UI.DataFilterDescriptorItem();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrarEspecialidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacienteIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCompletoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idHistoriaClinicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacienteVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCompletoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lunesHorarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.martesHorarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miercolesHorarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.juevesHorarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viernesHorarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sabadoHorarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domingoHorarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicoVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelListaPacientes)).BeginInit();
            this.panelListaPacientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientesMedico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteVMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoVMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelListaPacientes
            // 
            this.panelListaPacientes.BackColor = System.Drawing.Color.Snow;
            this.panelListaPacientes.Controls.Add(this.dgvMedicos);
            this.panelListaPacientes.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelListaPacientes.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelListaPacientes.Location = new System.Drawing.Point(0, 0);
            this.panelListaPacientes.Name = "panelListaPacientes";
            this.panelListaPacientes.Size = new System.Drawing.Size(468, 460);
            this.panelListaPacientes.TabIndex = 1;
            this.panelListaPacientes.Text = "panelListaPacientes";
            this.panelListaPacientes.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvMedicos
            // 
            this.dgvMedicos.AllowUserToAddRows = false;
            this.dgvMedicos.AllowUserToDeleteRows = false;
            this.dgvMedicos.AllowUserToResizeRows = false;
            this.dgvMedicos.AutoGenerateColumns = false;
            this.dgvMedicos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(252)))), ((int)(((byte)(249)))));
            this.dgvMedicos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMedicos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvMedicos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medicoIdDataGridViewTextBoxColumn,
            this.nombreCompletoDataGridViewTextBoxColumn,
            this.NombrarEspecialidades,
            this.lunesHorarioDataGridViewTextBoxColumn,
            this.martesHorarioDataGridViewTextBoxColumn,
            this.miercolesHorarioDataGridViewTextBoxColumn,
            this.juevesHorarioDataGridViewTextBoxColumn,
            this.viernesHorarioDataGridViewTextBoxColumn,
            this.sabadoHorarioDataGridViewTextBoxColumn,
            this.domingoHorarioDataGridViewTextBoxColumn});
            this.dgvMedicos.DataSource = this.medicoVMBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMedicos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMedicos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.dgvMedicos.Location = new System.Drawing.Point(0, 29);
            this.dgvMedicos.MultiSelect = false;
            this.dgvMedicos.Name = "dgvMedicos";
            this.dgvMedicos.ReadOnly = true;
            this.dgvMedicos.RowHeadersVisible = false;
            this.dgvMedicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicos.Size = new System.Drawing.Size(468, 431);
            this.dgvMedicos.TabIndex = 13;
            this.dgvMedicos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicos_CellClick);
            // 
            // radPanel1
            // 
            this.radPanel1.BackColor = System.Drawing.Color.Snow;
            this.radPanel1.Controls.Add(this.label1);
            this.radPanel1.Controls.Add(this.dgvPacientesMedico);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel1.Location = new System.Drawing.Point(468, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(482, 460);
            this.radPanel1.TabIndex = 2;
            this.radPanel1.Text = "radPanel1";
            this.radPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvPacientesMedico
            // 
            this.dgvPacientesMedico.AllowUserToAddRows = false;
            this.dgvPacientesMedico.AllowUserToDeleteRows = false;
            this.dgvPacientesMedico.AutoGenerateColumns = false;
            this.dgvPacientesMedico.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(252)))), ((int)(((byte)(249)))));
            this.dgvPacientesMedico.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPacientesMedico.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvPacientesMedico.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPacientesMedico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPacientesMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientesMedico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pacienteIdDataGridViewTextBoxColumn,
            this.nombreCompletoDataGridViewTextBoxColumn1,
            this.nroDocumentoDataGridViewTextBoxColumn,
            this.Email,
            this.telefonoDataGridViewTextBoxColumn,
            this.idHistoriaClinicaDataGridViewTextBoxColumn,
            this.Sexo,
            this.edadDataGridViewTextBoxColumn});
            this.dgvPacientesMedico.DataSource = this.pacienteVMBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPacientesMedico.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPacientesMedico.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.dgvPacientesMedico.Location = new System.Drawing.Point(6, 29);
            this.dgvPacientesMedico.MultiSelect = false;
            this.dgvPacientesMedico.Name = "dgvPacientesMedico";
            this.dgvPacientesMedico.ReadOnly = true;
            this.dgvPacientesMedico.RowHeadersVisible = false;
            this.dgvPacientesMedico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPacientesMedico.Size = new System.Drawing.Size(476, 431);
            this.dgvPacientesMedico.TabIndex = 13;
            // 
            // dataFilterDescriptorItem1
            // 
            this.dataFilterDescriptorItem1.DescriptorName = "MatriculaMedico";
            this.dataFilterDescriptorItem1.DescriptorType = typeof(int);
            this.dataFilterDescriptorItem1.IsAutoGenerated = true;
            this.dataFilterDescriptorItem1.Name = "dataFilterDescriptorItem1";
            // 
            // dataFilterDescriptorItem2
            // 
            this.dataFilterDescriptorItem2.DescriptorName = "Apellido";
            this.dataFilterDescriptorItem2.DescriptorType = typeof(string);
            this.dataFilterDescriptorItem2.IsAutoGenerated = true;
            this.dataFilterDescriptorItem2.Name = "dataFilterDescriptorItem2";
            // 
            // dataFilterDescriptorItem3
            // 
            this.dataFilterDescriptorItem3.DescriptorName = "Nombre";
            this.dataFilterDescriptorItem3.DescriptorType = typeof(string);
            this.dataFilterDescriptorItem3.IsAutoGenerated = true;
            this.dataFilterDescriptorItem3.Name = "dataFilterDescriptorItem3";
            // 
            // dataFilterDescriptorItem4
            // 
            this.dataFilterDescriptorItem4.DescriptorName = "Especialidad";
            this.dataFilterDescriptorItem4.DescriptorType = typeof(string);
            this.dataFilterDescriptorItem4.IsAutoGenerated = true;
            this.dataFilterDescriptorItem4.Name = "dataFilterDescriptorItem4";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 120;
            // 
            // Sexo
            // 
            this.Sexo.DataPropertyName = "Sexo";
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            this.Sexo.Visible = false;
            // 
            // NombrarEspecialidades
            // 
            this.NombrarEspecialidades.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombrarEspecialidades.DataPropertyName = "NombrarEspecialidades";
            this.NombrarEspecialidades.HeaderText = "Especialidades";
            this.NombrarEspecialidades.Name = "NombrarEspecialidades";
            this.NombrarEspecialidades.ReadOnly = true;
            // 
            // pacienteIdDataGridViewTextBoxColumn
            // 
            this.pacienteIdDataGridViewTextBoxColumn.DataPropertyName = "PacienteId";
            this.pacienteIdDataGridViewTextBoxColumn.HeaderText = "PacienteId";
            this.pacienteIdDataGridViewTextBoxColumn.Name = "pacienteIdDataGridViewTextBoxColumn";
            this.pacienteIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.pacienteIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreCompletoDataGridViewTextBoxColumn1
            // 
            this.nombreCompletoDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreCompletoDataGridViewTextBoxColumn1.DataPropertyName = "NombreCompleto";
            this.nombreCompletoDataGridViewTextBoxColumn1.HeaderText = "Paciente";
            this.nombreCompletoDataGridViewTextBoxColumn1.Name = "nombreCompletoDataGridViewTextBoxColumn1";
            this.nombreCompletoDataGridViewTextBoxColumn1.ReadOnly = true;
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
            // idHistoriaClinicaDataGridViewTextBoxColumn
            // 
            this.idHistoriaClinicaDataGridViewTextBoxColumn.DataPropertyName = "IdHistoriaClinica";
            this.idHistoriaClinicaDataGridViewTextBoxColumn.HeaderText = "IdHistoriaClinica";
            this.idHistoriaClinicaDataGridViewTextBoxColumn.Name = "idHistoriaClinicaDataGridViewTextBoxColumn";
            this.idHistoriaClinicaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idHistoriaClinicaDataGridViewTextBoxColumn.Visible = false;
            // 
            // edadDataGridViewTextBoxColumn
            // 
            this.edadDataGridViewTextBoxColumn.DataPropertyName = "Edad";
            this.edadDataGridViewTextBoxColumn.HeaderText = "Edad";
            this.edadDataGridViewTextBoxColumn.Name = "edadDataGridViewTextBoxColumn";
            this.edadDataGridViewTextBoxColumn.ReadOnly = true;
            this.edadDataGridViewTextBoxColumn.Visible = false;
            // 
            // pacienteVMBindingSource
            // 
            this.pacienteVMBindingSource.DataSource = typeof(Consultorio.ViewModels.PacienteVM);
            // 
            // medicoIdDataGridViewTextBoxColumn
            // 
            this.medicoIdDataGridViewTextBoxColumn.DataPropertyName = "MedicoId";
            this.medicoIdDataGridViewTextBoxColumn.HeaderText = "MedicoId";
            this.medicoIdDataGridViewTextBoxColumn.Name = "medicoIdDataGridViewTextBoxColumn";
            this.medicoIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.medicoIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreCompletoDataGridViewTextBoxColumn
            // 
            this.nombreCompletoDataGridViewTextBoxColumn.DataPropertyName = "NombreCompleto";
            this.nombreCompletoDataGridViewTextBoxColumn.HeaderText = "Medico";
            this.nombreCompletoDataGridViewTextBoxColumn.Name = "nombreCompletoDataGridViewTextBoxColumn";
            this.nombreCompletoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreCompletoDataGridViewTextBoxColumn.Width = 150;
            // 
            // lunesHorarioDataGridViewTextBoxColumn
            // 
            this.lunesHorarioDataGridViewTextBoxColumn.DataPropertyName = "LunesHorario";
            this.lunesHorarioDataGridViewTextBoxColumn.HeaderText = "Lunes";
            this.lunesHorarioDataGridViewTextBoxColumn.Name = "lunesHorarioDataGridViewTextBoxColumn";
            this.lunesHorarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.lunesHorarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // martesHorarioDataGridViewTextBoxColumn
            // 
            this.martesHorarioDataGridViewTextBoxColumn.DataPropertyName = "MartesHorario";
            this.martesHorarioDataGridViewTextBoxColumn.HeaderText = "Martes";
            this.martesHorarioDataGridViewTextBoxColumn.Name = "martesHorarioDataGridViewTextBoxColumn";
            this.martesHorarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.martesHorarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // miercolesHorarioDataGridViewTextBoxColumn
            // 
            this.miercolesHorarioDataGridViewTextBoxColumn.DataPropertyName = "MiercolesHorario";
            this.miercolesHorarioDataGridViewTextBoxColumn.HeaderText = "Miercoles";
            this.miercolesHorarioDataGridViewTextBoxColumn.Name = "miercolesHorarioDataGridViewTextBoxColumn";
            this.miercolesHorarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.miercolesHorarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // juevesHorarioDataGridViewTextBoxColumn
            // 
            this.juevesHorarioDataGridViewTextBoxColumn.DataPropertyName = "JuevesHorario";
            this.juevesHorarioDataGridViewTextBoxColumn.HeaderText = "Jueves";
            this.juevesHorarioDataGridViewTextBoxColumn.Name = "juevesHorarioDataGridViewTextBoxColumn";
            this.juevesHorarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.juevesHorarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // viernesHorarioDataGridViewTextBoxColumn
            // 
            this.viernesHorarioDataGridViewTextBoxColumn.DataPropertyName = "ViernesHorario";
            this.viernesHorarioDataGridViewTextBoxColumn.HeaderText = "Viernes";
            this.viernesHorarioDataGridViewTextBoxColumn.Name = "viernesHorarioDataGridViewTextBoxColumn";
            this.viernesHorarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.viernesHorarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // sabadoHorarioDataGridViewTextBoxColumn
            // 
            this.sabadoHorarioDataGridViewTextBoxColumn.DataPropertyName = "SabadoHorario";
            this.sabadoHorarioDataGridViewTextBoxColumn.HeaderText = "Sabado";
            this.sabadoHorarioDataGridViewTextBoxColumn.Name = "sabadoHorarioDataGridViewTextBoxColumn";
            this.sabadoHorarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.sabadoHorarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // domingoHorarioDataGridViewTextBoxColumn
            // 
            this.domingoHorarioDataGridViewTextBoxColumn.DataPropertyName = "DomingoHorario";
            this.domingoHorarioDataGridViewTextBoxColumn.HeaderText = "Domingo";
            this.domingoHorarioDataGridViewTextBoxColumn.Name = "domingoHorarioDataGridViewTextBoxColumn";
            this.domingoHorarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.domingoHorarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // medicoVMBindingSource
            // 
            this.medicoVMBindingSource.DataSource = typeof(Consultorio.ViewModels.MedicoVM);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Listado de Pacientes Atendidos";
            // 
            // ListadoMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 460);
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.panelListaPacientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListadoMedicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Medico";
            this.Load += new System.EventHandler(this.Medicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelListaPacientes)).EndInit();
            this.panelListaPacientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientesMedico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteVMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoVMBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel panelListaPacientes;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.DataFilterDescriptorItem dataFilterDescriptorItem1;
        private Telerik.WinControls.UI.DataFilterDescriptorItem dataFilterDescriptorItem2;
        private Telerik.WinControls.UI.DataFilterDescriptorItem dataFilterDescriptorItem3;
        private Telerik.WinControls.UI.DataFilterDescriptorItem dataFilterDescriptorItem4;
        private System.Windows.Forms.DataGridView dgvMedicos;
        private System.Windows.Forms.BindingSource medicoVMBindingSource;
        private System.Windows.Forms.DataGridView dgvPacientesMedico;
        private System.Windows.Forms.BindingSource pacienteVMBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacienteIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCompletoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idHistoriaClinicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCompletoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrarEspecialidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn lunesHorarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn martesHorarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miercolesHorarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn juevesHorarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn viernesHorarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sabadoHorarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn domingoHorarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}
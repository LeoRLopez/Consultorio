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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn2 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn13 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.panelListaPacientes = new Telerik.WinControls.UI.RadPanel();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataFilterDescriptorItem1 = new Telerik.WinControls.UI.DataFilterDescriptorItem();
            this.dataFilterDescriptorItem2 = new Telerik.WinControls.UI.DataFilterDescriptorItem();
            this.dataFilterDescriptorItem3 = new Telerik.WinControls.UI.DataFilterDescriptorItem();
            this.dataFilterDescriptorItem4 = new Telerik.WinControls.UI.DataFilterDescriptorItem();
            this.dgvMedicos = new Telerik.WinControls.UI.RadGridView();
            this.dgvPacientesMedico = new Telerik.WinControls.UI.RadGridView();
            this.pacienteVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicoVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelListaPacientes)).BeginInit();
            this.panelListaPacientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientesMedico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientesMedico.MasterTemplate)).BeginInit();
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
            this.panelListaPacientes.Size = new System.Drawing.Size(540, 590);
            this.panelListaPacientes.TabIndex = 1;
            this.panelListaPacientes.Text = "panelListaPacientes";
            this.panelListaPacientes.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radPanel1
            // 
            this.radPanel1.BackColor = System.Drawing.Color.Snow;
            this.radPanel1.Controls.Add(this.dgvPacientesMedico);
            this.radPanel1.Controls.Add(this.label1);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel1.Location = new System.Drawing.Point(540, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(648, 590);
            this.radPanel1.TabIndex = 2;
            this.radPanel1.Text = "radPanel1";
            this.radPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
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
            // dgvMedicos
            // 
            this.dgvMedicos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMedicos.EnableKineticScrolling = true;
            this.dgvMedicos.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.dgvMedicos.MasterTemplate.AllowAddNewRow = false;
            this.dgvMedicos.MasterTemplate.AllowColumnChooser = false;
            this.dgvMedicos.MasterTemplate.AllowColumnReorder = false;
            this.dgvMedicos.MasterTemplate.AllowColumnResize = false;
            this.dgvMedicos.MasterTemplate.AllowDeleteRow = false;
            this.dgvMedicos.MasterTemplate.AllowDragToGroup = false;
            this.dgvMedicos.MasterTemplate.AllowEditRow = false;
            this.dgvMedicos.MasterTemplate.AllowRowReorder = true;
            this.dgvMedicos.MasterTemplate.AllowRowResize = false;
            this.dgvMedicos.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.FieldName = "MedicoId";
            gridViewDecimalColumn1.HeaderText = "MedicoId";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "MedicoId";
            gridViewDecimalColumn1.Width = 116;
            gridViewTextBoxColumn1.FieldName = "Matricula";
            gridViewTextBoxColumn1.HeaderText = "Matricula";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "Matricula";
            gridViewTextBoxColumn1.Width = 59;
            gridViewTextBoxColumn2.FieldName = "NombreCompleto";
            gridViewTextBoxColumn2.HeaderText = "Médico";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "NombreCompleto";
            gridViewTextBoxColumn2.Width = 230;
            gridViewTextBoxColumn3.DataType = typeof(System.Collections.Generic.List<Consultorio.ViewModels.EspecialidadMedicoVM>);
            gridViewTextBoxColumn3.FieldName = "EspecialidadesMedicoVM";
            gridViewTextBoxColumn3.HeaderText = "EspecialidadesMedicoVM";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.IsVisible = false;
            gridViewTextBoxColumn3.Name = "EspecialidadesMedicoVM";
            gridViewTextBoxColumn3.Width = 83;
            gridViewTextBoxColumn4.FieldName = "NombrarEspecialidades";
            gridViewTextBoxColumn4.HeaderText = "Especialidades";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "NombrarEspecialidades";
            gridViewTextBoxColumn4.ReadOnly = true;
            gridViewTextBoxColumn4.Width = 229;
            this.dgvMedicos.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.dgvMedicos.MasterTemplate.DataSource = this.medicoVMBindingSource;
            this.dgvMedicos.MasterTemplate.HorizontalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysHide;
            this.dgvMedicos.MasterTemplate.SearchRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            this.dgvMedicos.MasterTemplate.VerticalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysHide;
            this.dgvMedicos.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgvMedicos.Name = "dgvMedicos";
            this.dgvMedicos.ReadOnly = true;
            this.dgvMedicos.ShowGroupPanel = false;
            this.dgvMedicos.ShowGroupPanelScrollbars = false;
            this.dgvMedicos.Size = new System.Drawing.Size(540, 590);
            this.dgvMedicos.TabIndex = 24;
            this.dgvMedicos.Text = "radGridView1";
            this.dgvMedicos.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.dgvMedicos_CellClick);
            // 
            // dgvPacientesMedico
            // 
            this.dgvPacientesMedico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPacientesMedico.EnableKineticScrolling = true;
            this.dgvPacientesMedico.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.dgvPacientesMedico.MasterTemplate.AllowAddNewRow = false;
            this.dgvPacientesMedico.MasterTemplate.AllowColumnChooser = false;
            this.dgvPacientesMedico.MasterTemplate.AllowColumnReorder = false;
            this.dgvPacientesMedico.MasterTemplate.AllowColumnResize = false;
            this.dgvPacientesMedico.MasterTemplate.AllowDeleteRow = false;
            this.dgvPacientesMedico.MasterTemplate.AllowDragToGroup = false;
            this.dgvPacientesMedico.MasterTemplate.AllowEditRow = false;
            this.dgvPacientesMedico.MasterTemplate.AllowRowReorder = true;
            this.dgvPacientesMedico.MasterTemplate.AllowRowResize = false;
            this.dgvPacientesMedico.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn2.DataType = typeof(int);
            gridViewDecimalColumn2.FieldName = "PacienteId";
            gridViewDecimalColumn2.HeaderText = "PacienteId";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.IsVisible = false;
            gridViewDecimalColumn2.Name = "PacienteId";
            gridViewDecimalColumn2.Width = 49;
            gridViewDecimalColumn3.DataType = typeof(System.Nullable<int>);
            gridViewDecimalColumn3.FieldName = "IdHistoriaClinica";
            gridViewDecimalColumn3.HeaderText = "IdHistoriaClinica";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.IsVisible = false;
            gridViewDecimalColumn3.Name = "IdHistoriaClinica";
            gridViewDecimalColumn3.Width = 49;
            gridViewTextBoxColumn5.FieldName = "NombreCompleto";
            gridViewTextBoxColumn5.HeaderText = "Paciente";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "NombreCompleto";
            gridViewTextBoxColumn5.Width = 231;
            gridViewTextBoxColumn6.FieldName = "NroDocumento";
            gridViewTextBoxColumn6.HeaderText = "Documento";
            gridViewTextBoxColumn6.IsAutoGenerated = true;
            gridViewTextBoxColumn6.Name = "NroDocumento";
            gridViewTextBoxColumn6.Width = 90;
            gridViewTextBoxColumn7.FieldName = "Edad";
            gridViewTextBoxColumn7.HeaderText = "Edad";
            gridViewTextBoxColumn7.IsAutoGenerated = true;
            gridViewTextBoxColumn7.IsVisible = false;
            gridViewTextBoxColumn7.Name = "Edad";
            gridViewTextBoxColumn7.Width = 49;
            gridViewTextBoxColumn8.FieldName = "Email";
            gridViewTextBoxColumn8.HeaderText = "Email";
            gridViewTextBoxColumn8.IsAutoGenerated = true;
            gridViewTextBoxColumn8.Name = "Email";
            gridViewTextBoxColumn8.Width = 155;
            gridViewTextBoxColumn9.FieldName = "Telefono";
            gridViewTextBoxColumn9.HeaderText = "Telefono";
            gridViewTextBoxColumn9.IsAutoGenerated = true;
            gridViewTextBoxColumn9.Name = "Telefono";
            gridViewTextBoxColumn9.Width = 150;
            gridViewTextBoxColumn10.FieldName = "Direccion";
            gridViewTextBoxColumn10.HeaderText = "Direccion";
            gridViewTextBoxColumn10.IsAutoGenerated = true;
            gridViewTextBoxColumn10.IsVisible = false;
            gridViewTextBoxColumn10.Name = "Direccion";
            gridViewTextBoxColumn10.Width = 49;
            gridViewTextBoxColumn11.FieldName = "AntecedentesMedicos";
            gridViewTextBoxColumn11.HeaderText = "AntecedentesMedicos";
            gridViewTextBoxColumn11.IsAutoGenerated = true;
            gridViewTextBoxColumn11.IsVisible = false;
            gridViewTextBoxColumn11.Name = "AntecedentesMedicos";
            gridViewTextBoxColumn11.Width = 49;
            gridViewCheckBoxColumn1.FieldName = "Donante";
            gridViewCheckBoxColumn1.HeaderText = "Donante";
            gridViewCheckBoxColumn1.IsAutoGenerated = true;
            gridViewCheckBoxColumn1.IsVisible = false;
            gridViewCheckBoxColumn1.Name = "Donante";
            gridViewCheckBoxColumn1.Width = 49;
            gridViewCheckBoxColumn2.FieldName = "Trasplantado";
            gridViewCheckBoxColumn2.HeaderText = "Trasplantado";
            gridViewCheckBoxColumn2.IsAutoGenerated = true;
            gridViewCheckBoxColumn2.IsVisible = false;
            gridViewCheckBoxColumn2.Name = "Trasplantado";
            gridViewCheckBoxColumn2.Width = 49;
            gridViewTextBoxColumn12.FieldName = "GrupoSanguineo";
            gridViewTextBoxColumn12.HeaderText = "GrupoSanguineo";
            gridViewTextBoxColumn12.IsAutoGenerated = true;
            gridViewTextBoxColumn12.IsVisible = false;
            gridViewTextBoxColumn12.Name = "GrupoSanguineo";
            gridViewTextBoxColumn12.Width = 49;
            gridViewTextBoxColumn13.FieldName = "Sexo";
            gridViewTextBoxColumn13.HeaderText = "Sexo";
            gridViewTextBoxColumn13.IsAutoGenerated = true;
            gridViewTextBoxColumn13.IsVisible = false;
            gridViewTextBoxColumn13.Name = "Sexo";
            gridViewTextBoxColumn13.Width = 51;
            this.dgvPacientesMedico.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn2,
            gridViewDecimalColumn3,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11,
            gridViewCheckBoxColumn1,
            gridViewCheckBoxColumn2,
            gridViewTextBoxColumn12,
            gridViewTextBoxColumn13});
            this.dgvPacientesMedico.MasterTemplate.DataSource = this.pacienteVMBindingSource;
            this.dgvPacientesMedico.MasterTemplate.HorizontalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysHide;
            this.dgvPacientesMedico.MasterTemplate.SearchRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            this.dgvPacientesMedico.MasterTemplate.VerticalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysHide;
            this.dgvPacientesMedico.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.dgvPacientesMedico.Name = "dgvPacientesMedico";
            this.dgvPacientesMedico.ReadOnly = true;
            this.dgvPacientesMedico.ShowGroupPanel = false;
            this.dgvPacientesMedico.ShowGroupPanelScrollbars = false;
            this.dgvPacientesMedico.Size = new System.Drawing.Size(648, 590);
            this.dgvPacientesMedico.TabIndex = 25;
            this.dgvPacientesMedico.Text = "radGridView1";
            // 
            // pacienteVMBindingSource
            // 
            this.pacienteVMBindingSource.DataSource = typeof(Consultorio.ViewModels.PacienteVM);
            // 
            // medicoVMBindingSource
            // 
            this.medicoVMBindingSource.DataSource = typeof(Consultorio.ViewModels.MedicoVM);
            // 
            // ListadoMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 590);
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.panelListaPacientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListadoMedicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Listado de Medicos";
            this.Load += new System.EventHandler(this.Medicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelListaPacientes)).EndInit();
            this.panelListaPacientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientesMedico.MasterTemplate)).EndInit();
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
        private System.Windows.Forms.BindingSource medicoVMBindingSource;
        private System.Windows.Forms.BindingSource pacienteVMBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadGridView dgvMedicos;
        private Telerik.WinControls.UI.RadGridView dgvPacientesMedico;
    }
}
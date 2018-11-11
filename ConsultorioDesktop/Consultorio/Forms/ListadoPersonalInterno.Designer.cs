namespace Consultorio.Forms
{
    partial class ListadoPersonalInterno
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.btnBuscar = new Telerik.WinControls.UI.RadButton();
            this.txtBoxBuscar = new Telerik.WinControls.UI.RadTextBox();
            this.btnEliminar = new Telerik.WinControls.UI.RadButton();
            this.btnEditar = new Telerik.WinControls.UI.RadButton();
            this.btnAgregar = new Telerik.WinControls.UI.RadButton();
            this.lblbNombre = new Telerik.WinControls.UI.RadLabel();
            this.dgvPersonalInterno = new Telerik.WinControls.UI.RadGridView();
            this.personalInternoVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblbNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonalInterno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonalInterno.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalInternoVMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.Location = new System.Drawing.Point(229, 556);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(157, 25);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // txtBoxBuscar
            // 
            this.txtBoxBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxBuscar.Location = new System.Drawing.Point(66, 558);
            this.txtBoxBuscar.Name = "txtBoxBuscar";
            this.txtBoxBuscar.Size = new System.Drawing.Size(157, 21);
            this.txtBoxBuscar.TabIndex = 18;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.Location = new System.Drawing.Point(782, 556);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(157, 25);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEditar.Location = new System.Drawing.Point(620, 556);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(157, 25);
            this.btnEditar.TabIndex = 16;
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.Location = new System.Drawing.Point(458, 556);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(157, 25);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // lblbNombre
            // 
            this.lblbNombre.Location = new System.Drawing.Point(12, 559);
            this.lblbNombre.Name = "lblbNombre";
            this.lblbNombre.Size = new System.Drawing.Size(48, 18);
            this.lblbNombre.TabIndex = 21;
            this.lblbNombre.Text = "Nombre";
            // 
            // dgvPersonalInterno
            // 
            this.dgvPersonalInterno.EnableKineticScrolling = true;
            this.dgvPersonalInterno.Location = new System.Drawing.Point(12, 12);
            // 
            // 
            // 
            this.dgvPersonalInterno.MasterTemplate.AllowAddNewRow = false;
            this.dgvPersonalInterno.MasterTemplate.AllowColumnChooser = false;
            this.dgvPersonalInterno.MasterTemplate.AllowColumnReorder = false;
            this.dgvPersonalInterno.MasterTemplate.AllowColumnResize = false;
            this.dgvPersonalInterno.MasterTemplate.AllowDeleteRow = false;
            this.dgvPersonalInterno.MasterTemplate.AllowDragToGroup = false;
            this.dgvPersonalInterno.MasterTemplate.AllowEditRow = false;
            this.dgvPersonalInterno.MasterTemplate.AllowRowReorder = true;
            this.dgvPersonalInterno.MasterTemplate.AllowRowResize = false;
            this.dgvPersonalInterno.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.FieldName = "PersonalInternoId";
            gridViewDecimalColumn1.HeaderText = "PersonalInternoId";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "PersonalInternoId";
            gridViewTextBoxColumn1.FieldName = "NombreCompleto";
            gridViewTextBoxColumn1.HeaderText = "Nombre";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "NombreCompleto";
            gridViewTextBoxColumn1.Width = 143;
            gridViewTextBoxColumn2.FieldName = "Edad";
            gridViewTextBoxColumn2.HeaderText = "Edad";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "Edad";
            gridViewTextBoxColumn2.Width = 143;
            gridViewTextBoxColumn3.FieldName = "Email";
            gridViewTextBoxColumn3.HeaderText = "Email";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "Email";
            gridViewTextBoxColumn3.Width = 143;
            gridViewTextBoxColumn4.FieldName = "UsuarioSistema";
            gridViewTextBoxColumn4.HeaderText = "Usuario";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "UsuarioSistema";
            gridViewTextBoxColumn4.Width = 143;
            gridViewTextBoxColumn5.FieldName = "Telefono";
            gridViewTextBoxColumn5.HeaderText = "Telefono";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "Telefono";
            gridViewTextBoxColumn5.Width = 143;
            gridViewTextBoxColumn6.FieldName = "Rol";
            gridViewTextBoxColumn6.HeaderText = "Rol";
            gridViewTextBoxColumn6.IsAutoGenerated = true;
            gridViewTextBoxColumn6.Name = "Rol";
            gridViewTextBoxColumn6.Width = 143;
            gridViewTextBoxColumn7.FieldName = "Matricula";
            gridViewTextBoxColumn7.HeaderText = "Matricula";
            gridViewTextBoxColumn7.IsAutoGenerated = true;
            gridViewTextBoxColumn7.Name = "Matricula";
            gridViewTextBoxColumn7.Width = 143;
            gridViewTextBoxColumn8.FieldName = "Especialidades";
            gridViewTextBoxColumn8.HeaderText = "Especialidades";
            gridViewTextBoxColumn8.IsAutoGenerated = true;
            gridViewTextBoxColumn8.Name = "Especialidades";
            gridViewTextBoxColumn8.Width = 141;
            this.dgvPersonalInterno.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8});
            this.dgvPersonalInterno.MasterTemplate.DataSource = this.personalInternoVMBindingSource;
            this.dgvPersonalInterno.MasterTemplate.HorizontalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysHide;
            this.dgvPersonalInterno.MasterTemplate.SearchRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            this.dgvPersonalInterno.MasterTemplate.VerticalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysHide;
            this.dgvPersonalInterno.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgvPersonalInterno.Name = "dgvPersonalInterno";
            this.dgvPersonalInterno.ReadOnly = true;
            this.dgvPersonalInterno.ShowGroupPanel = false;
            this.dgvPersonalInterno.ShowGroupPanelScrollbars = false;
            this.dgvPersonalInterno.Size = new System.Drawing.Size(1164, 534);
            this.dgvPersonalInterno.TabIndex = 22;
            this.dgvPersonalInterno.Text = "radGridView1";
            // 
            // personalInternoVMBindingSource
            // 
            this.personalInternoVMBindingSource.DataSource = typeof(Consultorio.ViewModels.PersonalInternoVM);
            // 
            // ListadoPersonalInterno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1188, 590);
            this.Controls.Add(this.dgvPersonalInterno);
            this.Controls.Add(this.lblbNombre);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBoxBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListadoPersonalInterno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Personal Interno";
            this.Load += new System.EventHandler(this.ListadoPersonalInterno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblbNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonalInterno.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonalInterno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalInternoVMBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnBuscar;
        private Telerik.WinControls.UI.RadTextBox txtBoxBuscar;
        private Telerik.WinControls.UI.RadButton btnEliminar;
        private Telerik.WinControls.UI.RadButton btnEditar;
        private Telerik.WinControls.UI.RadButton btnAgregar;
        private System.Windows.Forms.BindingSource personalInternoVMBindingSource;
        private Telerik.WinControls.UI.RadLabel lblbNombre;
        private Telerik.WinControls.UI.RadGridView dgvPersonalInterno;
    }
}
namespace Consultorio
{
    partial class ListadoObrasSociales
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
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.btnAgregar = new Telerik.WinControls.UI.RadButton();
            this.btnVolver = new Telerik.WinControls.UI.RadButton();
            this.txtBoxBuscar = new Telerik.WinControls.UI.RadTextBox();
            this.lblBuscar = new Telerik.WinControls.UI.RadLabel();
            this.btnBuscar = new Telerik.WinControls.UI.RadButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnEditar = new Telerik.WinControls.UI.RadButton();
            this.btnHabilitar = new Telerik.WinControls.UI.RadButton();
            this.dgvObrasSociales = new Telerik.WinControls.UI.RadGridView();
            this.segurosMedicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnExportar = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHabilitar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObrasSociales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObrasSociales.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.segurosMedicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExportar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.Location = new System.Drawing.Point(427, 111);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(157, 25);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnVolver.Location = new System.Drawing.Point(450, 296);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(110, 24);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // txtBoxBuscar
            // 
            this.txtBoxBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxBuscar.Location = new System.Drawing.Point(427, 37);
            this.txtBoxBuscar.Name = "txtBoxBuscar";
            this.txtBoxBuscar.Size = new System.Drawing.Size(157, 21);
            this.txtBoxBuscar.TabIndex = 4;
            // 
            // lblBuscar
            // 
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBuscar.Location = new System.Drawing.Point(432, 12);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(120, 19);
            this.lblBuscar.TabIndex = 5;
            this.lblBuscar.Text = "Nombre Obra Social:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.Location = new System.Drawing.Point(427, 64);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(157, 24);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEditar.Location = new System.Drawing.Point(427, 142);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(157, 25);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnHabilitar
            // 
            this.btnHabilitar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnHabilitar.Location = new System.Drawing.Point(427, 173);
            this.btnHabilitar.Name = "btnHabilitar";
            this.btnHabilitar.Size = new System.Drawing.Size(157, 25);
            this.btnHabilitar.TabIndex = 9;
            this.btnHabilitar.Text = "Habilitar/Deshabilitar";
            this.btnHabilitar.Click += new System.EventHandler(this.btnHabilitarDeshabilitar_Click);
            // 
            // dgvObrasSociales
            // 
            this.dgvObrasSociales.EnableKineticScrolling = true;
            this.dgvObrasSociales.Location = new System.Drawing.Point(0, 1);
            // 
            // 
            // 
            this.dgvObrasSociales.MasterTemplate.AllowAddNewRow = false;
            this.dgvObrasSociales.MasterTemplate.AllowColumnChooser = false;
            this.dgvObrasSociales.MasterTemplate.AllowColumnReorder = false;
            this.dgvObrasSociales.MasterTemplate.AllowColumnResize = false;
            this.dgvObrasSociales.MasterTemplate.AllowDeleteRow = false;
            this.dgvObrasSociales.MasterTemplate.AllowDragToGroup = false;
            this.dgvObrasSociales.MasterTemplate.AllowEditRow = false;
            this.dgvObrasSociales.MasterTemplate.AllowRowReorder = true;
            this.dgvObrasSociales.MasterTemplate.AllowRowResize = false;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.FieldName = "IdSeguroMedico";
            gridViewDecimalColumn1.HeaderText = "IdSeguroMedico";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "IdSeguroMedico";
            gridViewTextBoxColumn1.FieldName = "Nombre";
            gridViewTextBoxColumn1.HeaderText = "Nombre";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "Nombre";
            gridViewTextBoxColumn1.Width = 340;
            gridViewCheckBoxColumn1.FieldName = "BajaLogica";
            gridViewCheckBoxColumn1.HeaderText = "Habilitado";
            gridViewCheckBoxColumn1.IsAutoGenerated = true;
            gridViewCheckBoxColumn1.Name = "BajaLogica";
            gridViewCheckBoxColumn1.Width = 60;
            gridViewTextBoxColumn2.DataType = typeof(System.Collections.Generic.ICollection<Consultorio.Modelo.SegurosMedicosMedico>);
            gridViewTextBoxColumn2.FieldName = "SegurosMedicosMedico";
            gridViewTextBoxColumn2.HeaderText = "SegurosMedicosMedico";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.IsVisible = false;
            gridViewTextBoxColumn2.Name = "SegurosMedicosMedico";
            gridViewTextBoxColumn3.DataType = typeof(System.Collections.Generic.ICollection<Consultorio.Modelo.SegurosMedicosPaciente>);
            gridViewTextBoxColumn3.FieldName = "SegurosMedicosPaciente";
            gridViewTextBoxColumn3.HeaderText = "SegurosMedicosPaciente";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.IsVisible = false;
            gridViewTextBoxColumn3.Name = "SegurosMedicosPaciente";
            gridViewTextBoxColumn4.DataType = typeof(System.Collections.Generic.ICollection<Consultorio.Modelo.Turno>);
            gridViewTextBoxColumn4.FieldName = "Turno";
            gridViewTextBoxColumn4.HeaderText = "Turno";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.IsVisible = false;
            gridViewTextBoxColumn4.Name = "Turno";
            this.dgvObrasSociales.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewCheckBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.dgvObrasSociales.MasterTemplate.DataSource = this.segurosMedicoBindingSource;
            this.dgvObrasSociales.MasterTemplate.HorizontalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysHide;
            this.dgvObrasSociales.MasterTemplate.SearchRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            this.dgvObrasSociales.MasterTemplate.VerticalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysHide;
            this.dgvObrasSociales.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgvObrasSociales.Name = "dgvObrasSociales";
            this.dgvObrasSociales.ReadOnly = true;
            this.dgvObrasSociales.ShowGroupPanel = false;
            this.dgvObrasSociales.ShowGroupPanelScrollbars = false;
            this.dgvObrasSociales.Size = new System.Drawing.Size(421, 319);
            this.dgvObrasSociales.TabIndex = 10;
            this.dgvObrasSociales.Text = "radGridView1";
            // 
            // segurosMedicoBindingSource
            // 
            this.segurosMedicoBindingSource.DataSource = typeof(Consultorio.Modelo.SegurosMedico);
            // 
            // btnExportar
            // 
            this.btnExportar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnExportar.Location = new System.Drawing.Point(429, 218);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(157, 25);
            this.btnExportar.TabIndex = 10;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // ListadoObrasSociales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(598, 332);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.dgvObrasSociales);
            this.Controls.Add(this.btnHabilitar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtBoxBuscar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ListadoObrasSociales";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Obras Sociales";
            this.Load += new System.EventHandler(this.Forma_Pago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHabilitar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObrasSociales.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObrasSociales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.segurosMedicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExportar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private Telerik.WinControls.UI.RadButton btnAgregar;
        private Telerik.WinControls.UI.RadButton btnVolver;
        private Telerik.WinControls.UI.RadTextBox txtBoxBuscar;
        private Telerik.WinControls.UI.RadLabel lblBuscar;
        private Telerik.WinControls.UI.RadButton btnBuscar;
        private System.Windows.Forms.BindingSource segurosMedicoBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Telerik.WinControls.UI.RadButton btnEditar;
        private Telerik.WinControls.UI.RadButton btnHabilitar;
        private Telerik.WinControls.UI.RadGridView dgvObrasSociales;
        private Telerik.WinControls.UI.RadButton btnExportar;
    }
}
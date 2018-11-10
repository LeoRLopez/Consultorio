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
            this.btnBuscar = new Telerik.WinControls.UI.RadButton();
            this.txtBoxBuscar = new Telerik.WinControls.UI.RadTextBox();
            this.btnEliminar = new Telerik.WinControls.UI.RadButton();
            this.btnEditar = new Telerik.WinControls.UI.RadButton();
            this.dgvPersonalInterno = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new Telerik.WinControls.UI.RadButton();
            this.lblbNombre = new Telerik.WinControls.UI.RadLabel();
            this.personalInternoVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personalInternoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioSistemaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCompletoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matriculaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especialidadesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonalInterno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblbNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalInternoVMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.Location = new System.Drawing.Point(229, 564);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(157, 25);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // txtBoxBuscar
            // 
            this.txtBoxBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxBuscar.Location = new System.Drawing.Point(66, 566);
            this.txtBoxBuscar.Name = "txtBoxBuscar";
            this.txtBoxBuscar.Size = new System.Drawing.Size(157, 21);
            this.txtBoxBuscar.TabIndex = 18;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.Location = new System.Drawing.Point(782, 567);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(157, 25);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEditar.Location = new System.Drawing.Point(620, 567);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(157, 25);
            this.btnEditar.TabIndex = 16;
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // dgvPersonalInterno
            // 
            this.dgvPersonalInterno.AllowUserToAddRows = false;
            this.dgvPersonalInterno.AllowUserToDeleteRows = false;
            this.dgvPersonalInterno.AllowUserToResizeRows = false;
            this.dgvPersonalInterno.AutoGenerateColumns = false;
            this.dgvPersonalInterno.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvPersonalInterno.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvPersonalInterno.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvPersonalInterno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonalInterno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personalInternoIdDataGridViewTextBoxColumn,
            this.usuarioSistemaDataGridViewTextBoxColumn,
            this.rolDataGridViewTextBoxColumn,
            this.nombreCompletoDataGridViewTextBoxColumn,
            this.edadDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.matriculaDataGridViewTextBoxColumn,
            this.especialidadesDataGridViewTextBoxColumn});
            this.dgvPersonalInterno.DataSource = this.personalInternoVMBindingSource;
            this.dgvPersonalInterno.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(252)))), ((int)(((byte)(249)))));
            this.dgvPersonalInterno.Location = new System.Drawing.Point(12, 12);
            this.dgvPersonalInterno.Name = "dgvPersonalInterno";
            this.dgvPersonalInterno.ReadOnly = true;
            this.dgvPersonalInterno.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvPersonalInterno.RowHeadersVisible = false;
            this.dgvPersonalInterno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonalInterno.Size = new System.Drawing.Size(926, 550);
            this.dgvPersonalInterno.TabIndex = 15;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.Location = new System.Drawing.Point(458, 567);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(157, 25);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // lblbNombre
            // 
            this.lblbNombre.Location = new System.Drawing.Point(12, 568);
            this.lblbNombre.Name = "lblbNombre";
            this.lblbNombre.Size = new System.Drawing.Size(48, 18);
            this.lblbNombre.TabIndex = 21;
            this.lblbNombre.Text = "Nombre";
            // 
            // personalInternoVMBindingSource
            // 
            this.personalInternoVMBindingSource.DataSource = typeof(Consultorio.ViewModels.PersonalInternoVM);
            // 
            // personalInternoIdDataGridViewTextBoxColumn
            // 
            this.personalInternoIdDataGridViewTextBoxColumn.DataPropertyName = "PersonalInternoId";
            this.personalInternoIdDataGridViewTextBoxColumn.HeaderText = "PersonalInternoId";
            this.personalInternoIdDataGridViewTextBoxColumn.Name = "personalInternoIdDataGridViewTextBoxColumn";
            this.personalInternoIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.personalInternoIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // usuarioSistemaDataGridViewTextBoxColumn
            // 
            this.usuarioSistemaDataGridViewTextBoxColumn.DataPropertyName = "UsuarioSistema";
            this.usuarioSistemaDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usuarioSistemaDataGridViewTextBoxColumn.Name = "usuarioSistemaDataGridViewTextBoxColumn";
            this.usuarioSistemaDataGridViewTextBoxColumn.ReadOnly = true;
            this.usuarioSistemaDataGridViewTextBoxColumn.Width = 150;
            // 
            // rolDataGridViewTextBoxColumn
            // 
            this.rolDataGridViewTextBoxColumn.DataPropertyName = "Rol";
            this.rolDataGridViewTextBoxColumn.HeaderText = "Rol";
            this.rolDataGridViewTextBoxColumn.Name = "rolDataGridViewTextBoxColumn";
            this.rolDataGridViewTextBoxColumn.ReadOnly = true;
            this.rolDataGridViewTextBoxColumn.Width = 85;
            // 
            // nombreCompletoDataGridViewTextBoxColumn
            // 
            this.nombreCompletoDataGridViewTextBoxColumn.DataPropertyName = "NombreCompleto";
            this.nombreCompletoDataGridViewTextBoxColumn.HeaderText = "Nombre Completo";
            this.nombreCompletoDataGridViewTextBoxColumn.Name = "nombreCompletoDataGridViewTextBoxColumn";
            this.nombreCompletoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreCompletoDataGridViewTextBoxColumn.Width = 150;
            // 
            // edadDataGridViewTextBoxColumn
            // 
            this.edadDataGridViewTextBoxColumn.DataPropertyName = "Edad";
            this.edadDataGridViewTextBoxColumn.HeaderText = "Edad";
            this.edadDataGridViewTextBoxColumn.Name = "edadDataGridViewTextBoxColumn";
            this.edadDataGridViewTextBoxColumn.ReadOnly = true;
            this.edadDataGridViewTextBoxColumn.Width = 30;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 120;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefonoDataGridViewTextBoxColumn.Width = 80;
            // 
            // matriculaDataGridViewTextBoxColumn
            // 
            this.matriculaDataGridViewTextBoxColumn.DataPropertyName = "Matricula";
            this.matriculaDataGridViewTextBoxColumn.HeaderText = "Matricula";
            this.matriculaDataGridViewTextBoxColumn.Name = "matriculaDataGridViewTextBoxColumn";
            this.matriculaDataGridViewTextBoxColumn.ReadOnly = true;
            this.matriculaDataGridViewTextBoxColumn.Width = 50;
            // 
            // especialidadesDataGridViewTextBoxColumn
            // 
            this.especialidadesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.especialidadesDataGridViewTextBoxColumn.DataPropertyName = "Especialidades";
            this.especialidadesDataGridViewTextBoxColumn.HeaderText = "Especialidades";
            this.especialidadesDataGridViewTextBoxColumn.Name = "especialidadesDataGridViewTextBoxColumn";
            this.especialidadesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ListadoPersonalInterno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(952, 748);
            this.Controls.Add(this.lblbNombre);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBoxBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgvPersonalInterno);
            this.Controls.Add(this.btnAgregar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListadoPersonalInterno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Interno";
            this.Load += new System.EventHandler(this.ListadoPersonalInterno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonalInterno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblbNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalInternoVMBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnBuscar;
        private Telerik.WinControls.UI.RadTextBox txtBoxBuscar;
        private Telerik.WinControls.UI.RadButton btnEliminar;
        private Telerik.WinControls.UI.RadButton btnEditar;
        private System.Windows.Forms.DataGridView dgvPersonalInterno;
        private Telerik.WinControls.UI.RadButton btnAgregar;
        private System.Windows.Forms.BindingSource personalInternoVMBindingSource;
        private Telerik.WinControls.UI.RadLabel lblbNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn personalInternoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioSistemaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCompletoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialidadesDataGridViewTextBoxColumn;
    }
}
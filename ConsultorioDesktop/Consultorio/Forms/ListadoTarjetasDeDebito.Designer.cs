namespace Consultorio.Forms
{
    partial class ListadoTarjetasDeDebito
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
            this.lblBuscar = new Telerik.WinControls.UI.RadLabel();
            this.txtBoxBuscar = new Telerik.WinControls.UI.RadTextBox();
            this.btnEliminar = new Telerik.WinControls.UI.RadButton();
            this.btnEditar = new Telerik.WinControls.UI.RadButton();
            this.dgvTarjetas = new System.Windows.Forms.DataGridView();
            this.idTarjetaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroTarjetaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVtoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idBancoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreTarjetaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bajaLogicaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bancosTarjetasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacienteTarjetasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarjetasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnVolver = new Telerik.WinControls.UI.RadButton();
            this.btnAgregar = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarjetas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarjetasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.Location = new System.Drawing.Point(429, 64);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(157, 24);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBuscar.Location = new System.Drawing.Point(486, 12);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(45, 19);
            this.lblBuscar.TabIndex = 19;
            this.lblBuscar.Text = "Buscar:";
            // 
            // txtBoxBuscar
            // 
            this.txtBoxBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxBuscar.Location = new System.Drawing.Point(429, 37);
            this.txtBoxBuscar.Name = "txtBoxBuscar";
            this.txtBoxBuscar.Size = new System.Drawing.Size(157, 21);
            this.txtBoxBuscar.TabIndex = 18;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.Location = new System.Drawing.Point(429, 164);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(157, 25);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEditar.Location = new System.Drawing.Point(429, 136);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(157, 25);
            this.btnEditar.TabIndex = 16;
            this.btnEditar.Text = "Editar";
            // 
            // dgvTarjetas
            // 
            this.dgvTarjetas.AllowUserToAddRows = false;
            this.dgvTarjetas.AllowUserToDeleteRows = false;
            this.dgvTarjetas.AllowUserToResizeColumns = false;
            this.dgvTarjetas.AllowUserToResizeRows = false;
            this.dgvTarjetas.AutoGenerateColumns = false;
            this.dgvTarjetas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTarjetas.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvTarjetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarjetas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTarjetaDataGridViewTextBoxColumn,
            this.titularDataGridViewTextBoxColumn,
            this.numeroTarjetaDataGridViewTextBoxColumn,
            this.fechaVtoDataGridViewTextBoxColumn,
            this.idBancoDataGridViewTextBoxColumn,
            this.nombreTarjetaDataGridViewTextBoxColumn,
            this.bajaLogicaDataGridViewCheckBoxColumn,
            this.bancosTarjetasDataGridViewTextBoxColumn,
            this.pacienteTarjetasDataGridViewTextBoxColumn});
            this.dgvTarjetas.DataSource = this.tarjetasBindingSource;
            this.dgvTarjetas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(252)))), ((int)(((byte)(249)))));
            this.dgvTarjetas.Location = new System.Drawing.Point(12, 12);
            this.dgvTarjetas.Name = "dgvTarjetas";
            this.dgvTarjetas.ReadOnly = true;
            this.dgvTarjetas.RowHeadersVisible = false;
            this.dgvTarjetas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTarjetas.Size = new System.Drawing.Size(409, 308);
            this.dgvTarjetas.TabIndex = 15;
            // 
            // idTarjetaDataGridViewTextBoxColumn
            // 
            this.idTarjetaDataGridViewTextBoxColumn.DataPropertyName = "IdTarjeta";
            this.idTarjetaDataGridViewTextBoxColumn.HeaderText = "IdTarjeta";
            this.idTarjetaDataGridViewTextBoxColumn.Name = "idTarjetaDataGridViewTextBoxColumn";
            this.idTarjetaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTarjetaDataGridViewTextBoxColumn.Visible = false;
            // 
            // titularDataGridViewTextBoxColumn
            // 
            this.titularDataGridViewTextBoxColumn.DataPropertyName = "Titular";
            this.titularDataGridViewTextBoxColumn.HeaderText = "Titular";
            this.titularDataGridViewTextBoxColumn.Name = "titularDataGridViewTextBoxColumn";
            this.titularDataGridViewTextBoxColumn.ReadOnly = true;
            this.titularDataGridViewTextBoxColumn.Visible = false;
            // 
            // numeroTarjetaDataGridViewTextBoxColumn
            // 
            this.numeroTarjetaDataGridViewTextBoxColumn.DataPropertyName = "NumeroTarjeta";
            this.numeroTarjetaDataGridViewTextBoxColumn.HeaderText = "NumeroTarjeta";
            this.numeroTarjetaDataGridViewTextBoxColumn.Name = "numeroTarjetaDataGridViewTextBoxColumn";
            this.numeroTarjetaDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroTarjetaDataGridViewTextBoxColumn.Visible = false;
            // 
            // fechaVtoDataGridViewTextBoxColumn
            // 
            this.fechaVtoDataGridViewTextBoxColumn.DataPropertyName = "FechaVto";
            this.fechaVtoDataGridViewTextBoxColumn.HeaderText = "FechaVto";
            this.fechaVtoDataGridViewTextBoxColumn.Name = "fechaVtoDataGridViewTextBoxColumn";
            this.fechaVtoDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaVtoDataGridViewTextBoxColumn.Visible = false;
            // 
            // idBancoDataGridViewTextBoxColumn
            // 
            this.idBancoDataGridViewTextBoxColumn.DataPropertyName = "IdBanco";
            this.idBancoDataGridViewTextBoxColumn.HeaderText = "IdBanco";
            this.idBancoDataGridViewTextBoxColumn.Name = "idBancoDataGridViewTextBoxColumn";
            this.idBancoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idBancoDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreTarjetaDataGridViewTextBoxColumn
            // 
            this.nombreTarjetaDataGridViewTextBoxColumn.DataPropertyName = "NombreTarjeta";
            this.nombreTarjetaDataGridViewTextBoxColumn.HeaderText = "Tarjeta";
            this.nombreTarjetaDataGridViewTextBoxColumn.Name = "nombreTarjetaDataGridViewTextBoxColumn";
            this.nombreTarjetaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bajaLogicaDataGridViewCheckBoxColumn
            // 
            this.bajaLogicaDataGridViewCheckBoxColumn.DataPropertyName = "BajaLogica";
            this.bajaLogicaDataGridViewCheckBoxColumn.HeaderText = "Deshabilitado";
            this.bajaLogicaDataGridViewCheckBoxColumn.Name = "bajaLogicaDataGridViewCheckBoxColumn";
            this.bajaLogicaDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // bancosTarjetasDataGridViewTextBoxColumn
            // 
            this.bancosTarjetasDataGridViewTextBoxColumn.DataPropertyName = "Bancos_Tarjetas";
            this.bancosTarjetasDataGridViewTextBoxColumn.HeaderText = "Bancos_Tarjetas";
            this.bancosTarjetasDataGridViewTextBoxColumn.Name = "bancosTarjetasDataGridViewTextBoxColumn";
            this.bancosTarjetasDataGridViewTextBoxColumn.ReadOnly = true;
            this.bancosTarjetasDataGridViewTextBoxColumn.Visible = false;
            // 
            // pacienteTarjetasDataGridViewTextBoxColumn
            // 
            this.pacienteTarjetasDataGridViewTextBoxColumn.DataPropertyName = "Paciente_Tarjetas";
            this.pacienteTarjetasDataGridViewTextBoxColumn.HeaderText = "Paciente_Tarjetas";
            this.pacienteTarjetasDataGridViewTextBoxColumn.Name = "pacienteTarjetasDataGridViewTextBoxColumn";
            this.pacienteTarjetasDataGridViewTextBoxColumn.ReadOnly = true;
            this.pacienteTarjetasDataGridViewTextBoxColumn.Visible = false;
            // 
            // tarjetasBindingSource
            // 
            this.tarjetasBindingSource.DataSource = typeof(Consultorio.Modelo.Tarjetas);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnVolver.Location = new System.Drawing.Point(450, 296);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(110, 24);
            this.btnVolver.TabIndex = 14;
            this.btnVolver.Text = "Volver";
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.Location = new System.Drawing.Point(429, 106);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(157, 25);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // ListadoTarjetasDeDebito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(598, 332);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtBoxBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgvTarjetas);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAgregar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ListadoTarjetasDeDebito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarjeta de Débito";
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarjetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarjetasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnBuscar;
        private Telerik.WinControls.UI.RadLabel lblBuscar;
        private Telerik.WinControls.UI.RadTextBox txtBoxBuscar;
        private Telerik.WinControls.UI.RadButton btnEliminar;
        private Telerik.WinControls.UI.RadButton btnEditar;
        private System.Windows.Forms.DataGridView dgvTarjetas;
        private Telerik.WinControls.UI.RadButton btnVolver;
        private Telerik.WinControls.UI.RadButton btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTarjetaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroTarjetaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVtoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBancoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreTarjetaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bajaLogicaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bancosTarjetasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacienteTarjetasDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tarjetasBindingSource;
    }
}
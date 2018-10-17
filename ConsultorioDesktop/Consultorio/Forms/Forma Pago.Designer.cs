namespace Consultorio
{
    partial class Forma_Pago
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
            this.btnAgregar = new Telerik.WinControls.UI.RadButton();
            this.btnVolver = new Telerik.WinControls.UI.RadButton();
            this.txtBoxNombreSeguroMedico = new Telerik.WinControls.UI.RadTextBox();
            this.lblAgregarSeguroMedico = new Telerik.WinControls.UI.RadLabel();
            this.txtBoxBuscar = new Telerik.WinControls.UI.RadTextBox();
            this.lblBuscar = new Telerik.WinControls.UI.RadLabel();
            this.btnBuscar = new Telerik.WinControls.UI.RadButton();
            this.dgvSegurosMedicos = new System.Windows.Forms.DataGridView();
            this.idSeguroMedicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.segurosMedicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxNombreSeguroMedico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAgregarSeguroMedico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSegurosMedicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.segurosMedicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.Location = new System.Drawing.Point(427, 165);
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
            // txtBoxNombreSeguroMedico
            // 
            this.txtBoxNombreSeguroMedico.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxNombreSeguroMedico.Location = new System.Drawing.Point(427, 138);
            this.txtBoxNombreSeguroMedico.Name = "txtBoxNombreSeguroMedico";
            this.txtBoxNombreSeguroMedico.Size = new System.Drawing.Size(157, 21);
            this.txtBoxNombreSeguroMedico.TabIndex = 1;
            // 
            // lblAgregarSeguroMedico
            // 
            this.lblAgregarSeguroMedico.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAgregarSeguroMedico.Location = new System.Drawing.Point(460, 113);
            this.lblAgregarSeguroMedico.Name = "lblAgregarSeguroMedico";
            this.lblAgregarSeguroMedico.Size = new System.Drawing.Size(92, 19);
            this.lblAgregarSeguroMedico.TabIndex = 0;
            this.lblAgregarSeguroMedico.Text = "Seguro Medico:";
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
            this.lblBuscar.Location = new System.Drawing.Point(484, 12);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(45, 19);
            this.lblBuscar.TabIndex = 5;
            this.lblBuscar.Text = "Buscar:";
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
            // dgvSegurosMedicos
            // 
            this.dgvSegurosMedicos.AllowUserToAddRows = false;
            this.dgvSegurosMedicos.AllowUserToDeleteRows = false;
            this.dgvSegurosMedicos.AutoGenerateColumns = false;
            this.dgvSegurosMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSegurosMedicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSeguroMedicoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn});
            this.dgvSegurosMedicos.DataSource = this.segurosMedicoBindingSource;
            this.dgvSegurosMedicos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(252)))), ((int)(((byte)(249)))));
            this.dgvSegurosMedicos.Location = new System.Drawing.Point(12, 12);
            this.dgvSegurosMedicos.Name = "dgvSegurosMedicos";
            this.dgvSegurosMedicos.ReadOnly = true;
            this.dgvSegurosMedicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSegurosMedicos.Size = new System.Drawing.Size(409, 308);
            this.dgvSegurosMedicos.TabIndex = 7;
            // 
            // idSeguroMedicoDataGridViewTextBoxColumn
            // 
            this.idSeguroMedicoDataGridViewTextBoxColumn.DataPropertyName = "IdSeguroMedico";
            this.idSeguroMedicoDataGridViewTextBoxColumn.HeaderText = "IdSeguroMedico";
            this.idSeguroMedicoDataGridViewTextBoxColumn.Name = "idSeguroMedicoDataGridViewTextBoxColumn";
            this.idSeguroMedicoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idSeguroMedicoDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // segurosMedicoBindingSource
            // 
            this.segurosMedicoBindingSource.DataSource = typeof(Consultorio.Modelo.SegurosMedico);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Forma_Pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(598, 332);
            this.Controls.Add(this.dgvSegurosMedicos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtBoxBuscar);
            this.Controls.Add(this.lblAgregarSeguroMedico);
            this.Controls.Add(this.txtBoxNombreSeguroMedico);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Forma_Pago";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formas de Pago";
            this.Load += new System.EventHandler(this.Forma_Pago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxNombreSeguroMedico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAgregarSeguroMedico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSegurosMedicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.segurosMedicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private Telerik.WinControls.UI.RadButton btnAgregar;
        private Telerik.WinControls.UI.RadButton btnVolver;
        private Telerik.WinControls.UI.RadTextBox txtBoxNombreSeguroMedico;
        private Telerik.WinControls.UI.RadLabel lblAgregarSeguroMedico;
        private Telerik.WinControls.UI.RadTextBox txtBoxBuscar;
        private Telerik.WinControls.UI.RadLabel lblBuscar;
        private Telerik.WinControls.UI.RadButton btnBuscar;
        private System.Windows.Forms.DataGridView dgvSegurosMedicos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSeguroMedicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource segurosMedicoBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
namespace Consultorio.Forms
{
    partial class AgregarFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarFactura));
            this.lblNombre = new Telerik.WinControls.UI.RadLabel();
            this.tbDescripcion = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.btnCancelar = new Telerik.WinControls.UI.RadButton();
            this.btnCrear = new Telerik.WinControls.UI.RadButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbTitular = new System.Windows.Forms.TextBox();
            this.tbNroTarjeta = new System.Windows.Forms.TextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.tbFechaVto = new System.Windows.Forms.MaskedTextBox();
            this.tbNombreTarjeta = new System.Windows.Forms.TextBox();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.lblNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCrear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            resources.ApplyResources(this.lblNombre, "lblNombre");
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.ThemeName = "MedicalAppTheme";
            // 
            // tbDescripcion
            // 
            resources.ApplyResources(this.tbDescripcion, "tbDescripcion");
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            // 
            // radLabel2
            // 
            this.radLabel2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.radLabel2, "radLabel2");
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.ThemeName = "MedicalAppTheme";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnCancelar, "btnCancelar");
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.ThemeName = "MedicalAppTheme";
            this.btnCancelar.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // btnCrear
            // 
            resources.ApplyResources(this.btnCrear, "btnCrear");
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.ThemeName = "MedicalAppTheme";
            this.btnCrear.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tbTitular
            // 
            resources.ApplyResources(this.tbTitular, "tbTitular");
            this.tbTitular.Name = "tbTitular";
            // 
            // tbNroTarjeta
            // 
            resources.ApplyResources(this.tbNroTarjeta, "tbNroTarjeta");
            this.tbNroTarjeta.Name = "tbNroTarjeta";
            this.tbNroTarjeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNroTarjeta_KeyPress);
            // 
            // radLabel1
            // 
            resources.ApplyResources(this.radLabel1, "radLabel1");
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.ThemeName = "MedicalAppTheme";
            // 
            // radLabel3
            // 
            resources.ApplyResources(this.radLabel3, "radLabel3");
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.ThemeName = "MedicalAppTheme";
            // 
            // tbFechaVto
            // 
            resources.ApplyResources(this.tbFechaVto, "tbFechaVto");
            this.tbFechaVto.Name = "tbFechaVto";
            // 
            // tbNombreTarjeta
            // 
            resources.ApplyResources(this.tbNombreTarjeta, "tbNombreTarjeta");
            this.tbNombreTarjeta.Name = "tbNombreTarjeta";
            // 
            // radLabel4
            // 
            resources.ApplyResources(this.radLabel4, "radLabel4");
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.ThemeName = "MedicalAppTheme";
            // 
            // AgregarFactura
            // 
            this.AcceptButton = this.btnCrear;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            this.CancelButton = this.btnCancelar;
            this.Controls.Add(this.tbNombreTarjeta);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.tbFechaVto);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.tbNroTarjeta);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.tbTitular);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCrear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AgregarFactura";
            ((System.ComponentModel.ISupportInitialize)(this.lblNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCrear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadLabel lblNombre;
        private Telerik.WinControls.UI.RadTextBox tbDescripcion;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadButton btnCancelar;
        private Telerik.WinControls.UI.RadButton btnCrear;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.MaskedTextBox tbFechaVto;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private System.Windows.Forms.TextBox tbNroTarjeta;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private System.Windows.Forms.TextBox tbTitular;
        private System.Windows.Forms.TextBox tbNombreTarjeta;
        private Telerik.WinControls.UI.RadLabel radLabel4;
    }
}
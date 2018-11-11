using Consultorio.Modelo;

namespace Consultorio
{
    partial class EditarTurnoAdmin
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
            this.cancelButton = new Telerik.WinControls.UI.RadButton();
            this.saveButton = new Telerik.WinControls.UI.RadButton();
            this.tbDescripcion = new Telerik.WinControls.UI.RadTextBoxControl();
            this.dtpFechaTurno = new Telerik.WinControls.UI.RadDateTimePicker();
            this.labelDescripcion = new Telerik.WinControls.UI.RadLabel();
            this.labelMedico = new Telerik.WinControls.UI.RadLabel();
            this.labelHoainicio = new Telerik.WinControls.UI.RadLabel();
            this.labelPaciente = new Telerik.WinControls.UI.RadLabel();
            this.dropDownListaPacientes = new Telerik.WinControls.UI.RadDropDownList();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblFormaDePago = new System.Windows.Forms.Label();
            this.object_d4872a5e_5580_4e52_9a69_393cd3f69363 = new Telerik.WinControls.RootRadElement();
            this.lblSeguroMedico = new System.Windows.Forms.Label();
            this.dropDownSegurosMedicos = new Telerik.WinControls.UI.RadDropDownList();
            this.radiobtnParticular = new Telerik.WinControls.UI.RadRadioButton();
            this.radioBtnSeguroMedico = new Telerik.WinControls.UI.RadRadioButton();
            this.textboxDiagnostico = new Telerik.WinControls.UI.RadTextBoxControl();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.dropDownHoraTurno = new Telerik.WinControls.UI.RadDropDownList();
            this.dropDownEspecialidades = new Telerik.WinControls.UI.RadDropDownList();
            this.label1 = new System.Windows.Forms.Label();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.tbPrecioTurno = new Telerik.WinControls.UI.RadTextBox();
            this.chbAtendido = new System.Windows.Forms.CheckBox();
            this.chbAsistio = new System.Windows.Forms.CheckBox();
            this.medicoVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DomingoHorario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SabadoHorario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viernesHorarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.juevesHorarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miercolesHorarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.martesHorarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lunesHorarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCompletoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMedicos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaTurno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelMedico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelHoainicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelPaciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownListaPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownSegurosMedicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiobtnParticular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioBtnSeguroMedico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textboxDiagnostico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownHoraTurno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownEspecialidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPrecioTurno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoVMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cancelButton.Location = new System.Drawing.Point(139, 311);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(97, 33);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.ThemeName = "MedicalAppTheme";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.saveButton.Location = new System.Drawing.Point(12, 311);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(97, 33);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Guardar";
            this.saveButton.ThemeName = "MedicalAppTheme";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescripcion.Location = new System.Drawing.Point(273, 240);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(252, 104);
            this.tbDescripcion.TabIndex = 8;
            this.tbDescripcion.ThemeName = "MedicalAppTheme";
            // 
            // dtpFechaTurno
            // 
            this.dtpFechaTurno.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaTurno.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaTurno.Location = new System.Drawing.Point(12, 72);
            this.dtpFechaTurno.Name = "dtpFechaTurno";
            this.dtpFechaTurno.Size = new System.Drawing.Size(117, 19);
            this.dtpFechaTurno.TabIndex = 2;
            this.dtpFechaTurno.TabStop = false;
            this.dtpFechaTurno.Text = "17/06/2018";
            this.dtpFechaTurno.Value = new System.DateTime(2018, 6, 17, 0, 0, 0, 0);
            this.dtpFechaTurno.ValueChanged += new System.EventHandler(this.dateTimePickerTurno_ValueChanged);
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcion.Location = new System.Drawing.Point(273, 219);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(74, 17);
            this.labelDescripcion.TabIndex = 0;
            this.labelDescripcion.Text = "Descripción";
            this.labelDescripcion.ThemeName = "MedicalAppTheme";
            // 
            // labelMedico
            // 
            this.labelMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMedico.Location = new System.Drawing.Point(273, 12);
            this.labelMedico.Name = "labelMedico";
            this.labelMedico.Size = new System.Drawing.Size(119, 17);
            this.labelMedico.TabIndex = 0;
            this.labelMedico.Text = "Seleccionar Médico";
            this.labelMedico.ThemeName = "MedicalAppTheme";
            // 
            // labelHoainicio
            // 
            this.labelHoainicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoainicio.Location = new System.Drawing.Point(12, 53);
            this.labelHoainicio.Name = "labelHoainicio";
            this.labelHoainicio.Size = new System.Drawing.Size(140, 17);
            this.labelHoainicio.TabIndex = 0;
            this.labelHoainicio.Text = "Fecha y Hora del Turno";
            this.labelHoainicio.ThemeName = "MedicalAppTheme";
            // 
            // labelPaciente
            // 
            this.labelPaciente.BackColor = System.Drawing.Color.Transparent;
            this.labelPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaciente.Location = new System.Drawing.Point(12, 8);
            this.labelPaciente.Name = "labelPaciente";
            this.labelPaciente.Size = new System.Drawing.Size(57, 17);
            this.labelPaciente.TabIndex = 0;
            this.labelPaciente.Text = "Paciente";
            this.labelPaciente.ThemeName = "MedicalAppTheme";
            // 
            // dropDownListaPacientes
            // 
            this.dropDownListaPacientes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.dropDownListaPacientes.DisplayMember = "Apellidos";
            this.dropDownListaPacientes.EnableKineticScrolling = true;
            this.dropDownListaPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropDownListaPacientes.Location = new System.Drawing.Point(12, 29);
            this.dropDownListaPacientes.Name = "dropDownListaPacientes";
            this.dropDownListaPacientes.Size = new System.Drawing.Size(222, 19);
            this.dropDownListaPacientes.TabIndex = 1;
            this.dropDownListaPacientes.ThemeName = "MedicalAppTheme";
            this.dropDownListaPacientes.ValueMember = "IdPaciente";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // lblFormaDePago
            // 
            this.lblFormaDePago.AutoSize = true;
            this.lblFormaDePago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaDePago.Location = new System.Drawing.Point(12, 174);
            this.lblFormaDePago.Name = "lblFormaDePago";
            this.lblFormaDePago.Size = new System.Drawing.Size(105, 15);
            this.lblFormaDePago.TabIndex = 8;
            this.lblFormaDePago.Text = "Forma de Pago";
            // 
            // object_d4872a5e_5580_4e52_9a69_393cd3f69363
            // 
            this.object_d4872a5e_5580_4e52_9a69_393cd3f69363.Name = "object_d4872a5e_5580_4e52_9a69_393cd3f69363";
            this.object_d4872a5e_5580_4e52_9a69_393cd3f69363.StretchHorizontally = true;
            this.object_d4872a5e_5580_4e52_9a69_393cd3f69363.StretchVertically = true;
            // 
            // lblSeguroMedico
            // 
            this.lblSeguroMedico.AutoSize = true;
            this.lblSeguroMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeguroMedico.Location = new System.Drawing.Point(12, 221);
            this.lblSeguroMedico.Name = "lblSeguroMedico";
            this.lblSeguroMedico.Size = new System.Drawing.Size(104, 15);
            this.lblSeguroMedico.TabIndex = 9;
            this.lblSeguroMedico.Text = "Seguro Médico";
            // 
            // dropDownSegurosMedicos
            // 
            this.dropDownSegurosMedicos.DisplayMember = "Nombre";
            this.dropDownSegurosMedicos.Enabled = false;
            this.dropDownSegurosMedicos.EnableKineticScrolling = true;
            this.dropDownSegurosMedicos.Location = new System.Drawing.Point(12, 240);
            this.dropDownSegurosMedicos.Name = "dropDownSegurosMedicos";
            this.dropDownSegurosMedicos.Size = new System.Drawing.Size(224, 20);
            this.dropDownSegurosMedicos.SortStyle = Telerik.WinControls.Enumerations.SortStyle.Ascending;
            this.dropDownSegurosMedicos.TabIndex = 6;
            this.dropDownSegurosMedicos.ThemeName = "ControlDefault";
            this.dropDownSegurosMedicos.ValueMember = "IdSeguroMedico";
            // 
            // radiobtnParticular
            // 
            this.radiobtnParticular.CheckState = System.Windows.Forms.CheckState.Checked;
            this.radiobtnParticular.Location = new System.Drawing.Point(12, 194);
            this.radiobtnParticular.Name = "radiobtnParticular";
            this.radiobtnParticular.Size = new System.Drawing.Size(67, 18);
            this.radiobtnParticular.TabIndex = 4;
            this.radiobtnParticular.Text = "Particular";
            this.radiobtnParticular.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // radioBtnSeguroMedico
            // 
            this.radioBtnSeguroMedico.Location = new System.Drawing.Point(86, 193);
            this.radioBtnSeguroMedico.Name = "radioBtnSeguroMedico";
            this.radioBtnSeguroMedico.Size = new System.Drawing.Size(96, 18);
            this.radioBtnSeguroMedico.TabIndex = 5;
            this.radioBtnSeguroMedico.TabStop = false;
            this.radioBtnSeguroMedico.Text = "Seguro Médico";
            this.radioBtnSeguroMedico.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radioBtnSeguroMedico_ToggleStateChanged);
            // 
            // textboxDiagnostico
            // 
            this.textboxDiagnostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxDiagnostico.Location = new System.Drawing.Point(538, 240);
            this.textboxDiagnostico.Multiline = true;
            this.textboxDiagnostico.Name = "textboxDiagnostico";
            this.textboxDiagnostico.Size = new System.Drawing.Size(252, 104);
            this.textboxDiagnostico.TabIndex = 13;
            this.textboxDiagnostico.ThemeName = "MedicalAppTheme";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(538, 219);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(74, 17);
            this.radLabel1.TabIndex = 12;
            this.radLabel1.Text = "Diagnóstico";
            this.radLabel1.ThemeName = "MedicalAppTheme";
            // 
            // dropDownHoraTurno
            // 
            this.dropDownHoraTurno.DisplayMember = "-1";
            this.dropDownHoraTurno.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.dropDownHoraTurno.Location = new System.Drawing.Point(153, 72);
            this.dropDownHoraTurno.Name = "dropDownHoraTurno";
            this.dropDownHoraTurno.Size = new System.Drawing.Size(81, 20);
            this.dropDownHoraTurno.TabIndex = 14;
            this.dropDownHoraTurno.Text = "-";
            this.dropDownHoraTurno.ValueMember = "-1";
            // 
            // dropDownEspecialidades
            // 
            this.dropDownEspecialidades.DisplayMember = "Nombre";
            this.dropDownEspecialidades.EnableKineticScrolling = true;
            this.dropDownEspecialidades.Location = new System.Drawing.Point(12, 118);
            this.dropDownEspecialidades.Name = "dropDownEspecialidades";
            this.dropDownEspecialidades.Size = new System.Drawing.Size(224, 20);
            this.dropDownEspecialidades.SortStyle = Telerik.WinControls.Enumerations.SortStyle.Ascending;
            this.dropDownEspecialidades.TabIndex = 15;
            this.dropDownEspecialidades.ThemeName = "ControlDefault";
            this.dropDownEspecialidades.ValueMember = "IdSeguroMedico";
            this.dropDownEspecialidades.SelectedValueChanged += new System.EventHandler(this.dropDownEspecialidades_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Especialidad Médico";
            // 
            // radLabel2
            // 
            this.radLabel2.BackColor = System.Drawing.Color.Transparent;
            this.radLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(12, 144);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(84, 17);
            this.radLabel2.TabIndex = 17;
            this.radLabel2.Text = "Precio Turno:";
            this.radLabel2.ThemeName = "MedicalAppTheme";
            // 
            // tbPrecioTurno
            // 
            this.tbPrecioTurno.Location = new System.Drawing.Point(99, 143);
            this.tbPrecioTurno.Name = "tbPrecioTurno";
            this.tbPrecioTurno.Size = new System.Drawing.Size(83, 20);
            this.tbPrecioTurno.TabIndex = 18;
            this.tbPrecioTurno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.radTextBox1_KeyPress);
            // 
            // chbAtendido
            // 
            this.chbAtendido.AutoSize = true;
            this.chbAtendido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbAtendido.Location = new System.Drawing.Point(139, 267);
            this.chbAtendido.Name = "chbAtendido";
            this.chbAtendido.Size = new System.Drawing.Size(90, 19);
            this.chbAtendido.TabIndex = 22;
            this.chbAtendido.Text = "Atendido?";
            this.chbAtendido.UseVisualStyleBackColor = true;
            // 
            // chbAsistio
            // 
            this.chbAsistio.AutoSize = true;
            this.chbAsistio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbAsistio.Location = new System.Drawing.Point(12, 267);
            this.chbAsistio.Name = "chbAsistio";
            this.chbAsistio.Size = new System.Drawing.Size(76, 19);
            this.chbAsistio.TabIndex = 21;
            this.chbAsistio.Text = "Asistió?";
            this.chbAsistio.UseVisualStyleBackColor = true;
            // 
            // medicoVMBindingSource
            // 
            this.medicoVMBindingSource.DataSource = typeof(Consultorio.ViewModels.MedicoVM);
            // 
            // DomingoHorario
            // 
            this.DomingoHorario.DataPropertyName = "DomingoHorario";
            this.DomingoHorario.HeaderText = "Domingo";
            this.DomingoHorario.Name = "DomingoHorario";
            this.DomingoHorario.ReadOnly = true;
            this.DomingoHorario.Visible = false;
            this.DomingoHorario.Width = 65;
            // 
            // SabadoHorario
            // 
            this.SabadoHorario.DataPropertyName = "SabadoHorario";
            this.SabadoHorario.HeaderText = "Sábado";
            this.SabadoHorario.Name = "SabadoHorario";
            this.SabadoHorario.ReadOnly = true;
            this.SabadoHorario.Visible = false;
            this.SabadoHorario.Width = 60;
            // 
            // viernesHorarioDataGridViewTextBoxColumn
            // 
            this.viernesHorarioDataGridViewTextBoxColumn.DataPropertyName = "ViernesHorario";
            this.viernesHorarioDataGridViewTextBoxColumn.HeaderText = "Viernes";
            this.viernesHorarioDataGridViewTextBoxColumn.Name = "viernesHorarioDataGridViewTextBoxColumn";
            this.viernesHorarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.viernesHorarioDataGridViewTextBoxColumn.Width = 75;
            // 
            // juevesHorarioDataGridViewTextBoxColumn
            // 
            this.juevesHorarioDataGridViewTextBoxColumn.DataPropertyName = "JuevesHorario";
            this.juevesHorarioDataGridViewTextBoxColumn.HeaderText = "Jueves";
            this.juevesHorarioDataGridViewTextBoxColumn.Name = "juevesHorarioDataGridViewTextBoxColumn";
            this.juevesHorarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.juevesHorarioDataGridViewTextBoxColumn.Width = 75;
            // 
            // miercolesHorarioDataGridViewTextBoxColumn
            // 
            this.miercolesHorarioDataGridViewTextBoxColumn.DataPropertyName = "MiercolesHorario";
            this.miercolesHorarioDataGridViewTextBoxColumn.HeaderText = "Miércoles";
            this.miercolesHorarioDataGridViewTextBoxColumn.Name = "miercolesHorarioDataGridViewTextBoxColumn";
            this.miercolesHorarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.miercolesHorarioDataGridViewTextBoxColumn.Width = 75;
            // 
            // martesHorarioDataGridViewTextBoxColumn
            // 
            this.martesHorarioDataGridViewTextBoxColumn.DataPropertyName = "MartesHorario";
            this.martesHorarioDataGridViewTextBoxColumn.HeaderText = "Martes";
            this.martesHorarioDataGridViewTextBoxColumn.Name = "martesHorarioDataGridViewTextBoxColumn";
            this.martesHorarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.martesHorarioDataGridViewTextBoxColumn.Width = 75;
            // 
            // lunesHorarioDataGridViewTextBoxColumn
            // 
            this.lunesHorarioDataGridViewTextBoxColumn.DataPropertyName = "LunesHorario";
            this.lunesHorarioDataGridViewTextBoxColumn.HeaderText = "Lunes";
            this.lunesHorarioDataGridViewTextBoxColumn.Name = "lunesHorarioDataGridViewTextBoxColumn";
            this.lunesHorarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.lunesHorarioDataGridViewTextBoxColumn.Width = 75;
            // 
            // nombreCompletoDataGridViewTextBoxColumn
            // 
            this.nombreCompletoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreCompletoDataGridViewTextBoxColumn.DataPropertyName = "NombreCompleto";
            this.nombreCompletoDataGridViewTextBoxColumn.HeaderText = "Medico";
            this.nombreCompletoDataGridViewTextBoxColumn.Name = "nombreCompletoDataGridViewTextBoxColumn";
            this.nombreCompletoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // medicoIdDataGridViewTextBoxColumn
            // 
            this.medicoIdDataGridViewTextBoxColumn.DataPropertyName = "MedicoId";
            this.medicoIdDataGridViewTextBoxColumn.HeaderText = "MedicoId";
            this.medicoIdDataGridViewTextBoxColumn.Name = "medicoIdDataGridViewTextBoxColumn";
            this.medicoIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.medicoIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // dgvMedicos
            // 
            this.dgvMedicos.AllowUserToAddRows = false;
            this.dgvMedicos.AllowUserToDeleteRows = false;
            this.dgvMedicos.AutoGenerateColumns = false;
            this.dgvMedicos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvMedicos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMedicos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvMedicos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medicoIdDataGridViewTextBoxColumn,
            this.nombreCompletoDataGridViewTextBoxColumn,
            this.lunesHorarioDataGridViewTextBoxColumn,
            this.martesHorarioDataGridViewTextBoxColumn,
            this.miercolesHorarioDataGridViewTextBoxColumn,
            this.juevesHorarioDataGridViewTextBoxColumn,
            this.viernesHorarioDataGridViewTextBoxColumn,
            this.SabadoHorario,
            this.DomingoHorario});
            this.dgvMedicos.DataSource = this.medicoVMBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMedicos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMedicos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.dgvMedicos.Location = new System.Drawing.Point(273, 35);
            this.dgvMedicos.MultiSelect = false;
            this.dgvMedicos.Name = "dgvMedicos";
            this.dgvMedicos.ReadOnly = true;
            this.dgvMedicos.RowHeadersVisible = false;
            this.dgvMedicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicos.Size = new System.Drawing.Size(517, 176);
            this.dgvMedicos.TabIndex = 11;
            this.dgvMedicos.Click += new System.EventHandler(this.dgvMedicos_Click);
            // 
            // EditarTurnoAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(799, 356);
            this.Controls.Add(this.chbAtendido);
            this.Controls.Add(this.chbAsistio);
            this.Controls.Add(this.tbPrecioTurno);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.dropDownEspecialidades);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dropDownHoraTurno);
            this.Controls.Add(this.textboxDiagnostico);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.dgvMedicos);
            this.Controls.Add(this.radioBtnSeguroMedico);
            this.Controls.Add(this.radiobtnParticular);
            this.Controls.Add(this.dropDownSegurosMedicos);
            this.Controls.Add(this.lblSeguroMedico);
            this.Controls.Add(this.lblFormaDePago);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.dtpFechaTurno);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.labelMedico);
            this.Controls.Add(this.labelHoainicio);
            this.Controls.Add(this.labelPaciente);
            this.Controls.Add(this.dropDownListaPacientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditarTurnoAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Turno";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NuevoTurno_FormClosing);
            this.Load += new System.EventHandler(this.NuevoTurno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cancelButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaTurno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelMedico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelHoainicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelPaciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownListaPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownSegurosMedicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiobtnParticular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioBtnSeguroMedico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textboxDiagnostico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownHoraTurno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownEspecialidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPrecioTurno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoVMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton cancelButton;
        private Telerik.WinControls.UI.RadButton saveButton;
        private Telerik.WinControls.UI.RadTextBoxControl tbDescripcion;
        private Telerik.WinControls.UI.RadDateTimePicker dtpFechaTurno;
        private Telerik.WinControls.UI.RadLabel labelDescripcion;
        private Telerik.WinControls.UI.RadLabel labelMedico;
        private Telerik.WinControls.UI.RadLabel labelHoainicio;
        private Telerik.WinControls.UI.RadLabel labelPaciente;
        private Telerik.WinControls.UI.RadDropDownList dropDownListaPacientes;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label lblFormaDePago;
        private Telerik.WinControls.RootRadElement object_d4872a5e_5580_4e52_9a69_393cd3f69363;
        private Telerik.WinControls.UI.RadDropDownList dropDownSegurosMedicos;
        private System.Windows.Forms.Label lblSeguroMedico;
        private Telerik.WinControls.UI.RadRadioButton radioBtnSeguroMedico;
        private Telerik.WinControls.UI.RadRadioButton radiobtnParticular;
        private System.Windows.Forms.BindingSource medicoVMBindingSource;
        private Telerik.WinControls.UI.RadTextBoxControl textboxDiagnostico;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadDropDownList dropDownHoraTurno;
        private Telerik.WinControls.UI.RadDropDownList dropDownEspecialidades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialidadDataGridViewTextBoxColumn;
        private Telerik.WinControls.UI.RadTextBox tbPrecioTurno;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private System.Windows.Forms.CheckBox chbAtendido;
        private System.Windows.Forms.CheckBox chbAsistio;
        private System.Windows.Forms.DataGridView dgvMedicos;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCompletoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lunesHorarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn martesHorarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miercolesHorarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn juevesHorarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn viernesHorarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SabadoHorario;
        private System.Windows.Forms.DataGridViewTextBoxColumn DomingoHorario;
    }
}
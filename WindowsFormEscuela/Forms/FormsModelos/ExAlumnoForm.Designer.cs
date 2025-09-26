namespace WindowsFormEscuela
{
    partial class ExAlumnoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExAlumnoForm));
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.edadLabel = new System.Windows.Forms.Label();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.promedioLabel = new System.Windows.Forms.Label();
            this.chkCursando = new System.Windows.Forms.CheckBox();
            this.carreraLabel = new System.Windows.Forms.Label();
            this.exAlumnoDGV = new System.Windows.Forms.DataGridView();
            this.añadirBtn = new System.Windows.Forms.Button();
            this.buscarBtn = new System.Windows.Forms.Button();
            this.editarBtn = new System.Windows.Forms.Button();
            this.eliminarBtn = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.retrocederBtn = new System.Windows.Forms.Button();
            this.limpiarBtn = new System.Windows.Forms.Button();
            this.guardarBtn = new System.Windows.Forms.Button();
            this.groupBoxCRUD = new System.Windows.Forms.GroupBox();
            this.groupBoxBuscar = new System.Windows.Forms.GroupBox();
            this.txtNombreBuscar = new System.Windows.Forms.TextBox();
            this.nombreBLabel = new System.Windows.Forms.Label();
            this.edadBLabel = new System.Windows.Forms.Label();
            this.carreraBLabel = new System.Windows.Forms.Label();
            this.chkCursandoBuscar = new System.Windows.Forms.CheckBox();
            this.txtEdadBuscar = new System.Windows.Forms.TextBox();
            this.promedioBLabel = new System.Windows.Forms.Label();
            this.txtCarreraBuscar = new System.Windows.Forms.TextBox();
            this.txtPromedioBuscar = new System.Windows.Forms.TextBox();
            this.habilitarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.exAlumnoDGV)).BeginInit();
            this.groupBoxCRUD.SuspendLayout();
            this.groupBoxBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEdad
            // 
            this.txtEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.Location = new System.Drawing.Point(26, 77);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(200, 21);
            this.txtEdad.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(26, 37);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 21);
            this.txtNombre.TabIndex = 8;
            // 
            // edadLabel
            // 
            this.edadLabel.AutoSize = true;
            this.edadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edadLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.edadLabel.Location = new System.Drawing.Point(23, 60);
            this.edadLabel.Name = "edadLabel";
            this.edadLabel.Size = new System.Drawing.Size(44, 15);
            this.edadLabel.TabIndex = 7;
            this.edadLabel.Text = "Edad:";
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nombreLabel.Location = new System.Drawing.Point(23, 20);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(62, 15);
            this.nombreLabel.TabIndex = 6;
            this.nombreLabel.Text = "Nombre:";
            // 
            // txtPromedio
            // 
            this.txtPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPromedio.Location = new System.Drawing.Point(248, 37);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(199, 21);
            this.txtPromedio.TabIndex = 25;
            // 
            // txtCarrera
            // 
            this.txtCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarrera.Location = new System.Drawing.Point(248, 77);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(199, 21);
            this.txtCarrera.TabIndex = 24;
            // 
            // promedioLabel
            // 
            this.promedioLabel.AutoSize = true;
            this.promedioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promedioLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.promedioLabel.Location = new System.Drawing.Point(245, 20);
            this.promedioLabel.Name = "promedioLabel";
            this.promedioLabel.Size = new System.Drawing.Size(73, 15);
            this.promedioLabel.TabIndex = 23;
            this.promedioLabel.Text = "Promedio:";
            // 
            // chkCursando
            // 
            this.chkCursando.AutoSize = true;
            this.chkCursando.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCursando.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkCursando.Location = new System.Drawing.Point(194, 107);
            this.chkCursando.Name = "chkCursando";
            this.chkCursando.Size = new System.Drawing.Size(87, 19);
            this.chkCursando.TabIndex = 22;
            this.chkCursando.Text = "Cursando";
            this.chkCursando.UseVisualStyleBackColor = true;
            // 
            // carreraLabel
            // 
            this.carreraLabel.AutoSize = true;
            this.carreraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carreraLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.carreraLabel.Location = new System.Drawing.Point(245, 60);
            this.carreraLabel.Name = "carreraLabel";
            this.carreraLabel.Size = new System.Drawing.Size(59, 15);
            this.carreraLabel.TabIndex = 21;
            this.carreraLabel.Text = "Carrera:";
            // 
            // exAlumnoDGV
            // 
            this.exAlumnoDGV.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.exAlumnoDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.exAlumnoDGV.Location = new System.Drawing.Point(30, 221);
            this.exAlumnoDGV.Name = "exAlumnoDGV";
            this.exAlumnoDGV.Size = new System.Drawing.Size(952, 300);
            this.exAlumnoDGV.TabIndex = 26;
            this.exAlumnoDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.exAlumnoDGV_CellClick);
            // 
            // añadirBtn
            // 
            this.añadirBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.añadirBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.añadirBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.añadirBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.añadirBtn.Location = new System.Drawing.Point(115, 139);
            this.añadirBtn.Name = "añadirBtn";
            this.añadirBtn.Size = new System.Drawing.Size(75, 23);
            this.añadirBtn.TabIndex = 27;
            this.añadirBtn.Text = "AÑADIR";
            this.añadirBtn.UseVisualStyleBackColor = false;
            this.añadirBtn.Click += new System.EventHandler(this.añadirBtn_Click);
            // 
            // buscarBtn
            // 
            this.buscarBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buscarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarBtn.Location = new System.Drawing.Point(123, 139);
            this.buscarBtn.Name = "buscarBtn";
            this.buscarBtn.Size = new System.Drawing.Size(75, 23);
            this.buscarBtn.TabIndex = 28;
            this.buscarBtn.Text = "BUSCAR";
            this.buscarBtn.UseVisualStyleBackColor = false;
            this.buscarBtn.Click += new System.EventHandler(this.buscarBtn_Click);
            // 
            // editarBtn
            // 
            this.editarBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.editarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarBtn.Location = new System.Drawing.Point(196, 139);
            this.editarBtn.Name = "editarBtn";
            this.editarBtn.Size = new System.Drawing.Size(75, 23);
            this.editarBtn.TabIndex = 29;
            this.editarBtn.Text = "EDITAR";
            this.editarBtn.UseVisualStyleBackColor = false;
            this.editarBtn.Click += new System.EventHandler(this.editarBtn_Click);
            // 
            // eliminarBtn
            // 
            this.eliminarBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.eliminarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eliminarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarBtn.Location = new System.Drawing.Point(277, 139);
            this.eliminarBtn.Name = "eliminarBtn";
            this.eliminarBtn.Size = new System.Drawing.Size(75, 23);
            this.eliminarBtn.TabIndex = 30;
            this.eliminarBtn.Text = "BORRAR";
            this.eliminarBtn.UseVisualStyleBackColor = false;
            this.eliminarBtn.Click += new System.EventHandler(this.eliminarBtn_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(38, 197);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 16);
            this.errorLabel.TabIndex = 31;
            // 
            // retrocederBtn
            // 
            this.retrocederBtn.BackColor = System.Drawing.Color.SlateBlue;
            this.retrocederBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retrocederBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.retrocederBtn.Location = new System.Drawing.Point(1, 4);
            this.retrocederBtn.Name = "retrocederBtn";
            this.retrocederBtn.Size = new System.Drawing.Size(34, 32);
            this.retrocederBtn.TabIndex = 32;
            this.retrocederBtn.Text = "←";
            this.retrocederBtn.UseVisualStyleBackColor = false;
            this.retrocederBtn.Click += new System.EventHandler(this.retrocederBtn_Click);
            // 
            // limpiarBtn
            // 
            this.limpiarBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.limpiarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.limpiarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiarBtn.Location = new System.Drawing.Point(358, 139);
            this.limpiarBtn.Name = "limpiarBtn";
            this.limpiarBtn.Size = new System.Drawing.Size(75, 23);
            this.limpiarBtn.TabIndex = 33;
            this.limpiarBtn.Text = "LIMPIAR";
            this.limpiarBtn.UseVisualStyleBackColor = false;
            this.limpiarBtn.Click += new System.EventHandler(this.limpiarBtn_Click);
            // 
            // guardarBtn
            // 
            this.guardarBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.guardarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guardarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarBtn.Location = new System.Drawing.Point(26, 139);
            this.guardarBtn.Name = "guardarBtn";
            this.guardarBtn.Size = new System.Drawing.Size(83, 23);
            this.guardarBtn.TabIndex = 34;
            this.guardarBtn.Text = "GUARDAR";
            this.guardarBtn.UseVisualStyleBackColor = false;
            this.guardarBtn.Click += new System.EventHandler(this.guardarBtn_Click);
            // 
            // groupBoxCRUD
            // 
            this.groupBoxCRUD.Controls.Add(this.txtNombre);
            this.groupBoxCRUD.Controls.Add(this.guardarBtn);
            this.groupBoxCRUD.Controls.Add(this.nombreLabel);
            this.groupBoxCRUD.Controls.Add(this.limpiarBtn);
            this.groupBoxCRUD.Controls.Add(this.edadLabel);
            this.groupBoxCRUD.Controls.Add(this.carreraLabel);
            this.groupBoxCRUD.Controls.Add(this.chkCursando);
            this.groupBoxCRUD.Controls.Add(this.eliminarBtn);
            this.groupBoxCRUD.Controls.Add(this.txtEdad);
            this.groupBoxCRUD.Controls.Add(this.editarBtn);
            this.groupBoxCRUD.Controls.Add(this.promedioLabel);
            this.groupBoxCRUD.Controls.Add(this.txtCarrera);
            this.groupBoxCRUD.Controls.Add(this.añadirBtn);
            this.groupBoxCRUD.Controls.Add(this.txtPromedio);
            this.groupBoxCRUD.Location = new System.Drawing.Point(41, 12);
            this.groupBoxCRUD.Name = "groupBoxCRUD";
            this.groupBoxCRUD.Size = new System.Drawing.Size(458, 178);
            this.groupBoxCRUD.TabIndex = 35;
            this.groupBoxCRUD.TabStop = false;
            // 
            // groupBoxBuscar
            // 
            this.groupBoxBuscar.Controls.Add(this.habilitarButton);
            this.groupBoxBuscar.Controls.Add(this.txtNombreBuscar);
            this.groupBoxBuscar.Controls.Add(this.nombreBLabel);
            this.groupBoxBuscar.Controls.Add(this.edadBLabel);
            this.groupBoxBuscar.Controls.Add(this.carreraBLabel);
            this.groupBoxBuscar.Controls.Add(this.buscarBtn);
            this.groupBoxBuscar.Controls.Add(this.chkCursandoBuscar);
            this.groupBoxBuscar.Controls.Add(this.txtEdadBuscar);
            this.groupBoxBuscar.Controls.Add(this.promedioBLabel);
            this.groupBoxBuscar.Controls.Add(this.txtCarreraBuscar);
            this.groupBoxBuscar.Controls.Add(this.txtPromedioBuscar);
            this.groupBoxBuscar.Location = new System.Drawing.Point(535, 12);
            this.groupBoxBuscar.Name = "groupBoxBuscar";
            this.groupBoxBuscar.Size = new System.Drawing.Size(458, 178);
            this.groupBoxBuscar.TabIndex = 36;
            this.groupBoxBuscar.TabStop = false;
            // 
            // txtNombreBuscar
            // 
            this.txtNombreBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreBuscar.Location = new System.Drawing.Point(26, 37);
            this.txtNombreBuscar.Name = "txtNombreBuscar";
            this.txtNombreBuscar.Size = new System.Drawing.Size(200, 21);
            this.txtNombreBuscar.TabIndex = 8;
            // 
            // nombreBLabel
            // 
            this.nombreBLabel.AutoSize = true;
            this.nombreBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreBLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nombreBLabel.Location = new System.Drawing.Point(23, 20);
            this.nombreBLabel.Name = "nombreBLabel";
            this.nombreBLabel.Size = new System.Drawing.Size(62, 15);
            this.nombreBLabel.TabIndex = 6;
            this.nombreBLabel.Text = "Nombre:";
            // 
            // edadBLabel
            // 
            this.edadBLabel.AutoSize = true;
            this.edadBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edadBLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.edadBLabel.Location = new System.Drawing.Point(23, 60);
            this.edadBLabel.Name = "edadBLabel";
            this.edadBLabel.Size = new System.Drawing.Size(44, 15);
            this.edadBLabel.TabIndex = 7;
            this.edadBLabel.Text = "Edad:";
            // 
            // carreraBLabel
            // 
            this.carreraBLabel.AutoSize = true;
            this.carreraBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carreraBLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.carreraBLabel.Location = new System.Drawing.Point(245, 60);
            this.carreraBLabel.Name = "carreraBLabel";
            this.carreraBLabel.Size = new System.Drawing.Size(59, 15);
            this.carreraBLabel.TabIndex = 21;
            this.carreraBLabel.Text = "Carrera:";
            // 
            // chkCursandoBuscar
            // 
            this.chkCursandoBuscar.AutoSize = true;
            this.chkCursandoBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCursandoBuscar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkCursandoBuscar.Location = new System.Drawing.Point(194, 107);
            this.chkCursandoBuscar.Name = "chkCursandoBuscar";
            this.chkCursandoBuscar.Size = new System.Drawing.Size(87, 19);
            this.chkCursandoBuscar.TabIndex = 22;
            this.chkCursandoBuscar.Text = "Cursando";
            this.chkCursandoBuscar.UseVisualStyleBackColor = true;
            // 
            // txtEdadBuscar
            // 
            this.txtEdadBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdadBuscar.Location = new System.Drawing.Point(26, 77);
            this.txtEdadBuscar.Name = "txtEdadBuscar";
            this.txtEdadBuscar.Size = new System.Drawing.Size(200, 21);
            this.txtEdadBuscar.TabIndex = 9;
            // 
            // promedioBLabel
            // 
            this.promedioBLabel.AutoSize = true;
            this.promedioBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promedioBLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.promedioBLabel.Location = new System.Drawing.Point(245, 20);
            this.promedioBLabel.Name = "promedioBLabel";
            this.promedioBLabel.Size = new System.Drawing.Size(73, 15);
            this.promedioBLabel.TabIndex = 23;
            this.promedioBLabel.Text = "Promedio:";
            // 
            // txtCarreraBuscar
            // 
            this.txtCarreraBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarreraBuscar.Location = new System.Drawing.Point(248, 77);
            this.txtCarreraBuscar.Name = "txtCarreraBuscar";
            this.txtCarreraBuscar.Size = new System.Drawing.Size(199, 21);
            this.txtCarreraBuscar.TabIndex = 24;
            // 
            // txtPromedioBuscar
            // 
            this.txtPromedioBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPromedioBuscar.Location = new System.Drawing.Point(248, 37);
            this.txtPromedioBuscar.Name = "txtPromedioBuscar";
            this.txtPromedioBuscar.Size = new System.Drawing.Size(199, 21);
            this.txtPromedioBuscar.TabIndex = 25;
            // 
            // habilitarButton
            // 
            this.habilitarButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.habilitarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.habilitarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.habilitarButton.Location = new System.Drawing.Point(26, 139);
            this.habilitarButton.Name = "habilitarButton";
            this.habilitarButton.Size = new System.Drawing.Size(91, 23);
            this.habilitarButton.TabIndex = 37;
            this.habilitarButton.Text = "HABILITAR";
            this.habilitarButton.UseVisualStyleBackColor = false;
            this.habilitarButton.Click += new System.EventHandler(this.habilitarButton_Click_1);
            // 
            // ExAlumnoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1001, 538);
            this.Controls.Add(this.groupBoxBuscar);
            this.Controls.Add(this.groupBoxCRUD);
            this.Controls.Add(this.retrocederBtn);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.exAlumnoDGV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExAlumnoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExAlumno";
            this.Load += new System.EventHandler(this.ExAlumnoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exAlumnoDGV)).EndInit();
            this.groupBoxCRUD.ResumeLayout(false);
            this.groupBoxCRUD.PerformLayout();
            this.groupBoxBuscar.ResumeLayout(false);
            this.groupBoxBuscar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label edadLabel;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.Label promedioLabel;
        private System.Windows.Forms.CheckBox chkCursando;
        private System.Windows.Forms.Label carreraLabel;
        private System.Windows.Forms.DataGridView exAlumnoDGV;
        private System.Windows.Forms.Button añadirBtn;
        private System.Windows.Forms.Button buscarBtn;
        private System.Windows.Forms.Button editarBtn;
        private System.Windows.Forms.Button eliminarBtn;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button retrocederBtn;
        private System.Windows.Forms.Button limpiarBtn;
        private System.Windows.Forms.Button guardarBtn;
        private System.Windows.Forms.GroupBox groupBoxCRUD;
        private System.Windows.Forms.GroupBox groupBoxBuscar;
        private System.Windows.Forms.TextBox txtNombreBuscar;
        private System.Windows.Forms.Label nombreBLabel;
        private System.Windows.Forms.Label edadBLabel;
        private System.Windows.Forms.Label carreraBLabel;
        private System.Windows.Forms.CheckBox chkCursandoBuscar;
        private System.Windows.Forms.TextBox txtEdadBuscar;
        private System.Windows.Forms.Label promedioBLabel;
        private System.Windows.Forms.TextBox txtCarreraBuscar;
        private System.Windows.Forms.TextBox txtPromedioBuscar;
        private System.Windows.Forms.Button habilitarButton;
    }
}
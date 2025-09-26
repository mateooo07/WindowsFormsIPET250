namespace WindowsFormEscuela
{
    partial class EstudianteForm
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
            this.errorLabel = new System.Windows.Forms.Label();
            this.guardarBtn = new System.Windows.Forms.Button();
            this.limpiarBtn = new System.Windows.Forms.Button();
            this.retrocederBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.eliminarBtn = new System.Windows.Forms.Button();
            this.editarBtn = new System.Windows.Forms.Button();
            this.buscarBtn = new System.Windows.Forms.Button();
            this.añadirBtn = new System.Windows.Forms.Button();
            this.exAlumnoDGV = new System.Windows.Forms.DataGridView();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.promedioLabel = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.chkCursando = new System.Windows.Forms.CheckBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.carreraLabel = new System.Windows.Forms.Label();
            this.edadLabel = new System.Windows.Forms.Label();
            this.nombreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.exAlumnoDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(39, 352);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 16);
            this.errorLabel.TabIndex = 47;
            // 
            // guardarBtn
            // 
            this.guardarBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.guardarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guardarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarBtn.Location = new System.Drawing.Point(590, 73);
            this.guardarBtn.Name = "guardarBtn";
            this.guardarBtn.Size = new System.Drawing.Size(83, 23);
            this.guardarBtn.TabIndex = 65;
            this.guardarBtn.Text = "GUARDAR";
            this.guardarBtn.UseVisualStyleBackColor = false;
            this.guardarBtn.Click += new System.EventHandler(this.guardarBtn_Click);
            // 
            // limpiarBtn
            // 
            this.limpiarBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.limpiarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.limpiarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiarBtn.Location = new System.Drawing.Point(509, 73);
            this.limpiarBtn.Name = "limpiarBtn";
            this.limpiarBtn.Size = new System.Drawing.Size(75, 23);
            this.limpiarBtn.TabIndex = 64;
            this.limpiarBtn.Text = "LIMPIAR";
            this.limpiarBtn.UseVisualStyleBackColor = false;
            // 
            // retrocederBtn
            // 
            this.retrocederBtn.BackColor = System.Drawing.Color.SlateBlue;
            this.retrocederBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retrocederBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.retrocederBtn.Location = new System.Drawing.Point(12, 6);
            this.retrocederBtn.Name = "retrocederBtn";
            this.retrocederBtn.Size = new System.Drawing.Size(34, 32);
            this.retrocederBtn.TabIndex = 63;
            this.retrocederBtn.Text = "←";
            this.retrocederBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(49, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 62;
            // 
            // eliminarBtn
            // 
            this.eliminarBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.eliminarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eliminarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarBtn.Location = new System.Drawing.Point(509, 44);
            this.eliminarBtn.Name = "eliminarBtn";
            this.eliminarBtn.Size = new System.Drawing.Size(75, 23);
            this.eliminarBtn.TabIndex = 61;
            this.eliminarBtn.Text = "BORRAR";
            this.eliminarBtn.UseVisualStyleBackColor = false;
            // 
            // editarBtn
            // 
            this.editarBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.editarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarBtn.Location = new System.Drawing.Point(590, 15);
            this.editarBtn.Name = "editarBtn";
            this.editarBtn.Size = new System.Drawing.Size(75, 23);
            this.editarBtn.TabIndex = 60;
            this.editarBtn.Text = "EDITAR";
            this.editarBtn.UseVisualStyleBackColor = false;
            // 
            // buscarBtn
            // 
            this.buscarBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buscarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarBtn.Location = new System.Drawing.Point(590, 44);
            this.buscarBtn.Name = "buscarBtn";
            this.buscarBtn.Size = new System.Drawing.Size(75, 23);
            this.buscarBtn.TabIndex = 59;
            this.buscarBtn.Text = "BUSCAR";
            this.buscarBtn.UseVisualStyleBackColor = false;
            // 
            // añadirBtn
            // 
            this.añadirBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.añadirBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.añadirBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.añadirBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.añadirBtn.Location = new System.Drawing.Point(509, 15);
            this.añadirBtn.Name = "añadirBtn";
            this.añadirBtn.Size = new System.Drawing.Size(75, 23);
            this.añadirBtn.TabIndex = 58;
            this.añadirBtn.Text = "AÑADIR";
            this.añadirBtn.UseVisualStyleBackColor = false;
            // 
            // exAlumnoDGV
            // 
            this.exAlumnoDGV.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.exAlumnoDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.exAlumnoDGV.Location = new System.Drawing.Point(52, 127);
            this.exAlumnoDGV.Name = "exAlumnoDGV";
            this.exAlumnoDGV.Size = new System.Drawing.Size(613, 208);
            this.exAlumnoDGV.TabIndex = 57;
            // 
            // txtPromedio
            // 
            this.txtPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPromedio.Location = new System.Drawing.Point(274, 32);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(199, 21);
            this.txtPromedio.TabIndex = 56;
            // 
            // txtCarrera
            // 
            this.txtCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarrera.Location = new System.Drawing.Point(274, 72);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(199, 21);
            this.txtCarrera.TabIndex = 55;
            // 
            // promedioLabel
            // 
            this.promedioLabel.AutoSize = true;
            this.promedioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promedioLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.promedioLabel.Location = new System.Drawing.Point(271, 15);
            this.promedioLabel.Name = "promedioLabel";
            this.promedioLabel.Size = new System.Drawing.Size(73, 15);
            this.promedioLabel.TabIndex = 54;
            this.promedioLabel.Text = "Promedio:";
            // 
            // txtEdad
            // 
            this.txtEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.Location = new System.Drawing.Point(52, 72);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(200, 21);
            this.txtEdad.TabIndex = 51;
            // 
            // chkCursando
            // 
            this.chkCursando.AutoSize = true;
            this.chkCursando.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCursando.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkCursando.Location = new System.Drawing.Point(220, 102);
            this.chkCursando.Name = "chkCursando";
            this.chkCursando.Size = new System.Drawing.Size(87, 19);
            this.chkCursando.TabIndex = 53;
            this.chkCursando.Text = "Cursando";
            this.chkCursando.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(52, 32);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 21);
            this.txtNombre.TabIndex = 50;
            // 
            // carreraLabel
            // 
            this.carreraLabel.AutoSize = true;
            this.carreraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carreraLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.carreraLabel.Location = new System.Drawing.Point(271, 55);
            this.carreraLabel.Name = "carreraLabel";
            this.carreraLabel.Size = new System.Drawing.Size(59, 15);
            this.carreraLabel.TabIndex = 52;
            this.carreraLabel.Text = "Carrera:";
            // 
            // edadLabel
            // 
            this.edadLabel.AutoSize = true;
            this.edadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edadLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.edadLabel.Location = new System.Drawing.Point(49, 55);
            this.edadLabel.Name = "edadLabel";
            this.edadLabel.Size = new System.Drawing.Size(44, 15);
            this.edadLabel.TabIndex = 49;
            this.edadLabel.Text = "Edad:";
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nombreLabel.Location = new System.Drawing.Point(49, 15);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(62, 15);
            this.nombreLabel.TabIndex = 48;
            this.nombreLabel.Text = "Nombre:";
            // 
            // EstudianteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(674, 375);
            this.Controls.Add(this.guardarBtn);
            this.Controls.Add(this.limpiarBtn);
            this.Controls.Add(this.retrocederBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eliminarBtn);
            this.Controls.Add(this.editarBtn);
            this.Controls.Add(this.buscarBtn);
            this.Controls.Add(this.añadirBtn);
            this.Controls.Add(this.exAlumnoDGV);
            this.Controls.Add(this.txtPromedio);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.promedioLabel);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.chkCursando);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.carreraLabel);
            this.Controls.Add(this.edadLabel);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.errorLabel);
            this.Name = "EstudianteForm";
            this.Text = "AlumnoForm";
            this.Load += new System.EventHandler(this.EstudianteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exAlumnoDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button guardarBtn;
        private System.Windows.Forms.Button limpiarBtn;
        private System.Windows.Forms.Button retrocederBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button eliminarBtn;
        private System.Windows.Forms.Button editarBtn;
        private System.Windows.Forms.Button buscarBtn;
        private System.Windows.Forms.Button añadirBtn;
        private System.Windows.Forms.DataGridView exAlumnoDGV;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.Label promedioLabel;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.CheckBox chkCursando;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label carreraLabel;
        private System.Windows.Forms.Label edadLabel;
        private System.Windows.Forms.Label nombreLabel;
    }
}
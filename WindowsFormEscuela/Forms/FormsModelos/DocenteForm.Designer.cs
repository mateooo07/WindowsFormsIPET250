namespace WindowsFormEscuela
{
    partial class DocenteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocenteForm));
            this.groupBoxBuscar = new System.Windows.Forms.GroupBox();
            this.habilitarButton = new System.Windows.Forms.Button();
            this.txtNombreBuscar = new System.Windows.Forms.TextBox();
            this.nombreBLabel = new System.Windows.Forms.Label();
            this.edadBLabel = new System.Windows.Forms.Label();
            this.carreraBLabel = new System.Windows.Forms.Label();
            this.buscarBtn = new System.Windows.Forms.Button();
            this.txtEdadBuscar = new System.Windows.Forms.TextBox();
            this.promedioBLabel = new System.Windows.Forms.Label();
            this.txtCarreraBuscar = new System.Windows.Forms.TextBox();
            this.txtPromedioBuscar = new System.Windows.Forms.TextBox();
            this.groupBoxCRUD = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.guardarBtn = new System.Windows.Forms.Button();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.limpiarBtn = new System.Windows.Forms.Button();
            this.edadLabel = new System.Windows.Forms.Label();
            this.carreraLabel = new System.Windows.Forms.Label();
            this.eliminarBtn = new System.Windows.Forms.Button();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.editarBtn = new System.Windows.Forms.Button();
            this.puestoLabel = new System.Windows.Forms.Label();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.añadirBtn = new System.Windows.Forms.Button();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.retrocederBtn = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.exAlumnoDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBoxBuscar.SuspendLayout();
            this.groupBoxCRUD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exAlumnoDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxBuscar
            // 
            this.groupBoxBuscar.Controls.Add(this.label2);
            this.groupBoxBuscar.Controls.Add(this.textBox2);
            this.groupBoxBuscar.Controls.Add(this.habilitarButton);
            this.groupBoxBuscar.Controls.Add(this.txtNombreBuscar);
            this.groupBoxBuscar.Controls.Add(this.nombreBLabel);
            this.groupBoxBuscar.Controls.Add(this.edadBLabel);
            this.groupBoxBuscar.Controls.Add(this.carreraBLabel);
            this.groupBoxBuscar.Controls.Add(this.buscarBtn);
            this.groupBoxBuscar.Controls.Add(this.txtEdadBuscar);
            this.groupBoxBuscar.Controls.Add(this.promedioBLabel);
            this.groupBoxBuscar.Controls.Add(this.txtCarreraBuscar);
            this.groupBoxBuscar.Controls.Add(this.txtPromedioBuscar);
            this.groupBoxBuscar.Location = new System.Drawing.Point(537, 13);
            this.groupBoxBuscar.Name = "groupBoxBuscar";
            this.groupBoxBuscar.Size = new System.Drawing.Size(458, 178);
            this.groupBoxBuscar.TabIndex = 41;
            this.groupBoxBuscar.TabStop = false;
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
            this.carreraBLabel.Size = new System.Drawing.Size(83, 15);
            this.carreraBLabel.TabIndex = 21;
            this.carreraBLabel.Text = "Antiguedad:";
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
            this.promedioBLabel.Size = new System.Drawing.Size(55, 15);
            this.promedioBLabel.TabIndex = 23;
            this.promedioBLabel.Text = "Puesto:";
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
            // groupBoxCRUD
            // 
            this.groupBoxCRUD.Controls.Add(this.label1);
            this.groupBoxCRUD.Controls.Add(this.textBox1);
            this.groupBoxCRUD.Controls.Add(this.txtNombre);
            this.groupBoxCRUD.Controls.Add(this.guardarBtn);
            this.groupBoxCRUD.Controls.Add(this.nombreLabel);
            this.groupBoxCRUD.Controls.Add(this.limpiarBtn);
            this.groupBoxCRUD.Controls.Add(this.edadLabel);
            this.groupBoxCRUD.Controls.Add(this.carreraLabel);
            this.groupBoxCRUD.Controls.Add(this.eliminarBtn);
            this.groupBoxCRUD.Controls.Add(this.txtEdad);
            this.groupBoxCRUD.Controls.Add(this.editarBtn);
            this.groupBoxCRUD.Controls.Add(this.puestoLabel);
            this.groupBoxCRUD.Controls.Add(this.txtCarrera);
            this.groupBoxCRUD.Controls.Add(this.añadirBtn);
            this.groupBoxCRUD.Controls.Add(this.txtPromedio);
            this.groupBoxCRUD.Location = new System.Drawing.Point(43, 13);
            this.groupBoxCRUD.Name = "groupBoxCRUD";
            this.groupBoxCRUD.Size = new System.Drawing.Size(458, 178);
            this.groupBoxCRUD.TabIndex = 40;
            this.groupBoxCRUD.TabStop = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(26, 37);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 21);
            this.txtNombre.TabIndex = 8;
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
            // carreraLabel
            // 
            this.carreraLabel.AutoSize = true;
            this.carreraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carreraLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.carreraLabel.Location = new System.Drawing.Point(245, 59);
            this.carreraLabel.Name = "carreraLabel";
            this.carreraLabel.Size = new System.Drawing.Size(83, 15);
            this.carreraLabel.TabIndex = 21;
            this.carreraLabel.Text = "Antiguedad:";
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
            // 
            // txtEdad
            // 
            this.txtEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.Location = new System.Drawing.Point(26, 77);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(200, 21);
            this.txtEdad.TabIndex = 9;
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
            // 
            // puestoLabel
            // 
            this.puestoLabel.AutoSize = true;
            this.puestoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puestoLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.puestoLabel.Location = new System.Drawing.Point(245, 20);
            this.puestoLabel.Name = "puestoLabel";
            this.puestoLabel.Size = new System.Drawing.Size(55, 15);
            this.puestoLabel.TabIndex = 23;
            this.puestoLabel.Text = "Puesto:";
            // 
            // txtCarrera
            // 
            this.txtCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarrera.Location = new System.Drawing.Point(248, 77);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(199, 21);
            this.txtCarrera.TabIndex = 24;
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
            // 
            // txtPromedio
            // 
            this.txtPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPromedio.Location = new System.Drawing.Point(248, 37);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(199, 21);
            this.txtPromedio.TabIndex = 25;
            // 
            // retrocederBtn
            // 
            this.retrocederBtn.BackColor = System.Drawing.Color.SlateBlue;
            this.retrocederBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retrocederBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.retrocederBtn.Location = new System.Drawing.Point(3, 5);
            this.retrocederBtn.Name = "retrocederBtn";
            this.retrocederBtn.Size = new System.Drawing.Size(34, 32);
            this.retrocederBtn.TabIndex = 39;
            this.retrocederBtn.Text = "←";
            this.retrocederBtn.UseVisualStyleBackColor = false;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(40, 198);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 16);
            this.errorLabel.TabIndex = 38;
            // 
            // exAlumnoDGV
            // 
            this.exAlumnoDGV.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.exAlumnoDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.exAlumnoDGV.Location = new System.Drawing.Point(32, 222);
            this.exAlumnoDGV.Name = "exAlumnoDGV";
            this.exAlumnoDGV.Size = new System.Drawing.Size(952, 300);
            this.exAlumnoDGV.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(23, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 35;
            this.label1.Text = "Salario:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(86, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 21);
            this.textBox1.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(25, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 38;
            this.label2.Text = "Salario:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(88, 108);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 21);
            this.textBox2.TabIndex = 39;
            // 
            // DocenteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(999, 526);
            this.Controls.Add(this.groupBoxBuscar);
            this.Controls.Add(this.groupBoxCRUD);
            this.Controls.Add(this.retrocederBtn);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.exAlumnoDGV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DocenteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DocenteForm";
            this.groupBoxBuscar.ResumeLayout(false);
            this.groupBoxBuscar.PerformLayout();
            this.groupBoxCRUD.ResumeLayout(false);
            this.groupBoxCRUD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exAlumnoDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxBuscar;
        private System.Windows.Forms.Button habilitarButton;
        private System.Windows.Forms.TextBox txtNombreBuscar;
        private System.Windows.Forms.Label nombreBLabel;
        private System.Windows.Forms.Label edadBLabel;
        private System.Windows.Forms.Label carreraBLabel;
        private System.Windows.Forms.Button buscarBtn;
        private System.Windows.Forms.TextBox txtEdadBuscar;
        private System.Windows.Forms.Label promedioBLabel;
        private System.Windows.Forms.TextBox txtCarreraBuscar;
        private System.Windows.Forms.TextBox txtPromedioBuscar;
        private System.Windows.Forms.GroupBox groupBoxCRUD;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button guardarBtn;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Button limpiarBtn;
        private System.Windows.Forms.Label edadLabel;
        private System.Windows.Forms.Label carreraLabel;
        private System.Windows.Forms.Button eliminarBtn;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Button editarBtn;
        private System.Windows.Forms.Label puestoLabel;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.Button añadirBtn;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.Button retrocederBtn;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.DataGridView exAlumnoDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
    }
}
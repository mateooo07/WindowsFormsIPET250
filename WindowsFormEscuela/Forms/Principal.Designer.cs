namespace WindowsFormEscuela
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.SeleccionarLabel = new System.Windows.Forms.Label();
            this.estudianteBtn = new System.Windows.Forms.Button();
            this.exAlumnoBtn = new System.Windows.Forms.Button();
            this.docenteBtn = new System.Windows.Forms.Button();
            this.noDocenteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SeleccionarLabel
            // 
            this.SeleccionarLabel.AutoSize = true;
            this.SeleccionarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeleccionarLabel.Location = new System.Drawing.Point(12, 30);
            this.SeleccionarLabel.Name = "SeleccionarLabel";
            this.SeleccionarLabel.Size = new System.Drawing.Size(405, 16);
            this.SeleccionarLabel.TabIndex = 0;
            this.SeleccionarLabel.Text = "Seleccione lo que desea editar, buscar, borrar o agregar:";
            // 
            // estudianteBtn
            // 
            this.estudianteBtn.BackColor = System.Drawing.Color.Violet;
            this.estudianteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.estudianteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estudianteBtn.Location = new System.Drawing.Point(3, 60);
            this.estudianteBtn.Name = "estudianteBtn";
            this.estudianteBtn.Size = new System.Drawing.Size(102, 23);
            this.estudianteBtn.TabIndex = 1;
            this.estudianteBtn.Text = "ESTUDIANTE";
            this.estudianteBtn.UseVisualStyleBackColor = false;
            this.estudianteBtn.Click += new System.EventHandler(this.estudianteBtn_Click);
            // 
            // exAlumnoBtn
            // 
            this.exAlumnoBtn.BackColor = System.Drawing.Color.Violet;
            this.exAlumnoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exAlumnoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exAlumnoBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exAlumnoBtn.Location = new System.Drawing.Point(111, 60);
            this.exAlumnoBtn.Name = "exAlumnoBtn";
            this.exAlumnoBtn.Size = new System.Drawing.Size(105, 23);
            this.exAlumnoBtn.TabIndex = 2;
            this.exAlumnoBtn.Text = "EX-ALUMNO";
            this.exAlumnoBtn.UseVisualStyleBackColor = false;
            this.exAlumnoBtn.Click += new System.EventHandler(this.exAlumnoBtn_Click);
            // 
            // docenteBtn
            // 
            this.docenteBtn.BackColor = System.Drawing.Color.Violet;
            this.docenteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.docenteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docenteBtn.Location = new System.Drawing.Point(222, 60);
            this.docenteBtn.Name = "docenteBtn";
            this.docenteBtn.Size = new System.Drawing.Size(90, 23);
            this.docenteBtn.TabIndex = 3;
            this.docenteBtn.Text = "DOCENTE";
            this.docenteBtn.UseVisualStyleBackColor = false;
            this.docenteBtn.Click += new System.EventHandler(this.docenteBtn_Click);
            // 
            // noDocenteBtn
            // 
            this.noDocenteBtn.BackColor = System.Drawing.Color.Violet;
            this.noDocenteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.noDocenteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noDocenteBtn.Location = new System.Drawing.Point(318, 60);
            this.noDocenteBtn.Name = "noDocenteBtn";
            this.noDocenteBtn.Size = new System.Drawing.Size(108, 23);
            this.noDocenteBtn.TabIndex = 4;
            this.noDocenteBtn.Text = "NO DOCENTE";
            this.noDocenteBtn.UseVisualStyleBackColor = false;
            this.noDocenteBtn.Click += new System.EventHandler(this.noDocenteBtn_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(427, 103);
            this.Controls.Add(this.noDocenteBtn);
            this.Controls.Add(this.docenteBtn);
            this.Controls.Add(this.exAlumnoBtn);
            this.Controls.Add(this.estudianteBtn);
            this.Controls.Add(this.SeleccionarLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SeleccionarLabel;
        private System.Windows.Forms.Button estudianteBtn;
        private System.Windows.Forms.Button exAlumnoBtn;
        private System.Windows.Forms.Button docenteBtn;
        private System.Windows.Forms.Button noDocenteBtn;
    }
}
namespace WindowsFormEscuela
{
    partial class AlumnoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlumnoForm));
            this.groupBoxBuscar = new System.Windows.Forms.GroupBox();
            this.materiaBLabel = new System.Windows.Forms.Label();
            this.notaBLabel = new System.Windows.Forms.Label();
            this.txtMateriaBuscar = new System.Windows.Forms.TextBox();
            this.txtNotaBuscar = new System.Windows.Forms.TextBox();
            this.habilitarButton = new System.Windows.Forms.Button();
            this.txtNombreBuscar = new System.Windows.Forms.TextBox();
            this.nombreBLabel = new System.Windows.Forms.Label();
            this.edadBLabel = new System.Windows.Forms.Label();
            this.carreraBLabel = new System.Windows.Forms.Label();
            this.buscarBtn = new System.Windows.Forms.Button();
            this.chkCursandoBuscar = new System.Windows.Forms.CheckBox();
            this.txtEdadBuscar = new System.Windows.Forms.TextBox();
            this.añoBLabel = new System.Windows.Forms.Label();
            this.txtCarreraBuscar = new System.Windows.Forms.TextBox();
            this.txtAñoBuscar = new System.Windows.Forms.TextBox();
            this.groupBoxCRUD = new System.Windows.Forms.GroupBox();
            this.materiaLabel = new System.Windows.Forms.Label();
            this.notaLabel = new System.Windows.Forms.Label();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.guardarBtn = new System.Windows.Forms.Button();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.limpiarBtn = new System.Windows.Forms.Button();
            this.edadLabel = new System.Windows.Forms.Label();
            this.carreraLabel = new System.Windows.Forms.Label();
            this.chkCursando = new System.Windows.Forms.CheckBox();
            this.eliminarBtn = new System.Windows.Forms.Button();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.editarBtn = new System.Windows.Forms.Button();
            this.añoLabel = new System.Windows.Forms.Label();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.añadirBtn = new System.Windows.Forms.Button();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.retrocederBtn = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.alumnoDGV = new System.Windows.Forms.DataGridView();
            this.groupBoxBuscar.SuspendLayout();
            this.groupBoxCRUD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxBuscar
            // 
            this.groupBoxBuscar.Controls.Add(this.materiaBLabel);
            this.groupBoxBuscar.Controls.Add(this.notaBLabel);
            this.groupBoxBuscar.Controls.Add(this.txtMateriaBuscar);
            this.groupBoxBuscar.Controls.Add(this.txtNotaBuscar);
            this.groupBoxBuscar.Controls.Add(this.habilitarButton);
            this.groupBoxBuscar.Controls.Add(this.txtNombreBuscar);
            this.groupBoxBuscar.Controls.Add(this.nombreBLabel);
            this.groupBoxBuscar.Controls.Add(this.edadBLabel);
            this.groupBoxBuscar.Controls.Add(this.carreraBLabel);
            this.groupBoxBuscar.Controls.Add(this.buscarBtn);
            this.groupBoxBuscar.Controls.Add(this.chkCursandoBuscar);
            this.groupBoxBuscar.Controls.Add(this.txtEdadBuscar);
            this.groupBoxBuscar.Controls.Add(this.añoBLabel);
            this.groupBoxBuscar.Controls.Add(this.txtCarreraBuscar);
            this.groupBoxBuscar.Controls.Add(this.txtAñoBuscar);
            this.groupBoxBuscar.Location = new System.Drawing.Point(537, 13);
            this.groupBoxBuscar.Name = "groupBoxBuscar";
            this.groupBoxBuscar.Size = new System.Drawing.Size(458, 214);
            this.groupBoxBuscar.TabIndex = 41;
            this.groupBoxBuscar.TabStop = false;
            // 
            // materiaBLabel
            // 
            this.materiaBLabel.AutoSize = true;
            this.materiaBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materiaBLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materiaBLabel.Location = new System.Drawing.Point(23, 101);
            this.materiaBLabel.Name = "materiaBLabel";
            this.materiaBLabel.Size = new System.Drawing.Size(60, 15);
            this.materiaBLabel.TabIndex = 39;
            this.materiaBLabel.Text = "Materia:";
            // 
            // notaBLabel
            // 
            this.notaBLabel.AutoSize = true;
            this.notaBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notaBLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.notaBLabel.Location = new System.Drawing.Point(245, 101);
            this.notaBLabel.Name = "notaBLabel";
            this.notaBLabel.Size = new System.Drawing.Size(41, 15);
            this.notaBLabel.TabIndex = 41;
            this.notaBLabel.Text = "Nota:";
            // 
            // txtMateriaBuscar
            // 
            this.txtMateriaBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMateriaBuscar.Location = new System.Drawing.Point(26, 119);
            this.txtMateriaBuscar.Name = "txtMateriaBuscar";
            this.txtMateriaBuscar.Size = new System.Drawing.Size(200, 21);
            this.txtMateriaBuscar.TabIndex = 40;
            // 
            // txtNotaBuscar
            // 
            this.txtNotaBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotaBuscar.Location = new System.Drawing.Point(248, 119);
            this.txtNotaBuscar.Name = "txtNotaBuscar";
            this.txtNotaBuscar.Size = new System.Drawing.Size(199, 21);
            this.txtNotaBuscar.TabIndex = 42;
            // 
            // habilitarButton
            // 
            this.habilitarButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.habilitarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.habilitarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.habilitarButton.Location = new System.Drawing.Point(26, 169);
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
            this.carreraBLabel.Size = new System.Drawing.Size(59, 15);
            this.carreraBLabel.TabIndex = 21;
            this.carreraBLabel.Text = "Carrera:";
            // 
            // buscarBtn
            // 
            this.buscarBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buscarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarBtn.Location = new System.Drawing.Point(123, 169);
            this.buscarBtn.Name = "buscarBtn";
            this.buscarBtn.Size = new System.Drawing.Size(75, 23);
            this.buscarBtn.TabIndex = 28;
            this.buscarBtn.Text = "BUSCAR";
            this.buscarBtn.UseVisualStyleBackColor = false;
            // 
            // chkCursandoBuscar
            // 
            this.chkCursandoBuscar.AutoSize = true;
            this.chkCursandoBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCursandoBuscar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkCursandoBuscar.Location = new System.Drawing.Point(195, 146);
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
            // añoBLabel
            // 
            this.añoBLabel.AutoSize = true;
            this.añoBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.añoBLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.añoBLabel.Location = new System.Drawing.Point(245, 20);
            this.añoBLabel.Name = "añoBLabel";
            this.añoBLabel.Size = new System.Drawing.Size(35, 15);
            this.añoBLabel.TabIndex = 23;
            this.añoBLabel.Text = "Año:";
            // 
            // txtCarreraBuscar
            // 
            this.txtCarreraBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarreraBuscar.Location = new System.Drawing.Point(248, 77);
            this.txtCarreraBuscar.Name = "txtCarreraBuscar";
            this.txtCarreraBuscar.Size = new System.Drawing.Size(199, 21);
            this.txtCarreraBuscar.TabIndex = 24;
            // 
            // txtAñoBuscar
            // 
            this.txtAñoBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAñoBuscar.Location = new System.Drawing.Point(248, 37);
            this.txtAñoBuscar.Name = "txtAñoBuscar";
            this.txtAñoBuscar.Size = new System.Drawing.Size(199, 21);
            this.txtAñoBuscar.TabIndex = 25;
            // 
            // groupBoxCRUD
            // 
            this.groupBoxCRUD.Controls.Add(this.materiaLabel);
            this.groupBoxCRUD.Controls.Add(this.notaLabel);
            this.groupBoxCRUD.Controls.Add(this.txtMateria);
            this.groupBoxCRUD.Controls.Add(this.txtNota);
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
            this.groupBoxCRUD.Controls.Add(this.añoLabel);
            this.groupBoxCRUD.Controls.Add(this.txtCarrera);
            this.groupBoxCRUD.Controls.Add(this.añadirBtn);
            this.groupBoxCRUD.Controls.Add(this.txtAño);
            this.groupBoxCRUD.Location = new System.Drawing.Point(43, 13);
            this.groupBoxCRUD.Name = "groupBoxCRUD";
            this.groupBoxCRUD.Size = new System.Drawing.Size(458, 214);
            this.groupBoxCRUD.TabIndex = 40;
            this.groupBoxCRUD.TabStop = false;
            // 
            // materiaLabel
            // 
            this.materiaLabel.AutoSize = true;
            this.materiaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materiaLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materiaLabel.Location = new System.Drawing.Point(23, 101);
            this.materiaLabel.Name = "materiaLabel";
            this.materiaLabel.Size = new System.Drawing.Size(60, 15);
            this.materiaLabel.TabIndex = 35;
            this.materiaLabel.Text = "Materia:";
            // 
            // notaLabel
            // 
            this.notaLabel.AutoSize = true;
            this.notaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notaLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.notaLabel.Location = new System.Drawing.Point(245, 101);
            this.notaLabel.Name = "notaLabel";
            this.notaLabel.Size = new System.Drawing.Size(41, 15);
            this.notaLabel.TabIndex = 37;
            this.notaLabel.Text = "Nota:";
            // 
            // txtMateria
            // 
            this.txtMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMateria.Location = new System.Drawing.Point(26, 119);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(200, 21);
            this.txtMateria.TabIndex = 36;
            // 
            // txtNota
            // 
            this.txtNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota.Location = new System.Drawing.Point(248, 119);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(199, 21);
            this.txtNota.TabIndex = 38;
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
            this.guardarBtn.Location = new System.Drawing.Point(26, 169);
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
            this.limpiarBtn.Location = new System.Drawing.Point(358, 169);
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
            this.carreraLabel.Location = new System.Drawing.Point(245, 60);
            this.carreraLabel.Name = "carreraLabel";
            this.carreraLabel.Size = new System.Drawing.Size(59, 15);
            this.carreraLabel.TabIndex = 21;
            this.carreraLabel.Text = "Carrera:";
            // 
            // chkCursando
            // 
            this.chkCursando.AutoSize = true;
            this.chkCursando.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCursando.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkCursando.Location = new System.Drawing.Point(192, 146);
            this.chkCursando.Name = "chkCursando";
            this.chkCursando.Size = new System.Drawing.Size(87, 19);
            this.chkCursando.TabIndex = 22;
            this.chkCursando.Text = "Cursando";
            this.chkCursando.UseVisualStyleBackColor = true;
            // 
            // eliminarBtn
            // 
            this.eliminarBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.eliminarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eliminarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarBtn.Location = new System.Drawing.Point(277, 169);
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
            this.editarBtn.Location = new System.Drawing.Point(196, 169);
            this.editarBtn.Name = "editarBtn";
            this.editarBtn.Size = new System.Drawing.Size(75, 23);
            this.editarBtn.TabIndex = 29;
            this.editarBtn.Text = "EDITAR";
            this.editarBtn.UseVisualStyleBackColor = false;
            // 
            // añoLabel
            // 
            this.añoLabel.AutoSize = true;
            this.añoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.añoLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.añoLabel.Location = new System.Drawing.Point(245, 20);
            this.añoLabel.Name = "añoLabel";
            this.añoLabel.Size = new System.Drawing.Size(35, 15);
            this.añoLabel.TabIndex = 23;
            this.añoLabel.Text = "Año:";
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
            this.añadirBtn.Location = new System.Drawing.Point(115, 169);
            this.añadirBtn.Name = "añadirBtn";
            this.añadirBtn.Size = new System.Drawing.Size(75, 23);
            this.añadirBtn.TabIndex = 27;
            this.añadirBtn.Text = "AÑADIR";
            this.añadirBtn.UseVisualStyleBackColor = false;
            // 
            // txtAño
            // 
            this.txtAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAño.Location = new System.Drawing.Point(248, 37);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(199, 21);
            this.txtAño.TabIndex = 25;
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
            this.errorLabel.Location = new System.Drawing.Point(66, 238);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 16);
            this.errorLabel.TabIndex = 38;
            // 
            // alumnoDGV
            // 
            this.alumnoDGV.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.alumnoDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alumnoDGV.Location = new System.Drawing.Point(32, 261);
            this.alumnoDGV.Name = "alumnoDGV";
            this.alumnoDGV.Size = new System.Drawing.Size(952, 300);
            this.alumnoDGV.TabIndex = 37;
            // 
            // AlumnoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(999, 574);
            this.Controls.Add(this.groupBoxBuscar);
            this.Controls.Add(this.groupBoxCRUD);
            this.Controls.Add(this.retrocederBtn);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.alumnoDGV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AlumnoForm";
            this.Text = "AlumnoForm";
            this.groupBoxBuscar.ResumeLayout(false);
            this.groupBoxBuscar.PerformLayout();
            this.groupBoxCRUD.ResumeLayout(false);
            this.groupBoxCRUD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoDGV)).EndInit();
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
        private System.Windows.Forms.CheckBox chkCursandoBuscar;
        private System.Windows.Forms.TextBox txtEdadBuscar;
        private System.Windows.Forms.Label añoBLabel;
        private System.Windows.Forms.TextBox txtCarreraBuscar;
        private System.Windows.Forms.TextBox txtAñoBuscar;
        private System.Windows.Forms.GroupBox groupBoxCRUD;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button guardarBtn;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Button limpiarBtn;
        private System.Windows.Forms.Label edadLabel;
        private System.Windows.Forms.Label carreraLabel;
        private System.Windows.Forms.CheckBox chkCursando;
        private System.Windows.Forms.Button eliminarBtn;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Button editarBtn;
        private System.Windows.Forms.Label añoLabel;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.Button añadirBtn;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Button retrocederBtn;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.DataGridView alumnoDGV;
        private System.Windows.Forms.Label materiaLabel;
        private System.Windows.Forms.Label notaLabel;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label materiaBLabel;
        private System.Windows.Forms.Label notaBLabel;
        private System.Windows.Forms.TextBox txtMateriaBuscar;
        private System.Windows.Forms.TextBox txtNotaBuscar;
    }
}
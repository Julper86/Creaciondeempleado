namespace Creaciondeempleado
{
    partial class frmDatosBasicos
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
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            TxtId = new TextBox();
            TxtCelular = new TextBox();
            TxtTelefono = new TextBox();
            TxtDireccion = new TextBox();
            TxtApellido = new TextBox();
            TxtNombre = new TextBox();
            TxtCorreo = new TextBox();
            RdbTId = new RadioButton();
            RdbPasaporte = new RadioButton();
            RdbCedula = new RadioButton();
            DtFecha = new DateTimePicker();
            RdbMasculino = new RadioButton();
            RdbFemenino = new RadioButton();
            RdbSoltero = new RadioButton();
            RdbCasado = new RadioButton();
            RdbUnionlibre = new RadioButton();
            RdbViudo = new RadioButton();
            RdbDivorciado = new RadioButton();
            BtGrabar = new Button();
            BtEliminar = new Button();
            BtConsultar = new Button();
            BtActualizar = new Button();
            BtGJson = new Button();
            Dtgv = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label11 = new Label();
            Id = new DataGridViewTextBoxColumn();
            Identificacion = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)Dtgv).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 64);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 0;
            label1.Text = "Identifcacion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(68, 529);
            label5.Name = "label5";
            label5.Size = new Size(105, 15);
            label5.TabIndex = 4;
            label5.Text = "Correo electronico";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(68, 479);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 5;
            label6.Text = "Celular";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(68, 437);
            label7.Name = "label7";
            label7.Size = new Size(72, 15);
            label7.TabIndex = 6;
            label7.Text = "Telefono fijo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(68, 398);
            label8.Name = "label8";
            label8.Size = new Size(129, 15);
            label8.TabIndex = 7;
            label8.Text = "Direccion de residencia";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(68, 190);
            label9.Name = "label9";
            label9.Size = new Size(56, 15);
            label9.TabIndex = 8;
            label9.Text = "Apellidos";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(68, 146);
            label10.Name = "label10";
            label10.Size = new Size(51, 15);
            label10.TabIndex = 9;
            label10.Text = "Nombre";
            // 
            // TxtId
            // 
            TxtId.Location = new Point(173, 64);
            TxtId.Margin = new Padding(3, 2, 3, 2);
            TxtId.Name = "TxtId";
            TxtId.Size = new Size(178, 23);
            TxtId.TabIndex = 10;
            // 
            // TxtCelular
            // 
            TxtCelular.Location = new Point(210, 477);
            TxtCelular.Margin = new Padding(3, 2, 3, 2);
            TxtCelular.Name = "TxtCelular";
            TxtCelular.Size = new Size(178, 23);
            TxtCelular.TabIndex = 11;
            // 
            // TxtTelefono
            // 
            TxtTelefono.Location = new Point(210, 437);
            TxtTelefono.Margin = new Padding(3, 2, 3, 2);
            TxtTelefono.Name = "TxtTelefono";
            TxtTelefono.Size = new Size(178, 23);
            TxtTelefono.TabIndex = 12;
            // 
            // TxtDireccion
            // 
            TxtDireccion.Location = new Point(220, 398);
            TxtDireccion.Margin = new Padding(3, 2, 3, 2);
            TxtDireccion.Name = "TxtDireccion";
            TxtDireccion.Size = new Size(178, 23);
            TxtDireccion.TabIndex = 13;
            // 
            // TxtApellido
            // 
            TxtApellido.Location = new Point(173, 190);
            TxtApellido.Margin = new Padding(3, 2, 3, 2);
            TxtApellido.Name = "TxtApellido";
            TxtApellido.Size = new Size(178, 23);
            TxtApellido.TabIndex = 14;
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(173, 146);
            TxtNombre.Margin = new Padding(3, 2, 3, 2);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(178, 23);
            TxtNombre.TabIndex = 15;
            // 
            // TxtCorreo
            // 
            TxtCorreo.Location = new Point(210, 524);
            TxtCorreo.Margin = new Padding(3, 2, 3, 2);
            TxtCorreo.Name = "TxtCorreo";
            TxtCorreo.Size = new Size(178, 23);
            TxtCorreo.TabIndex = 16;
            // 
            // RdbTId
            // 
            RdbTId.AutoSize = true;
            RdbTId.Location = new Point(185, 21);
            RdbTId.Margin = new Padding(3, 2, 3, 2);
            RdbTId.Name = "RdbTId";
            RdbTId.Size = new Size(84, 19);
            RdbTId.TabIndex = 17;
            RdbTId.TabStop = true;
            RdbTId.Text = "T.Identidad";
            RdbTId.UseVisualStyleBackColor = true;
            // 
            // RdbPasaporte
            // 
            RdbPasaporte.AutoSize = true;
            RdbPasaporte.Location = new Point(414, 18);
            RdbPasaporte.Margin = new Padding(3, 2, 3, 2);
            RdbPasaporte.Name = "RdbPasaporte";
            RdbPasaporte.Size = new Size(77, 19);
            RdbPasaporte.TabIndex = 18;
            RdbPasaporte.TabStop = true;
            RdbPasaporte.Text = "Pasaporte";
            RdbPasaporte.UseVisualStyleBackColor = true;
            // 
            // RdbCedula
            // 
            RdbCedula.AutoSize = true;
            RdbCedula.Location = new Point(307, 20);
            RdbCedula.Margin = new Padding(3, 2, 3, 2);
            RdbCedula.Name = "RdbCedula";
            RdbCedula.Size = new Size(44, 19);
            RdbCedula.TabIndex = 19;
            RdbCedula.TabStop = true;
            RdbCedula.Text = "C.C";
            RdbCedula.UseVisualStyleBackColor = true;
            // 
            // DtFecha
            // 
            DtFecha.Location = new Point(220, 230);
            DtFecha.Margin = new Padding(3, 2, 3, 2);
            DtFecha.Name = "DtFecha";
            DtFecha.Size = new Size(214, 23);
            DtFecha.TabIndex = 20;
            // 
            // RdbMasculino
            // 
            RdbMasculino.AutoSize = true;
            RdbMasculino.Location = new Point(83, 36);
            RdbMasculino.Margin = new Padding(3, 2, 3, 2);
            RdbMasculino.Name = "RdbMasculino";
            RdbMasculino.Size = new Size(80, 19);
            RdbMasculino.TabIndex = 21;
            RdbMasculino.TabStop = true;
            RdbMasculino.Text = "Masculino";
            RdbMasculino.UseVisualStyleBackColor = true;
            // 
            // RdbFemenino
            // 
            RdbFemenino.AutoSize = true;
            RdbFemenino.Location = new Point(218, 36);
            RdbFemenino.Margin = new Padding(3, 2, 3, 2);
            RdbFemenino.Name = "RdbFemenino";
            RdbFemenino.Size = new Size(78, 19);
            RdbFemenino.TabIndex = 22;
            RdbFemenino.TabStop = true;
            RdbFemenino.Text = "Femenino";
            RdbFemenino.UseVisualStyleBackColor = true;
            // 
            // RdbSoltero
            // 
            RdbSoltero.AutoSize = true;
            RdbSoltero.Location = new Point(89, 25);
            RdbSoltero.Margin = new Padding(3, 2, 3, 2);
            RdbSoltero.Name = "RdbSoltero";
            RdbSoltero.Size = new Size(62, 19);
            RdbSoltero.TabIndex = 23;
            RdbSoltero.TabStop = true;
            RdbSoltero.Text = "Soltero";
            RdbSoltero.UseVisualStyleBackColor = true;
            // 
            // RdbCasado
            // 
            RdbCasado.AutoSize = true;
            RdbCasado.Location = new Point(205, 25);
            RdbCasado.Margin = new Padding(3, 2, 3, 2);
            RdbCasado.Name = "RdbCasado";
            RdbCasado.Size = new Size(64, 19);
            RdbCasado.TabIndex = 24;
            RdbCasado.TabStop = true;
            RdbCasado.Text = "Casado";
            RdbCasado.UseVisualStyleBackColor = true;
            // 
            // RdbUnionlibre
            // 
            RdbUnionlibre.AutoSize = true;
            RdbUnionlibre.Location = new Point(336, 25);
            RdbUnionlibre.Margin = new Padding(3, 2, 3, 2);
            RdbUnionlibre.Name = "RdbUnionlibre";
            RdbUnionlibre.Size = new Size(83, 19);
            RdbUnionlibre.TabIndex = 25;
            RdbUnionlibre.TabStop = true;
            RdbUnionlibre.Text = "Union libre";
            RdbUnionlibre.UseVisualStyleBackColor = true;
            // 
            // RdbViudo
            // 
            RdbViudo.AutoSize = true;
            RdbViudo.Location = new Point(471, 25);
            RdbViudo.Margin = new Padding(3, 2, 3, 2);
            RdbViudo.Name = "RdbViudo";
            RdbViudo.Size = new Size(56, 19);
            RdbViudo.TabIndex = 26;
            RdbViudo.TabStop = true;
            RdbViudo.Text = "Viudo";
            RdbViudo.UseVisualStyleBackColor = true;
            // 
            // RdbDivorciado
            // 
            RdbDivorciado.AutoSize = true;
            RdbDivorciado.Location = new Point(586, 25);
            RdbDivorciado.Margin = new Padding(3, 2, 3, 2);
            RdbDivorciado.Name = "RdbDivorciado";
            RdbDivorciado.Size = new Size(82, 19);
            RdbDivorciado.TabIndex = 27;
            RdbDivorciado.TabStop = true;
            RdbDivorciado.Text = "Divorciado";
            RdbDivorciado.UseVisualStyleBackColor = true;
            // 
            // BtGrabar
            // 
            BtGrabar.Location = new Point(850, 94);
            BtGrabar.Margin = new Padding(3, 2, 3, 2);
            BtGrabar.Name = "BtGrabar";
            BtGrabar.Size = new Size(105, 33);
            BtGrabar.TabIndex = 28;
            BtGrabar.Text = "Grabar";
            BtGrabar.UseVisualStyleBackColor = true;
            BtGrabar.Click += BtGrabar_Click;
            // 
            // BtEliminar
            // 
            BtEliminar.Location = new Point(995, 94);
            BtEliminar.Margin = new Padding(3, 2, 3, 2);
            BtEliminar.Name = "BtEliminar";
            BtEliminar.Size = new Size(111, 33);
            BtEliminar.TabIndex = 29;
            BtEliminar.Text = "Eliminar";
            BtEliminar.UseVisualStyleBackColor = true;
            // 
            // BtConsultar
            // 
            BtConsultar.Location = new Point(842, 154);
            BtConsultar.Margin = new Padding(3, 2, 3, 2);
            BtConsultar.Name = "BtConsultar";
            BtConsultar.Size = new Size(114, 32);
            BtConsultar.TabIndex = 30;
            BtConsultar.Text = "Consultar";
            BtConsultar.UseVisualStyleBackColor = true;
            BtConsultar.Click += BtConsultar_Click;
            // 
            // BtActualizar
            // 
            BtActualizar.Location = new Point(995, 161);
            BtActualizar.Margin = new Padding(3, 2, 3, 2);
            BtActualizar.Name = "BtActualizar";
            BtActualizar.Size = new Size(111, 32);
            BtActualizar.TabIndex = 31;
            BtActualizar.Text = "Actualizar";
            BtActualizar.UseVisualStyleBackColor = true;
            // 
            // BtGJson
            // 
            BtGJson.Location = new Point(933, 224);
            BtGJson.Margin = new Padding(3, 2, 3, 2);
            BtGJson.Name = "BtGJson";
            BtGJson.Size = new Size(118, 36);
            BtGJson.TabIndex = 32;
            BtGJson.Text = "Guardar archivo json";
            BtGJson.UseVisualStyleBackColor = true;
            // 
            // Dtgv
            // 
            Dtgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dtgv.Location = new Point(801, 349);
            Dtgv.Margin = new Padding(3, 2, 3, 2);
            Dtgv.Name = "Dtgv";
            Dtgv.RowHeadersWidth = 51;
            Dtgv.RowTemplate.Height = 29;
            Dtgv.Size = new Size(741, 274);
            Dtgv.TabIndex = 33;
            Dtgv.CellContentClick += Dtgv_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 230);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 34;
            label2.Text = "Fecha de nacimiento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 21);
            label3.Name = "label3";
            label3.Size = new Size(121, 15);
            label3.TabIndex = 36;
            label3.Text = "Tipo de identificacion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 38);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 37;
            label4.Text = "Sexo";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(7, 28);
            label11.Name = "label11";
            label11.Size = new Size(66, 15);
            label11.TabIndex = 38;
            label11.Text = "Estado civil";
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 125;
            // 
            // Identificacion
            // 
            Identificacion.HeaderText = "Tipo de Id";
            Identificacion.MinimumWidth = 6;
            Identificacion.Name = "Identificacion";
            Identificacion.ReadOnly = true;
            Identificacion.Width = 125;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 125;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 6;
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            Apellido.Width = 125;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(RdbFemenino);
            groupBox2.Controls.Add(RdbMasculino);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(68, 258);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(344, 57);
            groupBox2.TabIndex = 39;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(RdbUnionlibre);
            groupBox3.Controls.Add(RdbSoltero);
            groupBox3.Controls.Add(RdbCasado);
            groupBox3.Controls.Add(RdbViudo);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(RdbDivorciado);
            groupBox3.Location = new Point(68, 321);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(696, 53);
            groupBox3.TabIndex = 40;
            groupBox3.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RdbTId);
            groupBox1.Controls.Add(RdbPasaporte);
            groupBox1.Controls.Add(RdbCedula);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(68, 92);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(569, 45);
            groupBox1.TabIndex = 41;
            groupBox1.TabStop = false;
            // 
            // frmDatosBasicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1647, 653);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(BtGJson);
            Controls.Add(BtConsultar);
            Controls.Add(BtEliminar);
            Controls.Add(BtActualizar);
            Controls.Add(BtGrabar);
            Controls.Add(label2);
            Controls.Add(Dtgv);
            Controls.Add(DtFecha);
            Controls.Add(TxtCorreo);
            Controls.Add(TxtNombre);
            Controls.Add(TxtApellido);
            Controls.Add(TxtDireccion);
            Controls.Add(TxtTelefono);
            Controls.Add(TxtCelular);
            Controls.Add(TxtId);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmDatosBasicos";
            Text = "frmDatosBasicos";
            Load += frmDatosBasicos_Load;
            ((System.ComponentModel.ISupportInitialize)Dtgv).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox TxtId;
        private TextBox TxtCelular;
        private TextBox TxtTelefono;
        private TextBox TxtDireccion;
        private TextBox TxtApellido;
        private TextBox TxtNombre;
        private TextBox TxtCorreo;
        private RadioButton RdbTId;
        private RadioButton RdbPasaporte;
        private RadioButton RdbCedula;
        private DateTimePicker DtFecha;
        private RadioButton RdbMasculino;
        private RadioButton RdbFemenino;
        private RadioButton RdbSoltero;
        private RadioButton RdbCasado;
        private RadioButton RdbUnionlibre;
        private RadioButton RdbViudo;
        private RadioButton RdbDivorciado;
        private Button BtGrabar;
        private Button BtEliminar;
        private Button BtConsultar;
        private Button BtActualizar;
        private Button BtGJson;
        private DataGridView Dtgv;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label11;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Identificacion;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox1;
    }
}
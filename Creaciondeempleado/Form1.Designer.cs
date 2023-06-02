namespace Creaciondeempleado
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtRegistro = new Button();
            BtLogin = new Button();
            SuspendLayout();
            // 
            // BtRegistro
            // 
            BtRegistro.Location = new Point(458, 334);
            BtRegistro.Name = "BtRegistro";
            BtRegistro.Size = new Size(213, 86);
            BtRegistro.TabIndex = 0;
            BtRegistro.Text = "Registro nuevo Empleado";
            BtRegistro.UseVisualStyleBackColor = true;
            BtRegistro.Click += BtRegistro_Click;
            // 
            // BtLogin
            // 
            BtLogin.Location = new Point(969, 334);
            BtLogin.Name = "BtLogin";
            BtLogin.Size = new Size(201, 86);
            BtLogin.TabIndex = 1;
            BtLogin.Text = "Login";
            BtLogin.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 862);
            Controls.Add(BtLogin);
            Controls.Add(BtRegistro);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button BtRegistro;
        private Button BtLogin;
    }
}
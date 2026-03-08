namespace WinMySQL.Views
{
    partial class frmAlumno
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNombre = new TextBox();
            txtAPPaterno = new TextBox();
            txtAPMaterno = new TextBox();
            txtNumControl = new TextBox();
            txtTelefono = new TextBox();
            txtEdad = new TextBox();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(323, 23);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero de control";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 23);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 88);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 2;
            label3.Text = "Apellido Paterno";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 150);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 3;
            label4.Text = "Apellido Materno";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(323, 88);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 4;
            label5.Text = "Edad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(323, 150);
            label6.Name = "label6";
            label6.Size = new Size(114, 15);
            label6.TabIndex = 5;
            label6.Text = "Numero de telefono";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(16, 41);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(231, 23);
            txtNombre.TabIndex = 6;
            // 
            // txtAPPaterno
            // 
            txtAPPaterno.Location = new Point(16, 106);
            txtAPPaterno.Name = "txtAPPaterno";
            txtAPPaterno.Size = new Size(231, 23);
            txtAPPaterno.TabIndex = 7;
            // 
            // txtAPMaterno
            // 
            txtAPMaterno.Location = new Point(16, 168);
            txtAPMaterno.Name = "txtAPMaterno";
            txtAPMaterno.Size = new Size(231, 23);
            txtAPMaterno.TabIndex = 8;
            // 
            // txtNumControl
            // 
            txtNumControl.Location = new Point(323, 41);
            txtNumControl.Name = "txtNumControl";
            txtNumControl.Size = new Size(162, 23);
            txtNumControl.TabIndex = 9;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(323, 168);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(162, 23);
            txtTelefono.TabIndex = 10;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(323, 106);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 11;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(247, 211);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 12;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // frmAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 254);
            Controls.Add(btnAceptar);
            Controls.Add(txtEdad);
            Controls.Add(txtTelefono);
            Controls.Add(txtNumControl);
            Controls.Add(txtAPMaterno);
            Controls.Add(txtAPPaterno);
            Controls.Add(txtNombre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAlumno";
            Text = "Alumno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNombre;
        private TextBox txtAPPaterno;
        private TextBox txtAPMaterno;
        private TextBox txtNumControl;
        private TextBox txtTelefono;
        private TextBox txtEdad;
        private Button btnAceptar;
    }
}
namespace WinMySQL.Views
{
    partial class frmProfesor
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
            txtNombre = new TextBox();
            txtPaterno = new TextBox();
            txtMaterno = new TextBox();
            txtEdad = new TextBox();
            txtDepartamento = new TextBox();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 83);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellido Paterno";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 149);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 2;
            label3.Text = "Apellido Materno";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(276, 22);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 3;
            label4.Text = "Edad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(276, 83);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 4;
            label5.Text = "Departamento";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 40);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(195, 23);
            txtNombre.TabIndex = 5;
            // 
            // txtPaterno
            // 
            txtPaterno.Location = new Point(12, 101);
            txtPaterno.Name = "txtPaterno";
            txtPaterno.Size = new Size(195, 23);
            txtPaterno.TabIndex = 6;
            // 
            // txtMaterno
            // 
            txtMaterno.Location = new Point(12, 167);
            txtMaterno.Name = "txtMaterno";
            txtMaterno.Size = new Size(195, 23);
            txtMaterno.TabIndex = 7;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(276, 40);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 8;
            // 
            // txtDepartamento
            // 
            txtDepartamento.Location = new Point(276, 101);
            txtDepartamento.Name = "txtDepartamento";
            txtDepartamento.Size = new Size(148, 23);
            txtDepartamento.TabIndex = 9;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(276, 167);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 10;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // frmProfesor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 218);
            Controls.Add(btnAceptar);
            Controls.Add(txtDepartamento);
            Controls.Add(txtEdad);
            Controls.Add(txtMaterno);
            Controls.Add(txtPaterno);
            Controls.Add(txtNombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmProfesor";
            Text = "Profesor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNombre;
        private TextBox txtPaterno;
        private TextBox txtMaterno;
        private TextBox txtEdad;
        private TextBox txtDepartamento;
        private Button btnAceptar;
    }
}
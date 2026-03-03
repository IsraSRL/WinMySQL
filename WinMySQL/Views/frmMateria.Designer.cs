namespace WinMySQL.Views
{
    partial class frmMateria
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
            txtMateria = new TextBox();
            txtCve = new TextBox();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Materia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 71);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "CVEoficial";
            // 
            // txtMateria
            // 
            txtMateria.Location = new Point(12, 27);
            txtMateria.Name = "txtMateria";
            txtMateria.Size = new Size(279, 23);
            txtMateria.TabIndex = 2;
            // 
            // txtCve
            // 
            txtCve.Location = new Point(12, 89);
            txtCve.Name = "txtCve";
            txtCve.Size = new Size(100, 23);
            txtCve.TabIndex = 3;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(216, 88);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // frmMateria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 143);
            Controls.Add(btnAceptar);
            Controls.Add(txtCve);
            Controls.Add(txtMateria);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmMateria";
            Text = "Materias";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtMateria;
        private TextBox txtCve;
        private Button btnAceptar;
    }
}
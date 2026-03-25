namespace WinMySQL.Views
{
    partial class frmAsistencia
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
            dtpAsistencia = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            dgvAsistencia = new DataGridView();
            splitContainer1 = new SplitContainer();
            txtNCAlumno = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvAsistencia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // dtpAsistencia
            // 
            dtpAsistencia.Format = DateTimePickerFormat.Custom;
            dtpAsistencia.Location = new Point(322, 63);
            dtpAsistencia.Name = "dtpAsistencia";
            dtpAsistencia.Size = new Size(104, 23);
            dtpAsistencia.TabIndex = 0;
            dtpAsistencia.ValueChanged += dtpAsistencia_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 29);
            label1.Name = "label1";
            label1.Size = new Size(171, 15);
            label1.TabIndex = 1;
            label1.Text = "Numero de control del alumno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(278, 69);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 2;
            label2.Text = "Fecha";
            // 
            // dgvAsistencia
            // 
            dgvAsistencia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAsistencia.Dock = DockStyle.Fill;
            dgvAsistencia.Location = new Point(0, 0);
            dgvAsistencia.Name = "dgvAsistencia";
            dgvAsistencia.Size = new Size(751, 339);
            dgvAsistencia.TabIndex = 3;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(txtNCAlumno);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(dtpAsistencia);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvAsistencia);
            splitContainer1.Size = new Size(751, 451);
            splitContainer1.SplitterDistance = 108;
            splitContainer1.TabIndex = 4;
            // 
            // txtNCAlumno
            // 
            txtNCAlumno.Location = new Point(322, 26);
            txtNCAlumno.Name = "txtNCAlumno";
            txtNCAlumno.Size = new Size(261, 23);
            txtNCAlumno.TabIndex = 4;
            txtNCAlumno.KeyPress += txtNCAlumno_KeyPress;
            // 
            // frmAsistencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 451);
            Controls.Add(splitContainer1);
            Name = "frmAsistencia";
            Text = "Asistencia";
            Load += frmAsistencia_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAsistencia).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtpAsistencia;
        private Label label1;
        private Label label2;
        private DataGridView dgvAsistencia;
        private SplitContainer splitContainer1;
        private TextBox txtNCAlumno;
    }
}
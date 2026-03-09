namespace WinMySQL.Views
{
    partial class frmProfesores
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
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            btnAgregar = new Button();
            txtBuscar = new TextBox();
            label1 = new Label();
            dgvProfesor = new DataGridView();
            cmsProfesor = new ContextMenuStrip(components);
            recargarDatosToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProfesor).BeginInit();
            cmsProfesor.SuspendLayout();
            SuspendLayout();
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
            splitContainer1.Panel1.Controls.Add(btnAgregar);
            splitContainer1.Panel1.Controls.Add(txtBuscar);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvProfesor);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 89;
            splitContainer1.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(644, 26);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(12, 27);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(243, 23);
            txtBuscar.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Buscar";
            // 
            // dgvProfesor
            // 
            dgvProfesor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProfesor.ContextMenuStrip = cmsProfesor;
            dgvProfesor.Dock = DockStyle.Fill;
            dgvProfesor.Location = new Point(0, 0);
            dgvProfesor.Name = "dgvProfesor";
            dgvProfesor.Size = new Size(800, 357);
            dgvProfesor.TabIndex = 0;
            dgvProfesor.CellContentDoubleClick += dgvProfesor_CellContentDoubleClick;
            // 
            // cmsProfesor
            // 
            cmsProfesor.Items.AddRange(new ToolStripItem[] { recargarDatosToolStripMenuItem, toolStripSeparator1, eliminarToolStripMenuItem });
            cmsProfesor.Name = "cmsProfesor";
            cmsProfesor.Size = new Size(153, 54);
            // 
            // recargarDatosToolStripMenuItem
            // 
            recargarDatosToolStripMenuItem.Name = "recargarDatosToolStripMenuItem";
            recargarDatosToolStripMenuItem.Size = new Size(152, 22);
            recargarDatosToolStripMenuItem.Text = "Recargar datos";
            recargarDatosToolStripMenuItem.Click += recargarDatosToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(149, 6);
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(152, 22);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            // 
            // frmProfesores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "frmProfesores";
            Text = "Profesores";
            Load += frmProfesores_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProfesor).EndInit();
            cmsProfesor.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btnAgregar;
        private TextBox txtBuscar;
        private Label label1;
        private DataGridView dgvProfesor;
        private ContextMenuStrip cmsProfesor;
        private ToolStripMenuItem recargarDatosToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem eliminarToolStripMenuItem;
    }
}
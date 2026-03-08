using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinMySQL.Clases;

namespace WinMySQL.Views
{
    public partial class frmAlumnos : Form
    {
        Datos datos = new Datos();
        DataSet ds = new DataSet();
        public frmAlumnos()
        {
            InitializeComponent();
        }

        public void CargarDatos()
        {
            try
            {
                ds = datos.Ejecutar("select * from ALUMNOS");
                if (ds != null)
                {
                    dgvAlumnos.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmAlumnos_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAlumno alumno = new frmAlumno();
            alumno.ShowDialog();
        }

        private void dgvAlumnos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show($"ID: {dgvAlumnos.CurrentRow.Cells[0].Value}");
            frmAlumno alumno = new frmAlumno(
                Convert.ToInt32(dgvAlumnos.CurrentRow.Cells[0].Value),
                dgvAlumnos.CurrentRow.Cells[1].Value.ToString(),
                dgvAlumnos.CurrentRow.Cells[2].Value.ToString(),
                dgvAlumnos.CurrentRow.Cells[3].Value.ToString(),
                dgvAlumnos.CurrentRow.Cells[4].Value.ToString(),
                Convert.ToInt32(dgvAlumnos.CurrentRow.Cells[5].Value),
                dgvAlumnos.CurrentRow.Cells[6].Value.ToString());
            alumno.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idAlumno = Convert.ToInt32(dgvAlumnos.CurrentRow.Cells[0].Value);
            if (MessageBox.Show("¿Deseas eliminar a este alumno?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                bool eliminar = datos.EjecutarComando(
                    $"Delete from ALUMNOS where idALUMNOS=" + $"{idAlumno}");

                if (eliminar)
                {
                    MessageBox.Show("Registro eliminado correctamente", "Sistema");
                }
                else
                {
                    MessageBox.Show("Error al intentar eliminar el registro", "Sistema");
                }
            }
        }

        private void recargarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}

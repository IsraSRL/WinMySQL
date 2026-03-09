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
    public partial class frmProfesores : Form
    {
        Datos datos = new Datos();
        DataSet ds = new DataSet();
        public frmProfesores()
        {
            InitializeComponent();
        }

        public void CargarDatos()
        {
            try
            {
                ds = datos.Ejecutar("select * from PROFESORES");
                if (ds != null)
                {
                    dgvProfesor.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmProfesores_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmProfesor profesor = new frmProfesor();
            profesor.ShowDialog();
        }

        private void recargarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idProfe = Convert.ToInt32(dgvProfesor.CurrentRow.Cells[0].Value);
            if (MessageBox.Show("¿Deseas eliminar a este profesor?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                bool eliminar = datos.EjecutarComando(
                    $"Delete from PROFESORES where idPROFESORES=" + $"{idProfe}");

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

        private void dgvProfesor_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show($"ID: {dgvProfesor.CurrentRow.Cells[0].Value}");
            frmProfesor profesor = new frmProfesor(
                Convert.ToInt32(dgvProfesor.CurrentRow.Cells[0].Value),
                dgvProfesor.CurrentRow.Cells[1].Value.ToString(),
                dgvProfesor.CurrentRow.Cells[2].Value.ToString(),
                dgvProfesor.CurrentRow.Cells[3].Value.ToString(),
                Convert.ToInt32(dgvProfesor.CurrentRow.Cells[4].Value),
                dgvProfesor.CurrentRow.Cells[5].Value.ToString());
            profesor.Show();
        }
    }
}

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
    public partial class frmAsistencia : Form
    {
        Datos datos = new Datos();
        DataSet ds = new DataSet();
        public frmAsistencia()
        {
            InitializeComponent();
            dtpAsistencia.CustomFormat = "dd/MM/yyyy";
        }

        private void frmAsistencia_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        public void Cargar()
        {
            try
            {
                ds = datos.Ejecutar("select alu.NumControl, alu.Nombre, alu.ApPaterno, alu.ApMaterno, Fecha" +
                    " from ASISTENCIA asi left join ALUMNOS alu on asi.NumControl = alu.NumControl" +
                    $" where Fecha like '{dtpAsistencia.Value.Day}/%{dtpAsistencia.Value.Month}%'");
                if (ds != null)
                {
                    dgvAsistencia.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtNCAlumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // 1. Evitar el sonido de "beep" al presionar Enter
                e.Handled = true;

                string NumeroControl = txtNCAlumno.Text;

                //checar que tenga un alumno para registrar
                if (NumeroControl == "")
                {
                    MessageBox.Show("Ingrese un numero de control", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool resultado = datos.EjecutarComando(
                    $"insert into ASISTENCIA(NumControl, Fecha)" +
                    $"values('{txtNCAlumno.Text}','{dtpAsistencia.Value.ToShortDateString()}')");

                if (resultado)
                {
                    MessageBox.Show("Alumno agregado correctamente");
                    Cargar();
                }
                else
                {
                    MessageBox.Show("Error al agregar el alumno");
                }
            }
        }

        private void dtpAsistencia_ValueChanged(object sender, EventArgs e)
        {
            Cargar();
        }
    }
}

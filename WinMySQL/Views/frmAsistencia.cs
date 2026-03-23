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
        public frmAsistencia()
        {
            InitializeComponent();
        }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            string NumeroControl = txtNCAlumno.Text;

            //checar que tenga un alumno para registrar
            if (NumeroControl == "")
            {
                MessageBox.Show("Ingrese un numero de control", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool resultado = datos.EjecutarComando(
                $"insert into ASISTENCIA()");
        }
    }
}

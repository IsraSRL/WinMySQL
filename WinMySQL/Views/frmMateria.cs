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
    public partial class frmMateria : Form
    {
        Datos dt = new Datos();
        public frmMateria()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool resultado = dt.EjecutarComando(
                $"Insert into MATERIAS (Materia, CVE)" +
                $"values('{txtMateria.Text}','{txtCve}')");

            if (resultado) { MessageBox.Show("Materia agregada correctamente")
                else  MessageBox.Show("Error al agregar materia");
            }
        }
    }
}

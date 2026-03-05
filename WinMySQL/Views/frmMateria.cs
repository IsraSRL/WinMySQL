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
        int id = 0;
        bool updating = false;
        Datos dt = new Datos();
        public frmMateria()
        {
            InitializeComponent();
        }

        public frmMateria(int id, string materias, string cveOficial)
        {
            InitializeComponent();
            this.id = id;
            txtMateria.Text = materias;
            txtCve.Text = cveOficial;
            updating = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            

            if(updating == false)
            {
                bool resultado = dt.EjecutarComando(
                $"Insert into MATERIAS (Materias, cveOficial)" +
                $"values('{txtMateria.Text}','{txtCve.Text}')");

                if (resultado)
                {
                    MessageBox.Show("Materia agregada correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al agregar materia");
                }
            }
            else
            {
                bool resultado = dt.EjecutarComando(
                    $"Update MATERIAS set materias='{txtMateria.Text}', cveOficial='{txtCve.Text}'" +
                    $"Where idMATERIAS={id}");

                if (resultado)
                {
                    MessageBox.Show("Materia actualizada correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar materia");
                }
            }

            
        }
    }
}

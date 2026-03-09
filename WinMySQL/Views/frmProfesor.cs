using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinMySQL.Clases;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinMySQL.Views
{
    public partial class frmProfesor : Form
    {
        int id = 0;
        bool update = false;
        Datos dt = new Datos();
        public frmProfesor()
        {
            InitializeComponent();
        }

        public frmProfesor(int id, string nombre, string appaterno, string apmaterno, int edad, string departamento)
        {
            InitializeComponent();
            this.id = id;
            txtNombre.Text = nombre;
            txtPaterno.Text = appaterno;
            txtMaterno.Text = apmaterno;
            txtEdad.Text = edad.ToString();
            txtDepartamento.Text = departamento.ToString();
            update = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int edad = Convert.ToInt32(txtEdad.Text);
            //checar que la edad sea "real"
            if (edad < 0)
            {
                MessageBox.Show("Ingrese una edad valida", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (update == false)
            {
                bool resultado = dt.EjecutarComando(
                    $"insert into PROFESORES(Nombre, ApPaterno, ApMaterno, Edad, Departamento)" +
                    $"values('{txtNombre.Text}','{txtPaterno.Text}','{txtMaterno.Text}',{edad},'{txtDepartamento.Text}')");

                if (resultado)
                {
                    MessageBox.Show("Profesor agregado correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al agregar al profesor");
                }
            }
            else
            {
                bool resultado = dt.EjecutarComando(
                    $"update PROFESORES set Nombre='{txtNombre.Text}',ApPaterno='{txtPaterno.Text}',ApMaterno='{txtMaterno.Text}'" +
                    $",Edad={edad},Departamento='{txtDepartamento.Text}'" +
                    $"where idPROFESORES = {id}");

                if (resultado)
                {
                    MessageBox.Show("Profesor actualizado correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar al profesor");
                }
            }
        }
    }
}

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
    public partial class frmAlumno : Form
    {
        bool update = false;
        int id = 0;
        Datos datos = new Datos();
        public frmAlumno()
        {
            InitializeComponent();
        }

        public frmAlumno(int id, string nc, string nombre, string appaterno, string apmaterno, int edad, string tel)
        {
            InitializeComponent();
            this.id = id;
            txtNumControl.Text = nc;
            txtNombre.Text = nombre;
            txtAPPaterno.Text = appaterno;
            txtAPMaterno.Text = apmaterno;
            txtEdad.Text = Convert.ToString(edad);
            txtTelefono.Text = tel;
            update = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int edad = Convert.ToInt32(txtEdad.Text);
            //checar que numero de control no este vacio
            if (txtNumControl.Text == "")
            {
                MessageBox.Show("Ingrese un numero de control", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //checar que la edad sea "real"
            if(edad < 0)
            {
                MessageBox.Show("Ingrese una edad valida", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(update == false)
            {
                bool resultado = datos.EjecutarComando(
                    $"insert into ALUMNOS(NumControl, Nombre, ApPaterno, ApMaterno, Edad, NumTelefono)" +
                    $"values('{txtNumControl.Text}','{txtNombre.Text}','{txtAPPaterno.Text}','{txtAPMaterno.Text}',{edad},'{txtTelefono.Text}')");

                if(resultado)
                {
                    MessageBox.Show("Alumno agregado correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al agregar el alumno");
                }
            }
            else
            {
                bool resultado = datos.EjecutarComando(
                    $"update ALUMNOS set NumControl='{txtNumControl.Text}'," +
                    $" Nombre='{txtNombre.Text}',ApPaterno='{txtAPPaterno.Text}',ApMaterno='{txtAPMaterno.Text}'" +
                    $",Edad={edad},NumTelefono='{txtTelefono.Text}'" +
                    $"where idALUMNOS = {id}");

                if (resultado)
                {
                    MessageBox.Show("Alumno actualizado correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el alumno");
                }
            }
        }
    }
}

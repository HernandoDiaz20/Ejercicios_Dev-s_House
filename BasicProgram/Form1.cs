using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BasicProgram
{
    public partial class MainForm : Form
    {
        
        // Declaracion de una variable de fecha
        DateTime fechaNacimiento;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCalcularEdad_Click(object sender, EventArgs e)
        {
            // Validar que se haya ingresado una fecha valida
            if (DateTime.TryParse(txtFechaNacimiento.Text, out fechaNacimiento))
            {
                // Calcular la edad
                int edad = CalcularEdad(fechaNacimiento);

                // Mostrar la edad en un Label
                lblEdadCalculada.Text = edad.ToString() + " años";
            }
            else
            {
                // Mostrar un mensaje de error si la fecha no es valida
                MessageBox.Show("Por favor, ingrese una fecha de nacimiento válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Metodo para calcular la edad
        private int CalcularEdad(DateTime fechaNacimiento)
        {
            DateTime ahora = DateTime.Today;
            int edad = ahora.Year - fechaNacimiento.Year;

            // Ajustar la edad si aún no se ha cumplido el cumpleaños de este año
            if (fechaNacimiento > ahora.AddYears(-edad))
                edad--;

            return edad;
        }

        // Boton para limpiar los campos despues de calcular una edad
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtFechaNacimiento.Clear();
            lblEdadCalculada.Text = " ";
        }
    }
}

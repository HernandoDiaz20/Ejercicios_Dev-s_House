using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Cap35_al_48
{
    public partial class PrincipalForm : Form
    {
        private GestorContactos gestorContactos;
        public PrincipalForm()
        {
            InitializeComponent();
            gestorContactos = new GestorContactos();
            listBoxContactos.SelectedIndexChanged += listBoxContactos_SelectedIndexChanged;
        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void textBoxTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text;
            string telefono = textBoxTelefono.Text;
            Contacto nuevoContacto = new Contacto(nombre, telefono);
            try
            {
                gestorContactos.AgregarContacto(nuevoContacto);
                ActualizarListBoxContactos();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int indiceSeleccionado = listBoxContactos.SelectedIndex;
            if (indiceSeleccionado != -1)
            {
                gestorContactos.EliminarContacto(indiceSeleccionado);
                ActualizarListBoxContactos();
            }
            textBoxNombre.Text = string.Empty;
            textBoxTelefono.Text = string.Empty;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int indiceSeleccionado = listBoxContactos.SelectedIndex;
            if (indiceSeleccionado != -1)
            {
                string nombre = textBoxNombre.Text;
                string telefono = textBoxTelefono.Text;
                Contacto contactoModificado = new Contacto(nombre, telefono);

                if (textBoxNombre.Text == "" || textBoxTelefono.Text == "")
                {
                    MessageBox.Show("Error, todos los campos deben estar llenos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    gestorContactos.ModificarContacto(indiceSeleccionado, contactoModificado);

                    listBoxContactos.Items[indiceSeleccionado] = contactoModificado;
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                gestorContactos.GuardarContactos(saveFileDialog.FileName);
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                gestorContactos.CargarContactos(openFileDialog.FileName);
                ActualizarListBoxContactos();
            }
        }

        private void ActualizarListBoxContactos()
        {
            listBoxContactos.Items.Clear();
            List<Contacto> contactos = gestorContactos.ObtenerContactos();
            foreach (Contacto contacto in contactos)
            {
                listBoxContactos.Items.Add(contacto);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBoxNombre.Text = string.Empty;
            textBoxTelefono.Text = string.Empty;
        }

        private void listBoxContactos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxContactos.SelectedIndex != -1)
            {
                Contacto contactoSeleccionado = listBoxContactos.SelectedItem as Contacto;

                textBoxNombre.Text = contactoSeleccionado.Nombre;
                textBoxTelefono.Text = contactoSeleccionado.Telefono;
            }

        }

        private void btnLimpiarContactos_Click(object sender, EventArgs e)
        {
            listBoxContactos.Items.Clear();
        }
    }
}
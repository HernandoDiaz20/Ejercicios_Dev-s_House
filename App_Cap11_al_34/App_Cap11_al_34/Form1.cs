using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Cap11_al_34
{
    public partial class FormPrincipal : Form
    {
        List<int> listaNumeros = new List<int>();
        ArrayList arrayNumeros = new ArrayList();
        int[] vectorNumeros = new int[5];
        int[,] matrizNumeros = new int[3, 3];

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            // Generar números aleatorios únicos y almacenar en diferentes estructuras de datos
            while (listaNumeros.Count < 5)
            {
                int numero = rnd.Next(1, 101);
                if (!listaNumeros.Contains(numero))
                {
                    listaNumeros.Add(numero);
                }
            }

            while (arrayNumeros.Count < 5)
            {
                int numero = rnd.Next(1, 101);
                if (!arrayNumeros.Contains(numero))
                {
                    arrayNumeros.Add(numero);
                }
            }

            for (int i = 0; i < vectorNumeros.Length; i++)
            {
                int numero = rnd.Next(1, 101);
                while (Array.IndexOf(vectorNumeros, numero) != -1)
                {
                    numero = rnd.Next(1, 101);
                }
                vectorNumeros[i] = numero;
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrizNumeros[i, j] = rnd.Next(1, 101);
                }
            }

            // Mostrar los números en los ListBox
            listNumLista.Items.Clear();
            listNumArrayList.Items.Clear();
            listNumVector.Items.Clear();
            listNumMatriz.Items.Clear();

            foreach (int num in listaNumeros)
            {
                listNumLista.Items.Add(num);
            }

            foreach (int num in arrayNumeros)
            {
                listNumArrayList.Items.Add(num);
            }

            foreach (int num in vectorNumeros)
            {
                listNumVector.Items.Add(num);
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    listNumMatriz.Items.Add(matrizNumeros[i, j]);
                }
            }
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            // Procesar los datos y mostrar resultados
            try
            {
                int sumaLista = 0;
                int sumaArray = 0;
                int sumaVector = 0;
                int sumaMatriz = 0;

                //Generar una excepcion por intentantar acceder a un elemento en una posición que está fuera del rango.
                //int numero = listaNumeros[10]; 

                // Calcular la suma de elementos en cada estructura
                foreach (int num in listaNumeros)
                {
                    sumaLista += num;
                }

                foreach (int num in arrayNumeros)
                {
                    sumaArray += num;
                }

                foreach (int num in vectorNumeros)
                {
                    sumaVector += num;
                }

                foreach (int num in matrizNumeros)
                {
                    sumaMatriz += num;
                }

                // Mostrar resultados en TextBoxes
                txtSumaLista.Text = sumaLista.ToString();
                txtSumaArray.Text = sumaArray.ToString();
                txtSumaVector.Text = sumaVector.ToString();
                txtSumaMatriz.Text = sumaMatriz.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtSumaLista.Text = "";
            txtSumaArray.Text = "";
            txtSumaVector.Text = "";
            txtSumaMatriz.Text = "";
            listaNumeros.Clear();
            arrayNumeros.Clear();
            Array.Clear(vectorNumeros, 0, vectorNumeros.Length);
            matrizNumeros = new int[3, 3];
            listNumLista.Items.Clear();
            listNumArrayList.Items.Clear();
            listNumVector.Items.Clear();
            listNumMatriz.Items.Clear();
        }
    }
}

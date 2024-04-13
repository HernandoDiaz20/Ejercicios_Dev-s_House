using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entidades;

namespace Datos
{
    public class RepositorioContactos
    {
        private List<Contacto> contactos = new List<Contacto>();

        public void AgregarContacto(Contacto contacto)
        {
            contactos.Add(contacto);
        }

        public void EliminarContacto(int indice)
        {
            if (indice >= 0 && indice < contactos.Count)
            {
                contactos.RemoveAt(indice);
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(indice), "El índice está fuera del rango de la lista de contactos.");
            }
        }

        public void LimpiarContactos()
        {
            contactos.Clear();
        }

        public List<Contacto> ObtenerContactos()
        {
            return contactos;
        }

        public void GuardarContactos(List<Contacto> contactos, string rutaArchivo)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(rutaArchivo))
                {
                    foreach (Contacto contacto in contactos)
                    {
                        writer.WriteLine($"{contacto.Nombre},{contacto.Telefono}");
                    }
                }
                Console.WriteLine("Contactos guardados correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al guardar contactos: {ex.Message}");
            }
        }

        public List<Contacto> CargarContactos(string rutaArchivo)
        {
            List<Contacto> contactos = new List<Contacto>();
            try
            {
                using (StreamReader reader = new StreamReader(rutaArchivo))
                {
                    string linea;
                    while ((linea = reader.ReadLine()) != null)
                    {
                        string[] partes = linea.Split(',');
                        string nombre = partes[0];
                        string telefono = partes[1];
                        contactos.Add(new Contacto(nombre, telefono));
                    }
                }
                Console.WriteLine("Contactos cargados correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar contactos: {ex.Message}");
            }
            return contactos;
        }

        public void ActualizarContactos(List<Contacto> contactosActualizados)
        {
            foreach (var contacto in contactosActualizados)
            {
                int indice = contactos.FindIndex(c => c.Nombre.Equals(contacto.Nombre, StringComparison.OrdinalIgnoreCase) && c.Telefono.Equals(contacto.Telefono, StringComparison.OrdinalIgnoreCase));
                if (indice != -1)
                {
                    contactos[indice] = contacto;
                }
                else
                {
                    AgregarContacto(contacto);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Logica
{
    public class GestorContactos
    {
        private RepositorioContactos repositorio;

        public GestorContactos()
        {
            repositorio = new RepositorioContactos();
        }

        public void AgregarContacto(Contacto contacto)
        {
            if (contacto == null)
            {
                throw new ArgumentNullException(nameof(contacto), "El contacto no puede ser nulo.");
            }

            if (string.IsNullOrWhiteSpace(contacto.Nombre))
            {
                throw new ArgumentException("El nombre del contacto no puede ser nulo ni vacío.");
            }

            if (string.IsNullOrWhiteSpace(contacto.Telefono))
            {
                throw new ArgumentException("El teléfono del contacto no puede ser nulo ni vacío.");
            }

            if (repositorio.ObtenerContactos().Any(c => c.Nombre.Equals(contacto.Nombre, StringComparison.OrdinalIgnoreCase) && c.Telefono.Equals(contacto.Telefono, StringComparison.OrdinalIgnoreCase)))
            {
                throw new ArgumentException("El contacto ya existe en la lista.");
            }

            repositorio.AgregarContacto(contacto);
        }

        public void EliminarContacto(int indice)
        {
            if (indice < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(indice), "El índice debe ser mayor o igual a cero.");
            }

            repositorio.EliminarContacto(indice);
        }

        public void GuardarContactos(string rutaArchivo)
        {
            if (string.IsNullOrWhiteSpace(rutaArchivo))
            {
                throw new ArgumentException("La ruta del archivo no puede ser nula ni vacía.", nameof(rutaArchivo));
            }

            List<Contacto> contactos = ObtenerContactos();
            repositorio.GuardarContactos(contactos, rutaArchivo);
        }

        public void CargarContactos(string rutaArchivo)
        {
            if (string.IsNullOrWhiteSpace(rutaArchivo))
            {
                throw new ArgumentException("La ruta del archivo no puede ser nula ni vacía.", nameof(rutaArchivo));
            }

            List<Contacto> contactos = repositorio.CargarContactos(rutaArchivo);

            repositorio.LimpiarContactos();
            foreach (var contacto in contactos)
            {
                AgregarContacto(contacto);
            }
        }

        public void ModificarContacto(int indice, Contacto contactoModificado)
        {
            try
            {
                List<Contacto> contactos = ObtenerContactos();
                if (indice < 0 || indice >= contactos.Count)
                {
                    throw new ArgumentOutOfRangeException(nameof(indice), "El índice está fuera del rango de la lista de contactos.");
                }

                if (contactoModificado == null)
                {
                    throw new ArgumentNullException(nameof(contactoModificado), "El contacto modificado no puede ser nulo.");
                }

                if (string.IsNullOrWhiteSpace(contactoModificado.Nombre))
                {
                    throw new ArgumentException("El nombre del contacto modificado no puede ser nulo ni vacío.");
                }

                if (string.IsNullOrWhiteSpace(contactoModificado.Telefono))
                {
                    throw new ArgumentException("El teléfono del contacto modificado no puede ser nulo ni vacío.");
                }

                if (contactos.Any(c => c.Nombre.Equals(contactoModificado.Nombre, StringComparison.OrdinalIgnoreCase) && c.Telefono.Equals(contactoModificado.Telefono, StringComparison.OrdinalIgnoreCase) && contactos.IndexOf(c) != indice))
                {
                    throw new ArgumentException("El contacto modificado ya existe en la lista.");
                }

                contactos[indice] = contactoModificado;

                repositorio.ActualizarContactos(contactos);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al modificar el contacto: {ex.Message}");
            }
        }

        public List<Contacto> ObtenerContactos()
        {
            return repositorio.ObtenerContactos();
        }
    }
}

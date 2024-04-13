using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Contacto
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }

        public Contacto(string nombre, string telefono)
        {
            Nombre = nombre;
            Telefono = telefono;
        }

        public override string ToString()
        {
            return $"{Nombre}: {Telefono}";
        }
    }
}

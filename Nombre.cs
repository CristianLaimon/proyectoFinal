using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoFinal
{
    internal class Nombre
    {
        private string nombres;
        private string apellidos;

        public Nombre()
        {
            Nombres = string.Empty;
            Apellidos = string.Empty;
        }

        public Nombre (string nombre, string apellido)
        {
            this.Nombres = nombre;
            this.Apellidos = apellido;
        }

        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
    }
}

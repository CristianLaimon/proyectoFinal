using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoFinal
{
    internal class Nombre
    {
        private string nombre;
        private string apellido;
        private byte edad;
        private double sueldo;

        public Nombre()
        {
            nombre = String.Empty;
            Apellido = String.Empty;
            Edad = 0;
            Sueldo = 0;
        }

        public Nombre(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public Nombre (string nombre, string apellido, byte edad, double sueldo)
        {
            this.nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad;
            this.Sueldo = sueldo;
        }

        public string PNombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public byte Edad { get => edad; set => edad = value; }
        public double Sueldo { get => sueldo; set => sueldo = value; }
    }
}

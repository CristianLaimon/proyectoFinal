using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoFinal
{
    internal class Archivo
    {
        FileStream Fs;
        BinaryReader Br;
        BinaryWriter Bw;
        int numRegistros;
        long longRegistro;
        
        public Archivo(long longRegistro, string nombreArchivo)
        {
            Fs = new FileStream(nombreArchivo, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            Br = new BinaryReader(Fs);
            Bw = new BinaryWriter(Fs);
            this.longRegistro = longRegistro;
            NumRegistros = (int)Math.Ceiling((double)Fs.Length / longRegistro);
        }

        public int NumRegistros { get => numRegistros; set => numRegistros = value; }

        public long LongitudArchivo()
        {
            return  Fs.Length;
        }

        public void CerrarArchivo()
        {
            if (Br != null)
            {
                Br.Close();
            }
            if (Bw != null)
            {
                Bw.Close();
            }
        }

        public void EcribirRegistos(Nombre datos, int numRegistros)
        {
            try
            {
                Bw.BaseStream.Seek(numRegistros * longRegistro, SeekOrigin.Begin);
                Bw.Write(datos.Nombres);
                Bw.Write(datos.Apellidos);
                numRegistros++;
                Bw.Flush(); //se guardan aunque no le de guardar (por alguna falla de corriente o algo
            }
            catch
            {
                MessageBox.Show("Algo salio mal :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Nombre LeerRegistros(int posicion)
        {
            Br.BaseStream.Seek(posicion * longRegistro, SeekOrigin.Begin);
            string Nombre = Br.ReadString();
            string Apellido = Br.ReadString();
            return new Nombre(Nombre, Apellido);
        }
    }
}

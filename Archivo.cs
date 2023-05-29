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
        int numReg;
        int longReg;

        public Archivo(long LReg, string NArch) //Longitud registro y Nombre Archivo
        {
            Fs = new FileStream(NArch, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            Br = new BinaryReader(Fs);
            Bw = new BinaryWriter(Fs);
            longReg = (int)LReg;
            NumReg = (int)Math.Ceiling((double)Fs.Length / longReg); //Por qué se redondea? si los registros ya están definidos y con números enteros

        }

        public int NumReg { get => numReg; set => numReg = value; }

        public long LongArch() => Fs.Length; //Regresa la longitud en bytes del archivo

        public void CerrarArchivos()
        {
            if(Br != null) Br.Close();
            if(Bw != null) Bw.Close();
        }

        public void EscribirRegs(Nombre datos,int r) //--- y el no.de registro
        {
            try
            {
                Bw.BaseStream.Seek(r * longReg, SeekOrigin.Begin);
                Bw.Write(datos.PNombre);
                numReg++;
                Bw.Flush(); //Obliga a que los datos almacenado en el buffer se guarden en el medio.... (¨?????")

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Algo salio mal");
            }
        }

        public Nombre LeerRegs(int pos)
        {
            Br.BaseStream.Seek(pos * longReg , SeekOrigin.Begin);
            string Nom = Br.ReadString();
            string Ape = Br.ReadString();
            return new Nombre(Nom, Ape);
        }
    }
}

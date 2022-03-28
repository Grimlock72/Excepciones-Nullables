using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExepcionesYNullables
{
    class Program
    {
        public static List<string> miLista;
        static Exception miExcepcion = new Exception("Revisa tu código!");

        static void Main(string[] args)
        {
            int? number = 45;
            number = null;
            //miLista = new List<string>();
            try
            {
                MiMetodo();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Algo salió mal: {0}", ex.Message);
            }
            Console.ReadLine();
        }

        private static void MiMetodo()
        {
            throw miExcepcion;
        }
    }
}

using System;

namespace Fundamentos.LINQ
{
    public class Empresa
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public void PrintDatos()
        {
            Console.WriteLine("Empresa {0} con Id {1}", Nombre, Id);
        }
    }
}

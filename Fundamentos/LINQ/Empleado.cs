using Fundamentos.Interfaces;
using System;

namespace Fundamentos.LINQ
{
    public class Empleado: IPrint
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public double Salario { get; set; }
        public int EmpresaId { get; set; }
        public void PrintDatos()
        {
            Console.WriteLine("Empleado {0} con Id {1} y pertenece a la empresa {2}", Nombre, Id, EmpresaId);
        }
    }
}

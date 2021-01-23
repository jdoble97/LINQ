using Fundamentos.LINQ;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Fundamentos
{
    class Program
    {
        public static List<Empresa> empresas;
        public static List<Empleado> empleados;
        static void Main(string[] args)
        {
            int[] source = new int[] {1,2,3,4,5,6,7,8,9,10 };
            LinqExample<int>.FindEvenNumbers(source);
            empresas = new List<Empresa>
            {
                new Empresa { Id = 1, Nombre = "Google" },
                new Empresa { Id = 2, Nombre = "Facebook" }
            };
            empleados = new List<Empleado>
            {
                new Empleado { Id = 1, Cargo = "Programador", EmpresaId = 1, Nombre = "Jorge", Salario = 1200 },
                new Empleado { Id = 2, Cargo = "CEO", EmpresaId = 1, Nombre = "Joel", Salario = 1200 },
                new Empleado { Id = 3, Cargo = "Analista", EmpresaId = 2, Nombre = "Kate", Salario = 1200 },
                new Empleado { Id = 4, Cargo = "Administrador", EmpresaId = 2, Nombre = "Luis", Salario = 1200 },
                new Empleado { Id = 5, Cargo = "Programador Senior", EmpresaId = 1, Nombre = "Emely", Salario = 1200 }
            };
            //TestEmpresa();
            //EmpleadosOrdenados();
            ObtenerEmpresas();
        }

        public static void TestEmpresa() {

            IEnumerable<Empleado> query = from empleado in empleados where empleado.Cargo == "CEO" select empleado;
            LinqExample<Empleado>.PrintDatosObjetos(query);

        }

        public static void EmpleadosOrdenados()
        {
            IEnumerable<Empleado> empleadosOrdenados = from empleado in empleados orderby empleado.Nombre descending select empleado;
            LinqExample<Empleado>.PrintDatosObjetos(empleadosOrdenados);

        }
        public static void ObtenerEmpresas()
        {
            IEnumerable<Empleado> query = from empleado in empleados
                                          join empresa in empresas on empleado.EmpresaId equals empresa.Id
                                          where empresa.Nombre == "Facebook"
                                          select empleado;
            Console.WriteLine("Los siguientes empleados trabajan en Facebook");
            LinqExample<Empleado>.PrintDatosObjetos(query);

        }
    }
}

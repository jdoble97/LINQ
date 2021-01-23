using Fundamentos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Fundamentos.LINQ
{
    public class LinqExample<T>
    {

        public static void FindEvenNumbers(int[] source)
        {
            IEnumerable<int> numbers = from num in source where num % 2 == 0 select num;
            Print((IEnumerable<T>)numbers);
        }

        public static void Print(IEnumerable<T> source)
        {
            
            foreach(T item in source)
            {
                Console.WriteLine(item);
            }
        }

        public static void PrintDatosObjetos(IEnumerable<IPrint> source)
        {
            foreach (IPrint item in source)
            {
                item.PrintDatos();
            }
        }
    }
}

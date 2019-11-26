using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp483.ConsoleApp.Tipos.TipoValor
{
    class Inteiros
    {
        public void Executar()
        {
            Console.WriteLine($"byte max {byte.MaxValue}");
            Console.WriteLine($"byte min {byte.MinValue}");
            Console.WriteLine();

            Console.WriteLine($"Byte max (.NET) {Byte.MaxValue}");
            Console.WriteLine($"Byte min (.NET) {Byte.MinValue}");
            Console.WriteLine();


            Console.WriteLine($"Short max {short.MaxValue}");
            Console.WriteLine($"Int16 min (.NET) {Int16.MinValue}");
            Console.WriteLine();

            Console.WriteLine($"Byte max {short.MaxValue}");
            Console.WriteLine($"Byte min (.NET) {Int16.MinValue}");
            Console.WriteLine();
            Console.ReadLine();
        }

    }
}

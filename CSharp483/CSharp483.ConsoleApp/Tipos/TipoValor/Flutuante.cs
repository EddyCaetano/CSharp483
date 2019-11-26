using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp483.ConsoleApp.Tipos.TipoValor
{
    class Flutuante
    {
        public void Executar()
        {
            float numeroComVirgula = 10.01f;
            Console.WriteLine(numeroComVirgula);
            Console.WriteLine($"Single min valor {float.MinValue}");
            Console.WriteLine($"Single max valor {Single.MaxValue}");
            Console.WriteLine();

            Console.WriteLine($"double min valor {double.MinValue}");
            Console.WriteLine($"Double(.NET) max valor {Double.MaxValue}");
            Console.WriteLine();

            Console.WriteLine($"decimal min valor {decimal.MinValue}");
            Console.WriteLine($"Decimal max valor {Decimal.MaxValue}");

        }

    }
}

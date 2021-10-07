using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteCalculadoraConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            ReferenciaCalculadora.CalculadoraSoapClient calculadora = new ReferenciaCalculadora.CalculadoraSoapClient();

            Console.WriteLine(calculadora.Sumar(1, 2));
            Console.WriteLine(calculadora.Restar(7, 5));
            Console.WriteLine(calculadora.Multiplicar(2, 3));
        }
    }
}

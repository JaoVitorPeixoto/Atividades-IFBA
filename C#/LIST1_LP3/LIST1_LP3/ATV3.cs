using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIST1_LP3
{
    internal class ATV3
    {
        static public void Main(string[] args)
        {

            double peso, altura, imc;

            Console.Write("Informe seu peso: ");
            peso = double.Parse(Console.ReadLine());
            //peso = 69;
            Console.Write("Informe sua altura: ");
            altura = double.Parse(Console.ReadLine());
            //altura = 1.90 tem que escrever com virgula no terminal;

            imc = peso / (altura * altura);

            Console.WriteLine("Com o peso {0}kg e a altura {1}cm, você terá um IMC de {2}", peso, altura, imc);

        }
    }
}

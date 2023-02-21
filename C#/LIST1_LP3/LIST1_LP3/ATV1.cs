using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIST1_LP3
{
    class ATV1
    {
        static public void Main(string[] args)
        {
            int idade1, idade2, idade3;

            Console.Write("Informe a idade 1 = ");
            idade1 = int.Parse(Console.ReadLine());
            Console.Write("Informe a idade 2 = ");
            idade2 = int.Parse(Console.ReadLine());
            Console.Write("Informe a idade 3 = ");
            idade3 = int.Parse(Console.ReadLine());

            float media = (idade1 + idade2 + idade3) / 3f;
            Console.WriteLine("--------------------------");

            Console.WriteLine("A média das idades {0}, {1} e {2} é igual à {3}", idade1, idade2, idade3, media);

        }
    }
}

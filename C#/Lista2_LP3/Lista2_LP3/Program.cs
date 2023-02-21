using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_LP3
{
    
    class Program
    {
        //  MÉTODO DA QUESTÃO 1
        static void Questao1(){

            Console.WriteLine(" ");
            Console.WriteLine("_-_-_-_-_-_-QUESTÃO 1-_-_-_-_-_-_");
            Console.WriteLine(" ");

            Console.Write("Informe um número para saber seu fatorial: ");
            int num = int.Parse(Console.ReadLine());
            int n = num;

            while (n != 1)
            {    
                n -= 1;
                num *= n; 
            }

            Console.WriteLine("-------------------------");
            Console.WriteLine("O fatorial é: " + num);

        }

        //  MÉTEDO DA QUESTÃO 2
        static void Questao2()
        {

            Console.WriteLine(" ");
            Console.WriteLine("_-_-_-_-_-_-QUESTÃO 2-_-_-_-_-_-_");
            Console.WriteLine(" ");

            Console.Write("Os multiplos de 17 e 31 compreendidos no intervalo entre 500 e 1000 são: ");

            for (int i = 500; i <= 1000; i++)
            {
                if (i % 17 == 0 || i % 31 == 0)
                {
                    Console.Write($"{i} ");
                }

            }
        }

        //  MÉTODO DA QUESTÃO 3
        static void Questao3()
        {

            Console.WriteLine(" ");
            Console.WriteLine("_-_-_-_-_-_-QUESTÃO 3-_-_-_-_-_-_");
            Console.WriteLine(" ");

            double c;

            Console.WriteLine("Graus °F |  Graus °C");
            Console.WriteLine("----------------------");
            for (int i = 50; i <= 65; i++)
            {
             c = 5 / 9f * (i - 32);

                Console.WriteLine($"{i}°F     |    {c:f}°C");
            }
        }

        //  MÉTODO DA QUESTÃO 4
        static void Questao4()
        {

            Console.WriteLine(" ");
            Console.WriteLine("_-_-_-_-_-_-QUESTÃO 4-_-_-_-_-_-_");
            Console.WriteLine(" ");

            int voto = 100;
            int c1 = 0, c2 = 0, c3 = 0, c4 = 0, nulo = 0, branco = 0, totalvotos = 0;

            while (voto != 0)
            {

                Console.WriteLine("-=-=-=-=-=VOTAÇÃO=-=-=-=-=-");
                Console.WriteLine("Candidato     |   Número");
                Console.WriteLine("---------------------------");

                for (int i = 1; i<5; i++)
                {
                    Console.WriteLine($"Candidato {i}   |    {i}");
                }

                Console.WriteLine(" ");
                Console.WriteLine("Informe 5 para voto nulo e 6 para voto em branco");
                Console.WriteLine("-------------------------------------------------");

                Console.Write("Escolha seu candidato <0 - parar a votação>: ");
                voto = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");

                switch (voto)
                {
                    case 0:
                        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                        Console.WriteLine("         FIM DA VOTAÇÃO");
                        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                        break;

                    case 1:
                        c1++;
                        totalvotos++;
                    break;
                        
                    case 2:
                        c2++;
                        totalvotos++;
                    break;

                    case 3:
                        c3++;
                        totalvotos++;
                    break;

                    case 4:
                        c4++;
                        totalvotos++;
                    break;

                    case 5:
                        nulo++;
                        totalvotos++;
                    break;

                    case 6:
                        branco++;
                        totalvotos++;
                    break;

                    default:
                        Console.WriteLine("Por favor, informe corretamente!!");
                        Console.WriteLine("--------------------------------------------");
                    break;
                }

            }

            Console.WriteLine(" ");
            Console.WriteLine("-=-=-=-=-=RESULTADO=-=-=-=-=-");
            Console.WriteLine("Escolhas     |   QTD Votos");
            Console.WriteLine("---------------------------");

            Console.WriteLine($"Candidato 1   |    {c1}");
            Console.WriteLine($"Candidato 2   |    {c2}");
            Console.WriteLine($"Candidato 3   |    {c3}");
            Console.WriteLine($"Candidato 4   |    {c4}");
            Console.WriteLine($"Votos nulos   |    {nulo}");
            Console.WriteLine($"votos brancos |    {branco}");
            Console.WriteLine(" ");

            Console.WriteLine($"Foram um total de {totalvotos} votos contabilizados;");
            Console.WriteLine($"A porcentagem de votos em branco foi de {branco * 100 / totalvotos}%;");
            Console.WriteLine($"A porcentagem de votos nulos foi de {nulo * 100 / totalvotos}%.");




        }

        static void Main(String[] args)
        {
            // CHAMANDO QUESTÃO 1
            Questao1();

            Console.WriteLine(" ");    
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine(" ");

            //  CHAMANDO QUESTÃO 2
            Questao2();

            Console.WriteLine(" ");
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine(" ");

            //  CHAMANDO QUESTÃO 3
            Questao3();

            Console.WriteLine(" ");
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine(" ");

            //  CHAMANDO QUESTÃO 4
            Questao4();
        }
    }
}

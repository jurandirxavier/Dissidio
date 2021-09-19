using System;

namespace Dissidio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine();      
                      
            Console.WriteLine("Digite o valor do salário: ");
            float salario = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do aumento: ");
            float aumentoSalarial = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do dissídio: ");
            float percentDissidio = float.Parse(Console.ReadLine());
            float dissidio = percentDissidio / 100;

            if (aumentoSalarial != 0 && percentDissidio != 0)
            {
                salario = aumentoSalarial + (salario * (1 + dissidio));
                Console.WriteLine(salario);
            }
            else if (aumentoSalarial != 0)
            {
                salario = salario + aumentoSalarial;
                Console.WriteLine(salario);
            }
            else if (percentDissidio != 0)
            {
                salario = (salario * (1 + dissidio));
                Console.WriteLine(salario);
            }

            else
                Console.WriteLine(salario);

            Console.ReadKey();
        }
    }
}

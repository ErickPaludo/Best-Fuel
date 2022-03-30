using System;
using System.Globalization;

namespace Best_Fuel
{
    class Program
    {
        static void Main(string[] args)
        {
            Part_1 extencion;
            extencion = new Part_1();
            int x = 1;
            while (x == 1)
            {
                Console.Write("Informe a média de Km/L do veículo: ");
                double média = double.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.Write("Informe a o preço do combustível: R$ ");
                double preço = double.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.Write("Informe a Quilometragem que deseja percorrer: ");
                int distancia = int.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.Write("Qual é a capacidade do tanque do véiculo: ");
                double tanque = double.Parse(Console.ReadLine());

                Console.WriteLine();

                extencion.Calc(média, preço, distancia, tanque);
                Console.WriteLine(extencion);

                Console.WriteLine();

                Console.WriteLine("Executar outra viagem? (Sim = 1) (Não = 0)");
                int y = int.Parse(Console.ReadLine());
                if (y == 1)
                {
                    Console.Clear();
                }
                else
                {
                    x = 0;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" -Beta 1.1- -Project_Best_Fuel-");
                    Console.WriteLine();
                    Console.WriteLine("* Alterações no código Km/l de int para double;");
                    Console.WriteLine();
                    Console.WriteLine("* Alteração no Icone;");
                    Console.WriteLine();
                    Console.WriteLine("+ Função tanque foi adicionada; ");

                }
            }

        }
    }
}
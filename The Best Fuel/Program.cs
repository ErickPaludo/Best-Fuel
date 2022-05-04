using System;
using System.Collections.Generic;

namespace Best_Fuel
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Part_1> list = new List<Part_1>();
            int x = 1;
            while (x == 1)
            {
                double pedagio = 0;
                // 1.1
                Console.Write("Informe a média de Km/L do veículo: ");
                double média = double.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.Write("Informe o preço do combustível: R$ ");
                double preço = double.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.Write("Informe a Quilometragem que deseja percorrer: ");
                int distancia = int.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.Write("Qual é a capacidade do tanque do véiculo: ");
                double tanque = double.Parse(Console.ReadLine());
                Console.WriteLine();

                // início pedágio 1.2

                Console.Write("Deseja Incluir pedágio (1 = Sim / 0 = Não)? ");

                int resp = int.Parse(Console.ReadLine());
                int sim = 1;              
                
                if(resp == sim)
                {
                    Console.Clear();
                    Console.Write("Qual é a quantidade de pedágios para a ida? ");
                    int quant = int.Parse(Console.ReadLine());
                    int cont = 1;
                    Console.WriteLine();
                    for (int i = 0; i < quant; i++)
                    {  
                        Console.Write("Digite o valor do pedágio [{0}]: R$ ", cont);
                        cont = cont + 1;
                        double ped = double.Parse(Console.ReadLine());
                        pedagio = ped + pedagio;       
                        Console.WriteLine();
                    }
                    list.Add(new Part_1(média, preço, distancia, tanque, pedagio));
                }
                else
                {                   
                    list.Add(new Part_1(média, preço, distancia, tanque, pedagio));
                }

                
                foreach (Part_1 obj in list)
                {
                    Console.Clear();
                    Console.WriteLine(obj);
                }
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
                }
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--------------------------------");
            Console.WriteLine(" -Beta 1.2- -Project_Best_Fuel-");
            Console.WriteLine();
            Console.WriteLine("+ Função pedágio foi adicionada; ");
            Console.WriteLine("--------------------------------");
            Console.WriteLine(" -Beta 1.1- -Project_Best_Fuel-");
            Console.WriteLine();
            Console.WriteLine("* Alteração no Icone;");
            Console.WriteLine("+ Função tanque foi adicionada; ");
            Console.WriteLine("--------------------------------");
            Console.WriteLine(" -Beta 1.0- -Project_Best_Fuel-");
            Console.WriteLine();
            Console.WriteLine("* Alterações no código Km/l de int para double;");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Created by: Érick Paludo.");
            int final = int.Parse(Console.ReadLine());
        }
    }
}
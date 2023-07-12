// See https://aka.ms/new-console-template for more information
using System;


namespace Calculator
{
    class program
    {
        static void Main(string[] args)
        {
            // Subtracao();
            // Divisao();
            // Multiplicacao();
            Menu();

        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Qual a operação desejada?");
            Console.WriteLine("Digite 1 para Soma");
            Console.WriteLine("Digite 2 para Subtração");
            Console.WriteLine("Digite 3 para Multiplicação");
            Console.WriteLine("Digite 4 para Divisão");
            Console.WriteLine("Digite 5 para Sair");


            Console.WriteLine("------------------------------");
            short res = Convert.ToByte(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;

            }

        }
        static void Soma()
        {

            Console.Clear();

            Console.WriteLine("Primeiro valor :");
            float v1 = Convert.ToSingle(Console.ReadLine());


            Console.WriteLine("Segundo valor: ");
            float v2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 + v2;


            Console.WriteLine("o resultado da soma é: " + resultado);
            //Outra maneira de printar o resultado
            Console.WriteLine($"O resultado é:{resultado}");
            //ou melhor ainda
            Console.WriteLine($"O resultado é :{v1 + v2}");
            Console.ReadKey();

            Menu();


        }
        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor :");
            float v1 = Convert.ToSingle(Console.ReadLine());


            Console.WriteLine("Segundo valor: ");
            float v2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 - v2;


            Console.WriteLine("o resultado da subtração é: " + resultado);
            //Outra maneira de printar o resultado
            Console.WriteLine($"O resultado é:{resultado}");
            //ou melhor ainda
            Console.WriteLine($"O resultado é :{v1 - v2}");
            Console.ReadKey();

            Menu();

        }
        static void Divisao()

        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor");
            float v1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor");
            float v2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 / v2;


            Console.WriteLine($"O valor da divisão é {resultado}");
            Console.ReadKey();


        }
        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor");
            float v1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor");
            float v2 = Convert.ToSingle(Console.ReadLine());

            float resultado = v1 * v2;

            Console.WriteLine("");

            Console.WriteLine($"O resultado é {resultado}");
            Console.ReadKey();

            Menu();
        }


    }
}

using System;
using System.Security.AccessControl;

namespace Emprestimos.Models
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Nome do cliente:");

            string nome = Console.ReadLine();

            Console.WriteLine("Digite o valor da compra:");

            double valor = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a condição de pagamento: 1 até 5X:");

            Console.WriteLine("1 - A vista");
            Console.WriteLine("2 - 2X");
            Console.WriteLine("3 - 3x");
            Console.WriteLine("4 - 4x");
            Console.WriteLine("5 - 5x");


            int condicao = Convert.ToInt32(Console.ReadLine());
            double valorCondicao = (valor) / (condicao);

            switch (valorCondicao)
            {
                case 1:
                    valorCondicao = valor / 0;
                    break;

                case 2:

                    valorCondicao = valor / 2;
                    break;
                case 3:

                    valorCondicao = valor / 3;
                    break;
                case 4:

                    valorCondicao = valor / 4;
                    break;
                case 5:

                    valorCondicao = valor / 5;
                    break;
            }

            if (valorCondicao == 1)
            {
                Console.WriteLine("O valor da sua compra a vista é R$ " + valorCondicao);
            }

            else
            {
                Console.WriteLine("Sua compra fica parcelada em " + condicao + " x de R$" + valorCondicao + " sem juros");
            }




            //if (condicao == 1)
            //{
            //    Console.WriteLine("O valor à vista é" + valor);
            //}

            //else if (condicao == 2)
            //{
            //    Console.WriteLine("2x de " + valor / 2);
            //}

            //else if (condicao == 3)
            //{
            //    Console.WriteLine("3x de " + valor / 3);
            //}

            //else if (condicao == 4)
            //{

            //    Console.WriteLine("4x de " + valor / 4);

            //}

            //else if (condicao == 5)
            //{

            //    Console.WriteLine("5x de " + valor / 5);

            //}

            //else
            //{

            //    Console.WriteLine("Condição inexistente");

            //}

        }






    }
}
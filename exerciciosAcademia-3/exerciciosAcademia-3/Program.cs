using System;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;

namespace academiaexercicios_3
{

    internal class program
    {
        static public void Main(string[] args)
        {

            //1. Faça um programa em VS que solicite um número inteiro positivo ao usuário, validando a entrada de dados 
            //(informando se ele estiver errado e repetindo a solicitação até que esteja correto). 
            //Após o programa em VS deve informar todos os números pares existentes entre 1 e o número fornecido pelo usuário.

            //Exemplo:
            //            Digite um número inteiro positivo: -8
            //Valor incorreto!
            //Digite um número inteiro positivo: 8
            //Numero digitado: 8
            //Números inteiros pares entre 1 e 8: 2, 4, 6.

            //int x = 0;
            //int cont = 0;
            //Console.WriteLine("Entre com um número inteiro positivo: ");
            //x = int.Parse(Console.ReadLine());

            // while (x < 0)
            // {
            //     Console.WriteLine("Valor incorreto !");
            //     Console.WriteLine("Entre com um número inteiro positivo: ");
            //     x = int.Parse(Console.ReadLine());
            // }

            // Console.WriteLine("Número digitado: " + x);

            // if (x % 2 == 0)
            // {
            //     Console.Write("Números inteiros pares entre 1 e " + x+ ": ");
            //     for (int i = 1; i <= x; i++)
            //     {
            //         if(i % 2 == 0)
            //         {
            //             Console.Write(i + ", ");
            //         }

            //     }
            // }


            //2.Modificar o programa em VS anterior para que ao final ele pergunte ao usuário se ele deseja
            //informar um outro número. Caso positivo, o programa em VS deve ser repetido.

            //Exemplo:
            //            Digite um número inteiro positivo: 8
            //Numero digitado: 8
            //Números inteiros pares entre 1 e 8: 2, 4, 6.

            //Deseja informar outro número(s/ n)? S

            //Digite um número inteiro positivo: 12
            //Numero digitado: 20
            //Números inteiros pares entre 1 e 8: 2, 4, 6, 8, 10.

            //Deseja informar outro número(s/ n)? N


            //1. Faça um programa em VS que solicite um número inteiro positivo ao usuário, validando a entrada de dados 
            //(informando se ele estiver errado e repetindo a solicitação até que esteja correto). 
            //Após o programa em VS deve informar todos os números pares existentes entre 1 e o número fornecido pelo usuário.

            //Exemplo:
            //            Digite um número inteiro positivo: -8
            //Valor incorreto!
            //Digite um número inteiro positivo: 8
            //Numero digitado: 8
            //Números inteiros pares entre 1 e 8: 2, 4, 6.

            //int x = 0;
            //int cont = 0;
            //Console.WriteLine("Entre com um número inteiro positivo: ");
            //x = int.Parse(Console.ReadLine());

            //while (x < 0)
            //{
            //    Console.WriteLine("Valor incorreto !");
            //    Console.WriteLine("Entre com um número inteiro positivo: ");
            //    x = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Número digitado: " + x);

            //if (x % 2 == 0)
            //{
            //    Console.Write("Números inteiros pares entre 1 e " + x + ": ");
            //    for (int i = 1; i < x; i++)
            //    {
            //        if (i % 2 == 0)
            //        {
            //            Console.Write(i + ", ");
            //        }

            //    }
            //}

            //3.Fazer um laço(repetição) que fique solicitando números ao usuário. 
            //Se o usuário digitar 0 o programa em VS deve parar. 
            //Caso contrário, o programa em VS deve informar se o número é par ou ímpar e se ele é um número primo.

            //int x;

            //do
            //{
            //    Console.WriteLine("Entre com um número: ");
            //    x = int.Parse(Console.ReadLine());

            //    if (x == 0)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        if(x % 2 == 0)
            //        {
            //            Console.WriteLine("Número é par ! \n");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Número é ímpar ! ");
            //        }

            //            double count = 0;

            //            for (int i = 1; i <= x; i++)
            //            {
            //                if (x % i == 0)
            //                {
            //                    count++;
            //                }                            
            //             }

            //        if (count == 2)
            //        {
            //            Console.WriteLine("Número é primo!!!");
            //        }

            //    }

            //} while (true);


            //4.Em uma cidadezinha do interior há dois candidatos para prefeito(JOAO e ZECA).
            //Você foi contratado para fazer um programa em VS que conte os votos dos candidatos.
            //Cada vez que o usuário digitar JOAO, você deve somar um ao seu número de votos.O mesmo para ZECA. 
            //Você também pode aceitar votos em branco(palavra BRANCO).O programa em VS termina quando o usuário
            //escrever FIM.Ao final devem ser mostradas as quantidades de votos para cada um dos candidatos e o número
            //de votos em branco. 

            String voto;
            int branco = 0, joao = 0, zeca = 0;
            do
            {
                Console.WriteLine("Entre com seu voto: ");
                voto = Console.ReadLine();

                if (voto == "branco" && voto == "joao" && voto == "zeca")
                {
                    if (voto == "branco")
                    {
                        branco = branco+1;
                    }
                    if (voto == "joao")
                    {
                        joao = joao+1;
                    }
                    if (voto == "zeca")
                    {
                        zeca = zeca+1;
                    }   
                }
                

                if (voto == "fim")
                {
                    break;
                }

            }while (true);

            Console.WriteLine("Quantidade de votos pro joâo: " + joao);
            Console.WriteLine("Quantidade de votos pro zeca: "+ zeca);
            Console.WriteLine("Quantidade de votos brancos: "+ branco);




        }
    }
}
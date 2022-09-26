using System.Net;
using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace exerciciosAcademia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre dois números quaisquer.

            //float n1, n2;

            //Console.WriteLine("Digite um numero: ");
            //n1 = float.Parse(Console.ReadLine());

            //Console.WriteLine("Digite um segundo numero: ");
            //n2 = float.Parse(Console.ReadLine());

            //Console.WriteLine("A média aritmetica é de:" + ((n1 + n2) / 2));
            //Console.ReadKey();

            //2) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre quatro números quaisquer.

            //float n1, n2, n3, n4;

            //Console.WriteLine("Digite um numero: ");
            //n1 = float.Parse(Console.ReadLine());

            //Console.WriteLine("Digite um segundo numero: ");
            //n2 = float.Parse(Console.ReadLine());

            //Console.WriteLine("Digite um terceiro numero: ");
            //n3 = float.Parse(Console.ReadLine());

            //Console.WriteLine("Digite um quarto numero: ");
            //n4 = float.Parse(Console.ReadLine());

            //Console.WriteLine("A media aritmetica é: " + ((n1+n2+n3+n4)/4));

            //3) Escreva a seqüência de atribuições, em forma de programa em C# e no Visual Studio, para trocar entre 
            //si os valores de duas variáveis A e B.

            //int a, b, temp;
            //temp = 0;
            //a = 2;
            //b = 3;

            //Console.WriteLine("Valores iniciais de A " + a);
            //Console.WriteLine("Valores iniciais de B " + b);

            //temp = a;
            //a = b;
            //b = temp;
            //Console.WriteLine("Valores invertidos de A " + a);
            //Console.WriteLine("Valores invertidos de B " + b);

            // 4) Faça um programa em C# e no Visual Studio que receba a data na forma DDMMAAAA e imprima na 
            //forma AAAAMMDD e AAMMDD.Note que o dia, o mês e o ano devem ser lidos em variáveis diferentes.

            //string data,dia,mes,ano;

            //Console.WriteLine("Entre com uma Data em forma de DDMMAAAA");
            //data = Console.ReadLine();
            //dia = data.Substring(0, 2);
            //mes = data.Substring(2, 2);
            //ano = data.Substring(4);

            //ano = ano.Substring(2);



            //Console.WriteLine("A data em formato de AAMMDD: " + ano +"/"+ mes+"/"+dia);


            //5) Escreva um programa em C# e no Visual Studio para calcular o consumo médio de um automóvel 
            //(medido em Km / l), sendo que são conhecidos a distância total percorrida e o volume de combustível
            //consumido para percorrê-la(medido em l).

            //float km, l;

            //Console.WriteLine("Entre com os km percorridos: ");
            //km = float.Parse(Console.ReadLine());   
            //Console.WriteLine("Entre com o volume em litros utilizados: ");
            //l = float.Parse(Console.ReadLine());        

            //Console.WriteLine("A media de consumo de combustível é de: " + (km/l)+ "km/l");

            // 6) Escreva um programa em C# e no Visual Studio que leia os dados para o parafuso A e para o parafuso B, 
            //isto é, o código, a quantidade de peças e o valor unitário de cada parafuso e a porcentagem
            //de IPI(única) a ser acrescentada.

            //int codA, codB, qA, qB;
            //float valorA, valorB, ipi, acrescimoA, acrescimoB,totalA,totalB;

            //Console.WriteLine("Entre com o codigo do parafuso A: ");
            //codA = int.Parse(Console.ReadLine());
            //Console.WriteLine("Entre com valor do parafuso A:");
            //valorA = int.Parse(Console.ReadLine()); 
            //Console.WriteLine("Qual a quantidade de parafusos A: ");
            //qA = int.Parse(Console.ReadLine()); 

            //Console.WriteLine("Entre com o codigo do parafuso B: ");
            //codB = int.Parse(Console.ReadLine());
            //Console.WriteLine("Entre com o valor do parafuso B: ");
            //valorB = int.Parse(Console.ReadLine()); 
            //Console.WriteLine("Qual a quantidade de parafusos B: ");
            //qB = int.Parse(Console.ReadLine()); 

            //Console.WriteLine("Valor em porcentagem do IPI: ");
            //ipi = int.Parse(Console.ReadLine());

            //acrescimoA = valorA * (ipi / 100);
            //acrescimoB = valorB * (ipi / 100);

            //totalA = valorA + acrescimoA;
            //totalB = valorB + acrescimoB;

            //Console.WriteLine("Valor IPI: " + ipi+"%");


            //Console.WriteLine("Codigo A: " + codA);
            //Console.WriteLine("Valor unitario parafuso A: " + valorA + "R$");
            //Console.WriteLine("Valor a ser acrescentado: " + acrescimoA + "R$");
            //Console.WriteLine("Valor total: " + totalA + "R$");

            //Console.WriteLine("----------------------------------------");

            //Console.WriteLine("Codigo B: " + codB);
            //Console.WriteLine("Valor unitario parafuso B: " + valorB + "R$");
            //Console.WriteLine("Valor a ser acrescentado: " + acrescimoB + "R$");
            //Console.WriteLine("Valor total: " + totalB + "R$");

            //7) Escreva um programa em C# e no Visual Studio que leia o número de um vendedor, o seu salário fixo, 
            //o total de vendas por ele efetuadas e o percentual que ganha sobre o total de vendas. 
            //Calcule o salário total do vendedor.Escreva o número do vendedor e o salário total do vendedor.

            //int num, tVendas;
            //float salarioF, porcVendas, salarioT;

            //Console.WriteLine("Entre com o número do vendedor: ");
            //num = int.Parse(Console.ReadLine());

            //Console.WriteLine("Salario Fixo do vendedor: ");
            //salarioF = float.Parse(Console.ReadLine());

            //Console.WriteLine("Porcentagem de ganho sobre o total de vendas: ");
            //porcVendas = float.Parse(Console.ReadLine()); 

            //Console.WriteLine("Total de vendas: ");
            //tVendas = int.Parse(Console.ReadLine());



            //salarioT = salarioF + (salarioF * (tVendas * (porcVendas/100)));

            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("Numero do vendedor: "+ num);
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("Salario Total: " + salarioT + "R$" );


            //8) Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit. 
            //A fórmula da conversão é F = (9 * C + 160) / 5.

            //float c, f;

            //Console.WriteLine("Entre com uma temperatura em Celsius: ");
            //c = float.Parse(Console.ReadLine());

            //f = ((9 * c) + 160) / 5;

            //Console.WriteLine("temperatura em  Fahrenheit: " + f + "°");

            //9) Uma loja vende seus produtos no sistema de entrada mais duas prestações, sendo a entrada maior
            //do que ou igual às prestações, que devem ser iguais, inteiras e as maiores possíveis.
            //Por exemplo, se o valor da mercadoria for R$ 270, 00, a entrada e as duas prestações são iguais a R$ 90, 00;
            //se o valor da mercadoria for R$ 302, 75 a entrada é de R$ 102, 75 e as duas prestações são iguais a R$ 100, 00.
            //Escreva um programa em C# e no Visual Studio que receba o valor da mercadoria e forneça o valor 
            //da entrada e das duas prestações, de acordo com as regras acima.
            //Observe que uma justificativa para a adoção desta regra é que ela facilita a confecção e o
            //conseqüente pagamento dos boletos das duas prestações.







        }
    }
}
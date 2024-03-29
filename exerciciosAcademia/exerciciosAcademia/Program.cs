﻿using System.Net;
using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Drawing;

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


            //float entrada, valor, sobra, prestacoes;


            //Console.Write("Entre com o valor do produto: R$");
            //valor = float.Parse(Console.ReadLine());

            //sobra = valor % 3;

            //valor = valor - sobra;

            //prestacoes = valor / 3;

            //entrada = prestacoes + sobra;

            //Console.WriteLine("Valor de entrada do produto: R$" + entrada );
            //Console.WriteLine("Valor das outras duas prestações do produto: R$" + prestacoes );

            //11) Escreva um algoritmo para ler o número de eleitores de um município,
            //o número de votos brancos, nulos e válidos. 
            //Calcule e escreva o percentual que cada um  representa em relação ao total de eleitores.


            //int nulos, brancos, validos, eleitores;
            //float porcNulo, porcBrancos, porcValidos,semVoto;

            //Console.WriteLine("Entre com a quantidadede de eleitores: ");
            //eleitores = int.Parse(Console.ReadLine());

            //Console.WriteLine("Entre com a quantidadede de votos validos: ");
            //validos = int.Parse(Console.ReadLine());

            //Console.WriteLine("Entre com a quantidadede de votos brancos: ");
            //brancos = int.Parse(Console.ReadLine());

            //Console.WriteLine("Entre com a quantidadede de votos nulos: ");
            //nulos = int.Parse(Console.ReadLine());


            //while ( (validos + brancos + nulos) > eleitores)
            //{

            //    Console.WriteLine("Entre com a quantidadede de votos validos: ");
            //    validos = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Entre com a quantidadede de votos brancos: ");
            //    brancos = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Entre com a quantidadede de votos nulos: ");
            //    nulos = int.Parse(Console.ReadLine());
            //}

            //porcNulo = (float)((nulos * 100) / eleitores);
            //porcValidos = (float)((validos*100)/ eleitores);
            //porcBrancos = (float)((brancos*100)/ eleitores);
            //semVoto = 100 - porcBrancos - porcNulo - porcValidos;


            //Console.WriteLine("Valor em porcento de votos Brancos: "+ porcBrancos + "%");
            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine("Valor em porcento de votos Nulos: "+porcNulo + "%");
            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine("Valor em porcento de votos validos: "+ porcValidos + "%");
            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine("Valor em porcento de pessoas que não votaram: " + semVoto+"%");
            //Console.WriteLine("-------------------------------------");


            //12) Um motorista de taxi deseja calcular o rendimento de seu carro na praça.Sabendo - se que o preço do combustível é de R$6,90, escreva um algoritmo para ler a
            //marcação do odômetro(marcador de quilometragem) no início do dia, a marcação no final do dia, o número de litros de combustível gasto e o valor total(R$) recebido
            //dos passageiros.Calcule e escreva a média do consumo em Km / l e o lucro líquido do dia.

            //Fórmulas: Total quilometragem = marcação odômetro final do dia - marcação odômetro inicio do dia

            //Média do consumo = Total quilometragem / quantidade de combustível gasto

            //Lucro do dia = Valor total recebido - (quantidade de combustível gasto * 6,90)

            //double km_inicial, km_final,km_total, preco, litros, valor_recebido, media, lucro;

            //preco = 6.90;

            //Console.WriteLine("Entre com a marcação inicial de KM: ");
            //km_inicial = double.Parse(Console.ReadLine());
            //Console.WriteLine("Entre com a marcação final de KM: ");
            //km_final = double.Parse(Console.ReadLine());
            //Console.WriteLine("Entre com a quantidade de litros utilizada: ");
            //litros = double.Parse(Console.ReadLine());
            //Console.WriteLine("Entre com o valor recebido pelos passageiros: ");
            //valor_recebido = double.Parse(Console.ReadLine());

            //km_total = km_final - km_inicial;

            //media = km_total / litros;

            //lucro = valor_recebido - (litros * preco);

            //Console.WriteLine("A media de consumo de KM/l é de: "+ media+"KM/L");
            //Console.WriteLine("Lucro liquido é de: R$"+ lucro);

            //13) Uma loja vende bicicletas com um acréscimo de 50 % sobre o preço de custo. Ela paga a cada vendedor 2 salários mínimos mensais, mais uma comissão de 15 % sobre o
            //preço de custo de cada bicicleta vendida. Desenvolva um algoritmo que leia o valor do salário mínimo, o preço de custo de cada bicicleta e o número de bicicletas
            //vendidas pelo vendedor, calcule e mostre: o salário do empregado


            //double salario_minimo, preco_custo, preco_venda, bike_vendidas, salario;


            //Console.Write("Entre com valor do salario minimo: R$");
            //salario_minimo = double.Parse(Console.ReadLine());
            //Console.Write("Entre com o preço de custo da bicicleta: R$");
            //preco_custo = double.Parse(Console.ReadLine());
            //Console.Write("Quantidade de bicicletas vendidas pelo vendedor: ");
            //bike_vendidas = double.Parse(Console.ReadLine());

            //preco_venda = preco_custo + (preco_custo / 2);

            //salario = (2 * salario_minimo) + ((0.15 * preco_venda)*bike_vendidas);

            //Console.WriteLine("O salario do empregado é de: R$" +  salario);
        }
    }
}
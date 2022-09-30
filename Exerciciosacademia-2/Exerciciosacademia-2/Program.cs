using System.Drawing;
using System;
using System.Net;
using System.Reflection.Emit;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.X86;
using System.IO;
using System.Runtime.ConstrainedExecution;
using System.Formats.Asn1;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Channels;
using System.Security.Cryptography;

namespace Exerciciosacademia_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 - Faça um algoritmo para calcular e mostrar a área de um triângulo a partir dos valores da base e da altura lidos pelo teclado: 
            //Área do triangulo = (base * altura) / 2;
            //Teste se a base ou a altura digitada não foi igual a zero.

            //float alturaT, baseT,areaT;

            //Console.WriteLine("Entre com a Base do triângulo: ");
            //baseT = float.Parse(Console.ReadLine());
            //Console.WriteLine("Entre com a altura do triângulo: ");
            //alturaT = float.Parse(Console.ReadLine());

            //if (alturaT == 0 || baseT == 0 )
            //{
            //    Console.WriteLine("Entre novamente com os numeros diferentes de zero !!!");
            //    Console.WriteLine("Entre com a Base do triângulo: ");
            //    baseT = float.Parse(Console.ReadLine());
            //    Console.WriteLine("Entre com a altura do triângulo: ");
            //    alturaT = float.Parse(Console.ReadLine());
            //}

            //areaT = (baseT * alturaT) / 2;

            //Console.WriteLine("Area do triângulo: " + areaT);

            //2 - Faça um algoritmo para ler um número e verificar se ele é par ou ímpar. 

            //int num;

            //Console.WriteLine("Entre com um valor: ");
            //num = int.Parse(Console.ReadLine());

            //if ( num % 2 == 0)
            //{
            //    Console.WriteLine("O número é par !!! ");
            //}
            //else
            //{
            //    Console.WriteLine("O número é ímpar !!!");
            //}

            // 3 - Escrever um algoritmo para ler quatro valores inteiros, calcular a sua média, e escrever na tela os que são superiores à média.

            //int n1, n2, n3, n4;
            //float media;

            //Console.WriteLine("Entre com um valor: ");
            //n1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Entre com um valor: ");
            //n2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Entre com um valor: ");
            //n3 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Entre com um valor: ");
            //n4 = int.Parse(Console.ReadLine());

            //media = (float)(n1 + n2 + n3 + n4) / 4;

            //Console.WriteLine("A media é de: " + media);

            //if (n1 > media) Console.WriteLine(n1 + " é maior que a média !!!");
            //if (n2 > media) Console.WriteLine(n2 + " é maior que a média !!!");
            //if (n3 > media) Console.WriteLine(n3 + " é maior que a média !!!");
            //if (n4 > media) Console.WriteLine(n4 + " é maior que a média !!!");


            //4 - Escrever um algoritmo para ler a quantidade de horas aula dadas por dois professores e o valor por hora recebido por cada um deles.
            // Mostrar na tela qual dos professores tem o maior salário total.

            //float horasA, horasB, valorA, valorB, salarioA, salarioB;

            //Console.WriteLine("Entre com a quantidade de horas dadas pelo professor A: ");
            //horasA = float.Parse(Console.ReadLine());

            //Console.WriteLine("Entre com o valor recebido por horas de aula do professor A: ");
            //valorA = float.Parse(Console.ReadLine());

            //Console.WriteLine("Entre com a quantidade de horas dadas pelo professor B: ");
            //horasB = float.Parse(Console.ReadLine());

            //Console.WriteLine("Entre com o valor recebido por horas de aula do professor B: ");
            //valorB = float.Parse(Console.ReadLine());

            //salarioA = horasA * valorA;
            //salarioB = horasB * valorB;

            //if (salarioA == salarioB) Console.WriteLine("Ambos possuem o mesmo salario: R$" + salarioA);

            //else if (salarioA > salarioB) Console.WriteLine("Professor A possui maior salario: R$" + salarioA);

            //else Console.WriteLine("Professor B possui maior salario: R$" + salarioB);


            //5 - Escrever um algoritmo para ler duas notas de um aluno e escrever na tela a palavra “Aprovado” 
            //se a média das duas notas for maior ou igual a 7, 0.
            //Caso a média seja inferior a 7,0, o programa deve ler a nota do exame e calcular a média final,
            //é a média entre a nota do exame e a média das 2 notas.
            //Se esta média final for maior ou igual a 5, 0, o programa deve escrever “Aprovado”, caso contrário deve
            //escrever “Reprovado”.

            //float n1, n2, media, exame;

            //Console.WriteLine("Entre com a nota da primeira prova: ");
            //n1 = float.Parse(Console.ReadLine());

            //Console.WriteLine("Entre com a nota da segunda prova: ");
            //n2 = float.Parse(Console.ReadLine());

            //media = (n1 + n2) / 2;

            //if (media >= 7) Console.WriteLine("APROVADO!!!");
            //else
            //{
            //    Console.WriteLine("Nota do exame: ");
            //    exame = float.Parse(Console.ReadLine());
            //    float media_final = (media + exame) / 2;

            //    if (media_final >= 5) Console.WriteLine("APROVADO!!!");
            //    else Console.WriteLine("REPROVADO!!!");

            //}

            //6 - Faça um programa em C# e no Visual Studio para receber o nome (totalmente em maiúsculo), a altura (metros) e o peso (kg) de uma pessoa.
            //O programa deve calcular o Indice de Massa Corpórea(IMC), exibi - lo ao usuário e informar sua situação conforme a tabela.
            //O cálculo do imc = peso / (altura * altura)

            //IMC
            //menor que 18->baixo peso
            //maior que 18 e menor que 25->peso normal
            //maior que 25 e menor que 30->sobrepeso
            //maior que 30 e menor que 35->obesidade
            //maior que 35->obesidade grau sério

            //string nome;
            //float altura, peso, IMC;

            //Console.WriteLine("Entre com seu nome: ");
            //nome = Console.ReadLine();

            //nome = nome.ToUpper();

            //Console.WriteLine("Entre com sua altura em metros: ");
            //altura = float.Parse(Console.ReadLine());

            //Console.WriteLine("Entre com seu peso em KG: ");
            //peso = float.Parse(Console.ReadLine());

            //IMC = peso / (altura * altura);

            //if (IMC < 18)
            //{
            //    Console.WriteLine(nome);
            //    Console.WriteLine("ALTURA --->" + altura);
            //    Console.WriteLine("PESO ---> " + peso);
            //    Console.WriteLine("IMC é de: "+IMC);
            //    Console.WriteLine("Baixo peso !");
            //}

            //else if (18 < IMC && IMC < 25)
            //{
            //    Console.WriteLine(nome);
            //    Console.WriteLine("ALTURA --->" + altura);
            //    Console.WriteLine("PESO ---> " + peso);
            //    Console.WriteLine("IMC é de: "+IMC);
            //    Console.WriteLine("Peso Normal");
            //}
            //else if (25 < IMC && IMC < 30)
            //{
            //    Console.WriteLine(nome);
            //    Console.WriteLine("ALTURA --->" + altura);
            //    Console.WriteLine("PESO ---> " + peso);
            //    Console.WriteLine("IMC é de: "+IMC);
            //    Console.WriteLine("Sobrepeso");
            //}
            //else if (30 < IMC && IMC < 35)
            //{
            //    Console.WriteLine(nome);
            //    Console.WriteLine("ALTURA --->" +altura);
            //    Console.WriteLine("PESO ---> " +peso);
            //    Console.WriteLine("IMC é de: "+IMC);
            //    Console.WriteLine("Obesidade");
            //}
            //else 
            //{
            //    Console.WriteLine(nome);
            //    Console.WriteLine("ALTURA --->" +altura);
            //    Console.WriteLine("PESO ---> " +peso);
            //    Console.WriteLine("IMC é de: "+IMC);
            //    Console.WriteLine("Grau serio !!!");
            //}


            //7 - Faça um programa em C# e no VS para receber uma frase qualquer e uma palavra de pesquisa.
            //O programa deve avaliar se a palavra aparece na frase, informando o usuário via mensagem, como por
            //exemplo, A palavra encontra-se na frase   ou A palavra não se encontra na frase.

            //string palavra, frase;

            //Console.Write("Digite uma frase: ");
            //frase = Console.ReadLine();

            //Console.Write("Digite palavra: ");
            //palavra = Console.ReadLine();

            //if (frase.Contains(palavra))
            //{
            //    Console.WriteLine("A palavra se encontra na frase ! ");
            //}
            //else
            //{
            //    Console.WriteLine("A palavra não se encontra na frase !");
            //}

            //8 - Faça um programa no VS que receba o código, nome, salário base e o total de vendas de um funcionário.
            //Caso o total de vendas seja acima de R$ 500,00, adicionar ao seu salário final 5 % do total de vendas.
            //Caso o total de vendas seja mais que R$ 1000,00, adicionar ao seu salário final 7 % do total de vendas.
            //E por fim, se o total de vendas seja maior que R$ 5000,00, adicionar ao seu salário final 10 % do
            //                total de vendas.

            //int cod;
            //double salarioBase, Tvendas, salarioFinal;
            //string nome;


            //Console.WriteLine("Entre com seu nome: ");
            //nome = Console.ReadLine();

            //Console.WriteLine("Entre com seu codigo: ");
            //cod = int.Parse(Console.ReadLine());

            //Console.WriteLine("Entre com seu salario base: ");
            //salarioBase = float.Parse(Console.ReadLine());

            //Console.WriteLine("Entre com seu total de vendas: ");
            //Tvendas = int.Parse(Console.ReadLine());


            //if (0 < Tvendas && Tvendas <= 500)
            //{
            //    Console.WriteLine("não recebe nada adicional");
            //}
            //else if (500 < Tvendas && Tvendas < 1000)
            //{
            //    salarioFinal = salarioBase + (Tvendas * 0.05);
            //    Console.WriteLine("recebe 5%");
            //}
            //else if (1000 < Tvendas && Tvendas < 5000)
            //{
            //    salarioFinal = salarioBase + (Tvendas * 0.07);
            //    Console.WriteLine("recebe 7%");
            //}
            //else if (Tvendas > 5000)
            //{
            //    Console.WriteLine("recebe 10%");
            //    salarioFinal = salarioBase + (Tvendas * 0.1);
            //}

            //Console.WriteLine(nome);
            //Console.WriteLine("----------------------------");
            //Console.WriteLine("Seu salario base: R$" + salarioBase);
            //Console.WriteLine("----------------------------");
            //Console.WriteLine("Seu codigo: "+ cod);
            //Console.WriteLine("----------------------------");
            //Console.WriteLine("Seu total de vendas: R$"+ Tvendas);
            //Console.WriteLine("----------------------------");
            //Console.WriteLine("Seu salario final: R$" + salarioFinal);

            //9 - Faça um programa no VS que receba do usuário 3 valores de glicemia em jejum, representando a medição
            //diária de um paciente diabético. Para cada valor recebido analisar e informar ao paciente o seguinte:
            //Se o valor diário for menor que 65, avisá - lo que corre risco de hipoglicemia
            //Se o valor diário for maior que 250, avisá - lo que corre risco de hiperglicemia.
            //Além disso, o programa deve fazer a média dos 3 valores de glicemia coletados. E se a média for
            //menor que 80, avisá - lo que é preciso diminuir 2 unidades de insulina.Se a média for maior que
            //150, avisá - lo que será necessário adicionar 2 unidades de insulina.


            //float n1, n2, n3, diaria, media;

            //Console.WriteLine("Entre com o valor de glicemia em jejum: ");
            //n1 = float.Parse(Console.ReadLine());
            //Console.WriteLine("Entre com o valor de glicemia em jejum: ");
            //n2 = float.Parse(Console.ReadLine());
            //Console.WriteLine("Entre com o valor de glicemia em jejum: ");
            //n3 = float.Parse(Console.ReadLine());

            //diaria = n1 + n2 + n3;
            //media = (n1 + n2 + n3) / 3;

            //if (diaria < 65)
            //{
            //    Console.WriteLine("corre risco de hipoglicemia!!!");
            //}
            //else if (diaria > 250)
            //{
            //    Console.WriteLine("corre risco de hiperglicemia!!!");
            //}

            //if (media < 80)
            //{
            //    Console.WriteLine("é preciso diminuir 2 unidades de insulina!!!");
            //}
            //else if (media > 150)
            //{
            //    Console.WriteLine("será necessário adicionar 2 unidades de insulina!!!");
            //}

            //10 - Faça um programa no VS que receba dados de dois atletas(nome, idade e altura).
            //O programa deve mostrar os dados do atleta mais novo e mais alto.

            //string nome1, nome2;

            //int idade1, idade2;

            //double altura1, altura2;

            //Console.WriteLine("Entre com o nome do primeiro atleta: ");
            //nome1 = Console.ReadLine();
            //Console.WriteLine("Entre com a idade do primeiro atleta: ");
            //idade1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Entre com a altura do primeiro atleta: ");
            //altura1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Entre com o nome do segundo atleta: ");
            //nome2 = Console.ReadLine();
            //Console.WriteLine("Entre com a idade do segundo atleta: ");
            //idade2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Entre com a altura do segundo atleta: ");
            //altura2 = double.Parse(Console.ReadLine());


            //if (idade1 < idade2)
            //{
            //    if (altura1 > altura2)
            //    {
            //        Console.WriteLine("O primeiro atleta é mais alto e mais novo!!!");
            //        Console.WriteLine("O nome do primeiro atleta: " + nome1);
            //        Console.WriteLine("A idade do primeiro atleta: " + idade1);
            //        Console.WriteLine("A altura do primeiro atleta: " + altura1);
            //    }
            //    else
            //    {
            //        Console.WriteLine("O primeiro atleta é mais novo porém mais baixo !!! ");
            //    }
            //}
            //else if (idade2 > idade1)
            //{
            //    if (altura2 > altura1)
            //    {
            //        Console.WriteLine("O segundo atleta é mais novo e mais alto !!!");
            //        Console.WriteLine("O nome do primeiro atleta: " + nome2);
            //        Console.WriteLine("A idade do primeiro atleta: " + idade2);
            //        Console.WriteLine("A altura do primeiro atleta: " + altura2);
            //    }
            //    else
            //    {
            //        Console.WriteLine("O segundo atleta é mais novo porém mais baixo !!!");
            //    }

            //}       

            //11 - Faça um programa no VS que receba uma hora, dividida em 2 variáveis(uma para hora e outra para minutos).
            //O programa deve exibir se a hora digitada está ou não válida. 
            //Lembre que usaremos o padrão de hora com 24h, de 0 a 23.

            //int h, min;

            //Console.WriteLine("Entre com a hora: ");
            //h = int.Parse(Console.ReadLine());
            //Console.WriteLine("Entre com os minutos: ");
            //min = int.Parse(Console.ReadLine());


            //if (h >= 0 && h <=23 && min >= 0 && min <= 60)
            //{
            //    Console.WriteLine("Horario Valido: " + h + "H"+min);
            //}
            //else
            //{
            //    Console.WriteLine("Horario não é valido !!!");
            //}

            //12 - Elabore um programa em VS que leia as variáveis "codigo" e "numeroHoras", respectivamente código e
            //número de horas trabalhadas de um operário. Na sequência, calcule o salário sabendo - se que ele ganha
            //R$ 10,00 por hora. Quando o número de horas exceder a 50 calcule o excesso de pagamento
            //armazenando - o na variável "extra", caso contrário zerar tal variável.A hora excedente de trabalho vale R$ 20,00.
            //No final do processamento, exibir o salário total e o salário excedente do operário.

            //int codigo, numeroHoras, extra = 0, h = 10, salario;


            //Console.WriteLine("Entre com o numero do codigo do operario: ");
            //codigo = int.Parse(Console.ReadLine());

            //Console.WriteLine("Entre com o numero de horas trabalhadas pelo operario: ");
            //numeroHoras = int.Parse(Console.ReadLine());

            //if (numeroHoras > 50)
            //{
            //    salario = numeroHoras * h;

            //    extra = numeroHoras - 50;

            //    salario = salario + (extra * 20);

            //    Console.WriteLine("Salario total é de: "+salario + " e salario excedente: " + (extra * 20));
            //}
            //else
            //{
            //    salario = numeroHoras * h;
            //    Console.WriteLine("Salario é de: " + salario);
            //}


            //13 - Tendo como dado de entrada a altura(h) de uma pessoa, construa um programa no VS que calcule
            //seu peso ideal, utilizando as seguintes fórmulas:
            //            Para homens: (72.7 * h) - 58
            //Para mulheres: (62.1 * h) - 44.7


            //double h, peso_idealh, peso_idealw;

            //Console.WriteLine("Entre com sua altura: ");
            //Console.WriteLine("-----------------------");
            //h = double.Parse(Console.ReadLine());

            //peso_idealh = (72.7 * h) - 58;
            //peso_idealw = (62.1 * h) - 44.7;

            //Console.WriteLine("Peso ideal masculino: "+ peso_idealh);
            //Console.WriteLine("-----------------------");
            //Console.WriteLine("Peso ideal feminino: " + peso_idealw);
            //Console.WriteLine("-----------------------");



            //14 - faça um programa que peça o tamanho de um arquivo para download(em mb) e a velocidade de um
            //link de internet(em mbps). em seguida, calcule e informe o tempo aproximado de download
            //do arquivo usando este link(em minutos).

            //Console.WriteLine("Digite a velocidade de Mb/s: ");
            //int velocidadeEmMegabytePorSegundo = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o tamanho do arquivo em bytes: ");
            //int tamanhoArq = int.Parse(Console.ReadLine());

            //var bytesPorSegundo = velocidadeEmMegabytePorSegundo * 1024F;

            //var resultado = (tamanhoArq / (float)bytesPorSegundo) / 60;

            //Console.WriteLine("O tempo de download em minutos " + resultado);
            //Console.ReadLine();

            //15 - Faça um programa para uma loja de tintas.O programa deverá pedir o tamanho em metros quadrados
            //da área a ser pintada. Considere que a cobertura da tinta é de 1 litro para cada 3 metros quadrados
            //e que a tinta é vendida em latas de 18 litros, que custam R$ 80,00.
            //Informe ao usuário a quantidades de latas de tinta a serem compradas e o preço total.

            //double area = 0, lata = 18, custo = 80, litros = 0, precoTotal;

            //int qt;

            //Console.WriteLine("Tamanho em m² da área a ser pintada: ");
            //area = double.Parse(Console.ReadLine());

            //litros = area / 3;


            //if (litros > lata)
            //{
            //    qt = (int) (1+(litros / lata));

            //}
            //else
            //{
            //    qt = 1;
            //}

            //precoTotal = custo * qt;

            //Console.WriteLine("quantidade de tintas compradas: " + qt);
            //Console.WriteLine("Preço total: R$" + precoTotal);

            //16 - Escreva um algoritmo que leia o placar de um jogo da primeira fase da copa do Brasil.Caso o time de fora tenha ganho o jogo por mais de 2 gols de diferença, mostre
            //na tela uma mensagem indicando que o time de fora já se classificou para a próxima fase. Caso contrário, mostre uma mensagem indicando que os dois times irão se
            //enfrentar novamente em um novo jogo.
            //ex: time da casa 4 x 3 time de fora, mostra "Os dois times se enfrentarão em um novo jogo"
            //ex2: time da casa 1 x 3 time de fora, mostra "O time de fora já se classificou"
            //plus: caso ocorra um segundo jogo, leia o placar desse novo jogo e então diga quem passou de fase.

            //int A1, B1, diferença;


            //Console.Write("Gols Marcados pelo time A de fora no primeiro jogo: ");
            //A1 = int.Parse(Console.ReadLine());

            //Console.Write("Gols marcados pelo time B da casa no primeiro jogo: ");
            //B1 = int.Parse(Console.ReadLine());

            //diferença = A1 - B1;

            //if (diferença >= 2)
            //{
            //    Console.WriteLine("O time de fora já se classificou !!! -----------> time da casa " + B1 + " x "+A1 +" time de fora");
            //}
            //else
            //{
            //    Console.WriteLine("Os dois times se enfrentam em um novo jogo !!!");
            //    Console.Write("Gols Marcados pelo time A no segundo jogo: ");
            //    int A2 = int.Parse(Console.ReadLine());

            //    Console.Write("Gols marcados pelo time B no segundo jogo: ");
            //    int B2 = int.Parse(Console.ReadLine());

            //    int T1 = A1 + A2;
            //    int T2 = B1 + B2;

            //    if (T1 > T2)
            //    {
            //        Console.Write("Time A passou de fase");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Time B passou de fase");
            //    }



            //17 - Faça um algoritmo que leia o tamanho dos lados de um triangulo(lado a, b e c), e então diga se esses lados podem ou não formar um triangulo. Para que os lados
            //formem um triângulo, todos os lados devem ser menores ou iguais a soma dos outros dois lados. Caso os lados formem um triangulo, diga se o mesmo é equilátero(todos
            //os lados iguais), isoceles(somente 2 lados são iguais) ou escaleno(os 3 lados são diferentes).


            //float a, b, c;

            //Console.WriteLine("Digite um numero: ");
            //a = float.Parse(Console.ReadLine());

            //Console.WriteLine("Digite um segundo numero: ");
            //b = float.Parse(Console.ReadLine());

            //Console.WriteLine("Digite um terceiro numero: ");
            //c = float.Parse(Console.ReadLine());

            //if ((a < (b + c)) && (b < (a + c)) && (c < (a + b)))
            //{
            //    if ((a == b) && (a == c))
            //    {
            //        Console.WriteLine("é um trângulo equilatero");
            //    }
            //    else if ((a == b) || (a == c))
            //    {
            //        Console.WriteLine("é um triângulo isósceles");
            //    }
            //    else
            //    {
            //        Console.WriteLine("é um triangulo escaleno");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Não é um triangulo");
            //}

            // 18 - Escreva um algoritmo que leia 3 valores pelo teclado e então informe qual o maior deles.

            //double n1, n2, n3;

            //Console.WriteLine("Digite um numero: ");
            //n1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite um segundo numero: ");
            //n2 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite um terceiro numero: ");
            //n3 = double.Parse(Console.ReadLine());


            //if(n1 > n2 && n1 > n3)
            //{
            //    Console.WriteLine("Primeiro numero digitado é o maior !!!");
            //}
            //else if (n2 > n1 && n2 > n3)
            //{
            //    Console.WriteLine("Segundo numero digitado é o maior !!!");
            //}
            //else if (n3 > n1 && n3 > n2)
            //{
            //    Console.WriteLine("Terceiro numero digitado é o maior !!!");
            //}
            //else
            //{
            //    Console.WriteLine("Numeros são iguais !!!");
            //}


            // 19 - Ajuste o exercício 18 de maneira que mostre os valores informados em ordem crescente.


            //double n1, n2, n3;

            //Console.WriteLine("Digite um numero: ");
            //n1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite um segundo numero: ");
            //n2 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite um terceiro numero: ");
            //n3 = double.Parse(Console.ReadLine());


            //if (n1 > n2 && n1 > n3)
            //{
            //    Console.WriteLine("Em ordem crescente: ");
            //    if (n2 > n3)
            //    {
            //        Console.WriteLine(n3);
            //        Console.WriteLine(n2);
            //        Console.WriteLine(n1);
            //    }
            //    else if (n3 > n2)
            //    {
            //        Console.WriteLine(n2);
            //        Console.WriteLine(n3);
            //        Console.WriteLine(n1);
            //    }

            //}
            //else if (n2 > n1 && n2 > n3)
            //{
            //    Console.WriteLine("Em ordem crescente: \n");
            //    if (n1 > n3)
            //    {
            //        Console.WriteLine(n3);
            //        Console.WriteLine(n1);
            //        Console.WriteLine(n2);

            //    }
            //    else if ( n3 > n1)
            //    {
            //        Console.WriteLine(n1);
            //        Console.WriteLine(n3);
            //        Console.WriteLine(n2);
            //    }
            //}
            //else if (n3 > n1 && n3 > n2)
            //{
            //    Console.WriteLine("Em ordem crescente: \n" );
            //    if (n1 > n2)
            //    {
            //        Console.WriteLine(n2);
            //        Console.WriteLine(n1);
            //        Console.WriteLine(n3);
            //    }
            //    else if (n2 > n1)
            //    {
            //        Console.WriteLine(n1);
            //        Console.WriteLine(n2);
            //        Console.WriteLine(n3);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Numeros são iguais !!!");
            //}

            //20 - Escreva um algoritmo para o jogo de adivinhação do número secreto. O jogador tem 3 chances e recebe dicas do tipo “é maior” ou “é menor”. 
            //plus: você pode gerar o número de forma randomica(função random c#).

            //int i, numero;

            //Random rnd = new Random();

            //i = (int)rnd.Next(1, 10);

            //Console.WriteLine("Tente advinhar qual é o numero !!!");
            //numero = int.Parse(Console.ReadLine());

            //if(numero == i)
            //{
            //    Console.WriteLine("VOCÊ ACERTOU !!!!");
            //}
            //else if (numero != i)
            //{


            //   if (numero > i)
            //    {
            //        Console.WriteLine("O numero é menor, advinhe outro");
            //        numero = int.Parse(Console.ReadLine());

            //        if (numero == i)
            //        {
            //            Console.WriteLine("VOCÊ ACERTOU !!!!");
            //        }
            //        else if (numero > i)
            //        {
            //            Console.WriteLine("O numero é menor");
            //            numero = int.Parse(Console.ReadLine());

            //            if (numero != i)
            //            {
            //                Console.WriteLine("Você errou o numero !!!");
            //            }
            //            else if (numero == i)
            //            {
            //                Console.WriteLine("VOCÊ ACERTOU !!!!");
            //            }
            //        }
            //        else if (numero < i)
            //        {
            //            Console.WriteLine("O numero é maior");
            //            numero = int.Parse(Console.ReadLine());

            //            if (numero != i)
            //            {
            //                Console.WriteLine("Você errou o numero !!!");
            //            }
            //            else if (numero == i)
            //            {
            //                Console.WriteLine("VOCÊ ACERTOU !!!!");
            //            }
            //        }
            //    }   


            //   else if (numero < i)
            //    {
            //        Console.WriteLine("O numero é maior, advinhe outro");
            //        numero = int.Parse(Console.ReadLine());

            //        if (numero == i)
            //        {
            //            Console.WriteLine("VOCÊ ACERTOU !!!!");
            //        }

            //        else if (numero < i)
            //        {
            //            Console.WriteLine("O numero é maior");
            //            numero = int.Parse(Console.ReadLine());

            //            if (numero != i)
            //            {
            //                Console.WriteLine("Você errou o numero !!!");
            //            }
            //            else if (numero == i)
            //            {
            //                Console.WriteLine("VOCÊ ACERTOU !!!!");
            //            }
            //        }

            //        else if (numero > i)
            //        {
            //            Console.WriteLine("O numero é menor");
            //            numero = int.Parse(Console.ReadLine());

            //            if (numero != i)
            //            {
            //                Console.WriteLine("Você errou o numero !!!");
            //            }
            //            else if (numero == i)
            //            {
            //                Console.WriteLine("VOCÊ ACERTOU !!!!");
            //            }
            //        }
                   
            //        }
            //    }

            }

        }

    }


    

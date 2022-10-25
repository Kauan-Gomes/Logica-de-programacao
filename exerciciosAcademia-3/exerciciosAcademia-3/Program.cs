using System;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using static System.Net.Mime.MediaTypeNames;

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

            //String voto;
            //int branco = 0, joao = 0, zeca = 0;
            //do
            //{
            //    Console.WriteLine("Entre com seu voto: ");
            //    voto = Console.ReadLine();

            //    if (voto == "branco" || voto == "joao" || voto == "zeca" || voto == "fim")
            //    {
            //        if (voto == "branco")
            //        {
            //            branco = branco+1;                      
            //        }
            //        else if (voto == "joao")
            //        {
            //            joao = joao+1;
            //        }
            //        else if (voto == "zeca")
            //        {
            //            zeca = zeca+1;
            //        }   

            //    if (voto == "fim")
            //    {
            //        break;
            //    }

            //    }
            //    else
            //    {
            //        Console.WriteLine("Entre novamente com um valor valido !!!");
            //    }

            //    if (voto == "fim")
            //    {
            //        break;
            //    }

            //}while (true);

            //Console.WriteLine("Quantidade de votos pro joâo: " + joao);
            //Console.WriteLine("Quantidade de votos pro zeca: "+ zeca);
            //Console.WriteLine("Quantidade de votos brancos: "+ branco);

            //5.Modifique o programa em VS anterior para aceitar votos nulos
            //(qualquer nome diferente de FIM, JOAO, ZECA e BRANCO).
            //Ao final, informe o nome do candidato vencedor, o número de votos nulos
            //e o número de pessoas que votaram.

            //String voto;
            //int branco = 0, joao = 0, zeca = 0, nulo = 0;
            //do
            //{
            //    Console.WriteLine("Entre com seu voto: ");
            //    voto = Console.ReadLine();

            //    if (voto == "branco" || voto == "joao" || voto == "zeca" || voto == "fim")
            //    {
            //        if (voto == "branco")
            //        {
            //            branco = branco + 1;
            //        }
            //        else if (voto == "joao")
            //        {
            //            joao = joao + 1;
            //        }
            //        else if (voto == "zeca")
            //        {
            //            zeca = zeca + 1;
            //        }

            //        else if (voto == "fim")
            //        {
            //            break;
            //        }

            //    }
            //    else
            //    {
            //        nulo = nulo + 1;
            //    }

            //} while (true);

            //Console.WriteLine("Quantidade de votos pro joâo: " + joao);
            //Console.WriteLine("Quantidade de votos pro zeca: " + zeca);
            //Console.WriteLine("Quantidade de votos brancos: " + branco);
            //Console.WriteLine("Quantidade de votos nulos: " + nulo);


            //6.Faça um programa em VS que solicite ao o usuário que informe a idade e valide a entrada de dados, 
            //ou seja, repita a leitura até que ela esteja correta(maior do que zero). 
            //Ao final, mostre a idade digitada.

            //int idade = 0;

            //do
            //{
            //    Console.WriteLine("Entre com a sua idade: ");
            //    idade = int.Parse(Console.ReadLine());

            //    if (idade <= 0)
            //    {
            //        Console.WriteLine("Entre com a sua idade novamente: ");
            //        idade = int.Parse(Console.ReadLine());

            //    }

            //    else
            //    {
            //        break;
            //    }

            //} while (true);

            //Console.WriteLine();
            //Console.WriteLine("Sua idade é de: "+idade + " Anos");


            //7.Faça um programa em VS que solicite o nome, a idade e o salário de uma pessoa.
            //A cada solicitação, teste se o usuário informou um valor válido. 
            //Por exemplo: se o nome for não for lido corretamente (ou seja, se estiver em branco ou se for um número), 
            //informe que ele está incorreto e saia do programa em VS.
            //Se o nome for lido corretamente, solicite a idade.Se ela for incorreta(menor ou igual a zero),
            //informe que está errada e saia.Se estiver correta, solicite o salário.
            //Se ele estiver incorreto(menor ou igual a zero), informe que está incorreto e saia.
            //Se estiver correto, mostre todos os valores lidos.

            //    string nome;
            //    int idade;
            //    double salario;
            //    do
            //    {
            //        Console.WriteLine("Entre com o nome: ");
            //        nome = Console.ReadLine();

            //        bool valida_nome =  IsNumeric(nome);

            //        if (valida_nome == true || String.IsNullOrEmpty (nome) || nome.Contains(" "))
            //        {
            //            Console.WriteLine("NOME INVALIDO !!!");
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Entre com a idade: ");
            //            idade = int.Parse(Console.ReadLine());
            //            do
            //            {
            //                if (idade <= 0)
            //                {
            //                    Console.WriteLine("IDADE INVALIDA !!!");
            //                    break;
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Informe o salario:");
            //                    salario = double.Parse(Console.ReadLine());
            //                    do
            //                    {
            //                        if (salario <= 0)
            //                        {
            //                            Console.WriteLine("SALARIO INVALIDO !!!");
            //                            break;
            //                        }
            //                        else
            //                        {
            //                            Console.WriteLine("Nome: "+nome);
            //                            Console.WriteLine("Idade: "+idade);
            //                            Console.WriteLine("salario: R$"+salario);
            //                        }
            //                        break;

            //                    }while(true);

            //                    break;
            //                }
            //                break;

            //            }while (true);

            //            break;
            //        }

            //    }while(true);         
            //}



            //private static bool IsNumeric(string data)
            //{
            //    bool isnumeric = false;
            //    char[] datachars = data.ToCharArray();

            //    foreach (var datachar in datachars)
            //        isnumeric = char.IsDigit(datachar);


            //    return isnumeric;
            //}


            //8.Faça um programa em VS que solicite um numero inteiro.S
            //e o numero não for inteiro, solicite - o até que seja.após, informe se ele é par ou impar.
            //Finalmente, pergunte ao usuário se ele quer repetir o programa em VS.

            //float i;

            //Console.WriteLine("Entre com um valor inteiro: ");
            //i = float.Parse(Console.ReadLine());

            //do
            //{
            //    Console.WriteLine("-----------------------------------");
            //    Console.WriteLine("Entre com um valor inteiro: ");
            //    i = float.Parse(Console.ReadLine());


            //    if (i % 1 == 0)
            //    {
            //        if (i % 2 == 0)
            //        {
            //            Console.WriteLine("-----------------------------------");
            //            Console.WriteLine(i + " é par !");
            //        }
            //        else
            //        {
            //            Console.WriteLine("-----------------------------------");
            //            Console.WriteLine(i + " é impar! ");
            //        }

            //        string validação;
            //        Console.WriteLine("-----------------------------------");
            //        Console.WriteLine("Deseja repetir o programa? ");
            //        validação = Console.ReadLine(); 

            //            if (validação == "sim" || validação == "nao")
            //            {
            //                if (validação == "sim")
            //                {
            //                    Console.WriteLine("-----------------------------------");
            //                    Console.WriteLine("rodando codigo novamente ...");
            //            }
            //                else if (validação == "nao")
            //                {
            //                    Console.WriteLine("-----------------------------------");
            //                    Console.WriteLine("encerrando codigo...");
            //                break;
            //                }
            //            }

            //    }

            //}while (true);


            //9.Faça um programa em VS para Ler a quantidade de filhos de cada uma das 30 pessoas que visitaram
            //o zoológico num determinado dia, imprimindo:
            //Quantas pessoas tem entre 1 e 3 filhos.
            //Quantas pessoas tem entre 4 e 7 filhos.
            //Quantas pessoas tem mais de 8 filhos.
            //Quantas pessoas não tem filhos.


            //int i = 30, x = 0;
            //int a=0, b=0, c=0, d = 0;

            //int[] vetor = new int[i];

            //for (int j = 0; j < i; j++)
            //{
            //    Console.WriteLine("Quantas filhos essa pessoa tem? ");
            //    x = int.Parse(Console.ReadLine());
            //    vetor[j] = x;


            //    if (x == 0)
            //    {
            //        a = a+1;
            //    }
            //    else if (0 < x && x < 4)
            //    {
            //        b = b+1;
            //    }
            //    else if (3 < x && x < 8) 
            //    {
            //        c = c+1;
            //    }
            //    else if (7 < x)
            //    {
            //        d = d+1;
            //    }
            //}

            //Console.WriteLine("Quantidade de pessoas que tem entre 1 e 3 filhos: " + b);
            //Console.WriteLine("Quantidade de pessoas que tem entre 4 e 7 filhos: " + c);
            //Console.WriteLine("Quantidade de pessoas que tem mais de 8 filhos:  " + d);
            //Console.WriteLine("Quantidade de pessoas não tem filhos: " + a);

            //10.Ler nome, sexo e idade de 50 pessoas e após imprimir:
            //Número de pessoas do sexo masculino.
            //Número de pessoas do sexo feminino.
            //Número de pessoas com idade inferior a 30 anos.
            //Número de pessoas com idade superior a 60 anos.
            //Média de idade das mulheres.


            //string nome;
            //string sexo;
            //int idade, pessoas = 50, m = 0, f = 0, id_menorTrinta = 0, id_maiorSessenta = 0, soma = 0;

            //int[] vetor = new int[pessoas];

            //for (int i = 0; i < pessoas; i++)
            //{
            //    Console.WriteLine("Entre com o nome: ");
            //    nome = Console.ReadLine();

            //    Console.WriteLine("Entre com seu sexo: ");
            //    sexo = Console.ReadLine();

            //    Console.WriteLine("Entre com sua idade: ");
            //    idade = int.Parse(Console.ReadLine());

            //    if (sexo == "masculino" || sexo == "feminino")
            //    {
            //        if (sexo == "masculino")
            //        {
            //            m = m + 1;
            //        }
            //        else if (sexo == "feminino")
            //        {
            //            f ++;
            //            soma = soma + idade;

            //        }
            //    }

            //    if (idade < 30)
            //    {
            //        id_menorTrinta ++;
            //    }
            //    else if ( idade > 60)
            //    {
            //        id_maiorSessenta++;
            //    }

            //}

            //Console.WriteLine("Número de pessoas do sexo masculino: " + m );
            //Console.WriteLine("Número de pessoas do sexo feminino: " + f );
            //Console.WriteLine("Número de pessoas com idade inferior a 30 anos: " + id_menorTrinta );
            //Console.WriteLine("Número de pessoas com idade superior a 60 anos: " + id_maiorSessenta );
            //Console.WriteLine("Média de idade das mulheres: " + (soma/f) );


            //11.Ler as notas de uma turma de alunos e ao final imprimir a nota mais alta, a nota mais baixa,
            //a média aritmética da turma e a quantidade de alunos da turma.Usar - 1 para encerrar a leitura.

            //double nota, soma = 0, notaMaior =0, notaMenor=10;
            //    int cont = 0;
            //do
            //{

            //    Console.WriteLine("Entre com a nota: ");
            //    nota = double.Parse(Console.ReadLine());
            //    if (nota >= 0 && nota <= 10)
            //    {
            //        cont++;
            //        soma = soma + nota;

            //        if (notaMaior < nota)
            //        {
            //            notaMaior = nota;
            //        }

            //        if (notaMenor > nota)
            //        {
            //            notaMenor = nota;
            //        }
            //    }

            //    if (nota == -1)
            //    {
            //        break;
            //    }

            //}while (true);

            //Console.WriteLine("Maior nota: " + notaMaior);
            //Console.WriteLine("Menor Nota: " + notaMenor);
            //Console.WriteLine("média aritimetica: " + (soma/cont));
            //Console.WriteLine("Quantidade de alunos: " + cont);

            //12.Apresentar o total da soma dos cem primeiros números inteiros.

            //int soma = 0;

            //for (int i = 1; i <= 100; i++)
            //{
            //    soma = soma + i;
            //}
            //Console.WriteLine("Soma dos cem primeiros numeros: " + soma);

            //13.Elaborar um programa que apresente o somatório dos valores pares existentes
            //entre 1 e 500.

            //int soma = 0;

            //for (int i = 1; i <= 500; i++)
            //{
            //   if(i %2 == 0) 
            //    {
            //    soma = soma + i;
            //    }                  
            //}
            //Console.WriteLine("somatório dos valores pares existentes entre 1 e 500: " + soma);

            //14.Mostrar as potências de 2 variando de 0 a 10.

            //double potenciaDois;

            //for (int i = 0; i <= 10; i++)
            //{
            //    potenciaDois = Math.Pow(2, i);

            //    Console.WriteLine("Potencia de dois elevado a " + i + ": "+ potenciaDois);
            //}

            //15.Ler 4 valores referentes a notas escolares de um aluno e imprimir uma mensagem dizendo se ele está aprovado
            //ou reprovado, após ter calculado sua média ponderando, considerando pesos 2, 1, 2, e 4, respectivamente.
            //Considerar nota 7,0 como mínima para aprovação.

            //double n1, n2, n3, n4, media;



            //Console.WriteLine("Entre com a nota da P1: ");
            //n1 = double.Parse(Console.ReadLine());

            //if (n1 >= 0 && n1 <= 10)
            //{
            //    n1 = n1 * 2;
            //}


            //Console.WriteLine("Entre com a nota da P2: ");
            //n2 = double.Parse(Console.ReadLine());

            //if (n2 >= 0 && n2 <= 10)
            //{
            //    n2 = n2 * 1;
            //}

            //Console.WriteLine("Entre com a nota da P3: ");
            //n3 = double.Parse(Console.ReadLine());

            //if (n3 >= 0 && n3 <= 10)
            //{
            //    n3 = n3 * 2;
            //}

            //Console.WriteLine("Entre com a nota da P4: ");
            //n4 = double.Parse(Console.ReadLine());

            //if (n4 >= 0 && n4 <= 10)
            //{
            //    n4 = n4 * 4;
            //}

            //media = (n1 + n2 + n3 + n4) / 9;

            //if (media < 7)
            //{
            //    Console.WriteLine("REPROVADO !!!  " + media);
            //}
            //else
            //{
            //    Console.WriteLine("APROVADO !!!  " + media);
            //}

            //16.Ler um número N qualquer menor ou igual a 50 e apresentar o valor obtido da
            //multiplicação sucessiva de N por 3 enquanto o produto for menor que 250
            //(N * 3; N * 3 * 3; N * 3 * 3 * 3; etc).

            //int num;

            //Console.WriteLine("Entre com um valor menor ou igual a 50: ");
            //num = int.Parse(Console.ReadLine());

            //while (num <= 50)
            //{
            //    Console.WriteLine("Número N: " + num);
            //    for (int i = 0; i < num; i++)
            //    {
            //        num = num * 3;

            //        if (num > 250)
            //        {
            //            break;
            //        }
            //        Console.WriteLine(num);
            //    }
            //}

            //17.Apresentar os quadrados dos números inteiros de 15 a 200.

            //int num;

            //for (int i = 15; i < 200; i++)
            //{
            //    num = i * i;
            //    Console.WriteLine("O quadrado de "+ i+ " é: " + num);
            //}

            //18.Elaborar um programa que apresente o valor de uma potência de uma base qualquer
            //elevada a um expoente qualquer, ou seja, NM.

            //int num1, num2, resultado;

            //Console.WriteLine("Entre com o valor da base: ");
            //num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Entre com o valor do expoente: ");
            //num2 = int.Parse(Console.ReadLine());

            //resultado = (int)Math.Pow(num1, num2);

            //Console.WriteLine("A potencia de "+ num1 + " elevado a "+ num2 + " é igual a: " + resultado);

            //19.A prefeitura de uma cidade fez uma pesquisa entre seus habitantes,
            //coletando dados sobre o salário e número de filhos. A prefeitura deseja saber: 

            //            a) média do salário da população;
            //            b) média do número de filhos;
            //            c) maior salário;
            //            d) percentual de pessoas com salário até R$ 100,00.
            //O final da leitura de dados se dará com a entrada de um salário negativo.

            //double salario = 0, soma_salario = 0, maior_salario = 0, soma_filhos = 0, porc_pessoas = 0;
            //int filhos = 0, pessoas = 0;

            //do
            //{

            //    Console.Write("Entre com o valor do Salário: R$");
            //    salario = double.Parse(Console.ReadLine());
            //    Console.WriteLine("----------------------------------------------------------");

            //    if (salario < 0)
            //    {
            //        break;
            //    }

            //    pessoas = pessoas + 1;

            //    Console.WriteLine("Entre com a quantidade de filhos: ");
            //    filhos = int.Parse(Console.ReadLine());
            //    Console.WriteLine("----------------------------------------------------------");

            //    if (maior_salario < salario)
            //    {
            //        maior_salario = salario;
            //    }

            //    soma_salario = soma_salario + salario;

            //    soma_filhos = soma_filhos + filhos;

            //    if (salario <= 100)
            //    {
            //        porc_pessoas = porc_pessoas+ 1;
            //    }


            //}while (true);

            //    Console.WriteLine("Média do salário da população: R$" + soma_salario/pessoas);
            //    Console.WriteLine("----------------------------------------------------------");
            //    Console.WriteLine("Média do número de filhos: "  + soma_filhos/pessoas);
            //    Console.WriteLine("----------------------------------------------------------");
            //    Console.WriteLine("Maior salário: R$" + maior_salario);
            //    Console.WriteLine("----------------------------------------------------------");
            //    Console.WriteLine("percentual de pessoas com salário até R$ 100,00: " + ((porc_pessoas*100)/ pessoas) + "%");
            //    Console.WriteLine("----------------------------------------------------------");

            //20.Foi realizada uma pesquisa de algumas características físicas da população de uma
            //certa região, a qual coletou os seguintes dados referentes a cada habitante para
            //serem analisados:
            //            -sexo(masculino e feminino)
            //            - cor dos olhos(azuis, verdes ou castanhos)
            //-cor dos cabelos(louros, castanhos, pretos)
            //-idade


            //Faça um algoritmo que determine e escreva:

            //            -a maior idade dos habitantes
            //            -a quantidade de indivíduos do sexo feminino cuja idade está entre 18 e 35 anos inclusive
            //             e que tenham olhos verdes e cabelos louros.
            //             O final do conjunto de habitantes é reconhecido pelo valor -1 entrada como idade.

            //int sexo = 0, masculino = 0, feminino = 0;
            //int olhos, o_azul = 0, o_verde = 0, o_castanho = 0;
            //int cabelo, c_loiro = 0, c_castanho = 0, c_preto = 0;
            //int idade, pessoas = 0, maior_idade = 0;
            //int especifico= 0; //a quantidade de indivíduos do sexo feminino cuja idade está entre 18 e 35 anos inclusive e que tenham olhos verdes e cabelos louros.
            

            //do
            //{
            //    Console.WriteLine("Entre com a sua idade: ");
            //    idade = int.Parse(Console.ReadLine());

            //    if (idade == -1)
            //    {
            //        break;
            //    }
            //    pessoas = pessoas + 1;

                

            //    do // Validação de Sexo
            //    {
            //        Console.WriteLine("Entre com seu sexo: Digite 1:masculino | Digite 2:feminino");
            //        sexo = int.Parse(Console.ReadLine()); 

            //        if(sexo == 1)
            //        {
            //            masculino = masculino + 1;
            //            break;
            //        }
            //        else if (sexo == 2)
            //        {
            //            feminino = feminino + 1;
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Entre com valor válido !!!");
            //        }


            //    } while (true);

            //    do // Validação de cor dos olhos
            //    {
            //        Console.WriteLine("Qual a cor dos seus olhos? Digite 1:Azul | Digite 2:Verde | Digite 3:Castanho ");
            //        olhos = int.Parse(Console.ReadLine());

            //        if (olhos == 1)
            //        {
            //            o_azul = o_azul + 1;
            //            break;
            //        }
            //        else if (olhos == 2)
            //        {
            //            o_verde = o_verde + 1;
            //            break;
            //        }
            //        else if (olhos == 3)
            //        {
            //            o_castanho = o_castanho + 1;
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Entre com valor válido !!!");
            //        }
            //    } while (true);


            //    do // Validação cor do cabelo
            //    {
            //        Console.WriteLine("Entre com a cor do seu cabelo: Digite 1:Loiro | Digite 2:Castanho | Digite 3:Preto");
            //        cabelo = int.Parse(Console.ReadLine());

            //        if (cabelo == 1)
            //        {
            //            c_loiro = c_loiro + 1;
            //            break ;
            //        }
            //        else if (cabelo == 2)
            //        {
            //            c_castanho = c_castanho + 1;
            //            break;
            //        }
            //        else if(cabelo == 3)
            //        {
            //            c_preto = c_preto + 1;
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Entre com valor válido !!!");
            //        }

            //    } while (true);


            //    if ((idade > 18) && (idade < 35) && (olhos == 2) && (cabelo == 1))
            //    {
            //        especifico = especifico + 1;
            //    }

            //    if (idade > maior_idade)
            //    {
            //        maior_idade = idade;
            //    }

            //} while (true);


            //    Console.WriteLine("A maior idade dos habitantes: " + maior_idade);
            //    Console.WriteLine("---------------------------------------------");
            //    Console.WriteLine("a quantidade de indivíduos do sexo feminino cuja idade está entre 18 e 35 anos inclusive e que tenham olhos verdes e cabelos loiros: " + especifico);
            //    Console.WriteLine("---------------------------------------------");
            //    Console.WriteLine("Numero de total de pessoas: " + pessoas);
            //    Console.WriteLine("---------------------------------------------");
               



        }
    }
}
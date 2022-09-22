namespace exerciciosAcademia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre dois números quaisquer.

            float n1, n2;

            Console.WriteLine("Digite um numero: ");
            n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite um segundo numero: ");
            n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("A média aritmetica é de:" + ((n1 + n2) / 2));
            Console.ReadKey();

        }
    }
}
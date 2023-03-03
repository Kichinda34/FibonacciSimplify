using System.Reflection;

internal class Program
{
    private static void Main(string[] args)
    {
        double ant = 1, prox = 0;
        int posicao;
        Console.WriteLine("Escreva qual posição da sequência de Fibonacci deseja ver: ");
        posicao = int.Parse(Console.ReadLine());

        for (int i = 0; i < posicao; i++)
        {
            prox = prox + ant;
            ant = prox - ant;
            Console.WriteLine("O valor da posição desejada de Fibonacci é: " +prox) ;
        }
    }
}
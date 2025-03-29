using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número para calcular o fatorial:");
        int numero = int.Parse(Console.ReadLine());
        Console.WriteLine($"O fatorial de {numero} é {CalcularFatorial(numero)}");
    }

    static int CalcularFatorial(int numero)
    {
        if (numero < 0)
            throw new ArgumentException("O número deve ser não negativo.");

        int fatorial = 1;
        for (int i = 1; i <= numero; i++)
        {
            fatorial *= i;
        }
        return fatorial;
    }
}



















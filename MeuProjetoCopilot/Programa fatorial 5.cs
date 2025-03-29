using System;

class Program
{
    static void Main(string[] args)
    {
        // Calcula e exibe o fatorial de 5
        int numero = 5;
        Console.WriteLine($"O fatorial de {numero} é {CalcularFatorial(numero)}.");
    }

    // Método para calcular o fatorial de um número inteiro
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

using System;

class Program
{
    static void Main(string[] args)
    {
        // Calcula e exibe o fatorial de 5
        int numero = 5;
        Console.WriteLine($"O fatorial de {numero} é {CalcularFatorial(numero)}.");

        // Verifica e exibe se o número 17 é primo
        int numeroPrimo = 17;
        Console.WriteLine($"O número {numeroPrimo} é primo? {EhPrimo(numeroPrimo)}");
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

    // Método para verificar se um número é primo
    static bool EhPrimo(int numero)
    {
        if (numero <= 1)
            return false;

        for (int i = 2; i < numero; i++)
        {
            if (numero % i == 0)
                return false;
        }
        return true;
    }
}
namespace Aula06;
public class Program
{
    public static void Main()
    {
        // Estrutura Condicional: If-Else 
        Console.WriteLine("=========Verificador de Números pares e impares=========");
        Console.WriteLine("Digite um número: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int result = number % 2; // todo numero divido por 2 é par

        if (result == 0) // == é um operador de comparação 
        {
            Console.WriteLine("O número é par");
        }
        else
        {
            Console.WriteLine("O número é ímpar");
        }
    }
}
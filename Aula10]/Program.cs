namespace Aula10;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("======CALCULADORA BASICA======");
        Console.WriteLine("Digite o primeiro número: ");
        double n1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo número: ");
        double n2 = Convert.ToDouble(Console.ReadLine());

        // Selecionar o tipo de operação (MENU)
        Console.WriteLine("\nSelecione o tipo de operação: ");
        Console.WriteLine("1 - Adição (+)");
        Console.WriteLine("2 - Subtração (-)");
        Console.WriteLine("3 - Multiplicação (*)");
        Console.WriteLine("4 - Divisão (/)");
        Console.WriteLine("Digite o número da operação desejada: ");
        int operacao = Convert.ToInt32(Console.ReadLine());


        double result = 0;

        // Condições
        if (operacao == 1)
        {
            result = n1 + n2;
        }
        else if (operacao == 2)
        {
            result = n1 - n2;
        }
        else if (operacao == 3)
        {
            result = n1 * n2;
        }
        else if (operacao == 4)
        {
            if (n2 != 0)
            {
                result = n1 / n2;
            }
            else if (n2 == 0)
            {
                Console.WriteLine("Não é possível dividir por zero!");
            }
            else
            {
                Console.WriteLine("Operação inválida!");
            }
        }
        Console.WriteLine("O resultado é: " + result);
    }
}
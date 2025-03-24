namespace Aula05;

public class Program
{
    public static void Main()
    {
        //  Operadores Aritméticos
        /*  int num1 = 20;
         int num2 = 10;

         int sum = num1 + num2; // Soma
         int sub = num1 - num2; // Subtração
         int mult = num1 * num2; // Multiplicação
         int div = num1 / num2;  // Divisão
         int model = num1 % num2; // Resto da divisão 

         Console.WriteLine("-----CALCULADORA-----");
         Console.WriteLine($"O valor da soma é {sum}");
         Console.WriteLine($"O valor da substração é {sub}");
         Console.WriteLine($"O valor da multiplicação é {mult}");
         Console.WriteLine($"O valor da divisão é {div}");
         Console.WriteLine($"O valor do resto da divisão é {model}"); */


        Console.WriteLine("==========CALCULADORA BASICA==========");
        Console.WriteLine("Digite o primeiro número: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo número: ");
        int number2 = Convert.ToInt32(Console.ReadLine());


        int sumCalculator = number1 + number2; 
        int subCalculator= number1 - number2; 
        int multCalculator = number1 * number2; 
        int divCalculator = number1 / number2;  
        int modelCalculator = number1 % number2;

        Console.WriteLine("==========RESULTADO==========");
        Console.WriteLine($"O valor da soma é {sumCalculator}");
        Console.WriteLine($"O valor da substração é {subCalculator}");
        Console.WriteLine($"O valor da multiplicação é {multCalculator}");
        Console.WriteLine($"O valor da divisão é {divCalculator}");
        Console.WriteLine($"O valor do resto da divisão é {modelCalculator}");



    }
}

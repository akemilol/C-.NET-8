namespace Aula08
{
    public class Program
    {
        public static void Main()
        {
            // Operadores Relacionais
            Console.WriteLine("=======OPERADORES RELACIONAIS=======");
            Console.WriteLine("Digite o primeiro número: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int y = Convert.ToInt32(Console.ReadLine());

            // Operador de igualdade ==
            if (x == y)
            {
                Console.WriteLine("Os números são iguais.");
            }
            else
            {
                Console.WriteLine("Os números são diferentes.");
            }

            // Operador de diferença !=
            if (x != y)
            {
                Console.WriteLine("Os números são diferentes.");
            }
            else
            {
                Console.WriteLine("Os números são iguais.");
            }

            // Operador de maior que >
            if (x > y)
            {
                Console.WriteLine("O primeiro número é maior que o segundo.");
            }
            else
            {
                Console.WriteLine("O primeiro número não é maior que o segundo.");
            }

            // Operador de menor que <
            if (x < y)
            {
                Console.WriteLine("O primeiro número é menor que o segundo.");
            }
            else
            {
                Console.WriteLine("O primeiro número não é menor que o segundo.");
            }

            // Operador de maior ou igual >=
            if (x >= y)
            {
                Console.WriteLine("O primeiro número é maior ou igual ao segundo.");
            }
            else
            {
                Console.WriteLine("O primeiro número não é maior ou igual ao segundo.");
            }

            // Operador de menor ou igual <=
            if (x <= y)
            {
                Console.WriteLine("O primeiro número é menor ou igual ao segundo.");
            }
            else
            {
                Console.WriteLine("O primeiro número não é menor ou igual ao segundo.");
            }
        }
    }
}

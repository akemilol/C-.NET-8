namespace Aula17;

public class Program
{
    public static void Main()
    {
        string separator = "-------------------";

        //1. Declaração com inicialização de valores
        // List <tipo>
        List<string> fruits = new List<string>()
        {
            "Manga",
            "Uva",
            "Morango"
        };

        //2. Acessar os valores
        Console.WriteLine(fruits[2]); // Morango

        Console.WriteLine(separator);

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine(separator);

        //3. Adicionar valores
        fruits.Add("Banana");
        fruits.Add("Pera");

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine(separator);

        //4. Remover valores
        fruits.Remove("Uva");

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine(separator);

        //5. Contagem de elementos
        Console.WriteLine($"Quantidade de frutas: {fruits.Count}"); // 4

        Console.WriteLine(separator);

        //6. modifica o valor na posição
        fruits[0] = "Abacaxi";

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine(separator);

        // 7. LImpar a lista
        fruits.Clear();

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine(separator);

        //8. Declaração sem inicialização de valores
        List<int> numbers = new List<int>();
        numbers.Add(1);
        numbers.Add(17);
        numbers.Add(23);

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
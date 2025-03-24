namespace Aula02;

// Variaveis no c# 
// exemplos:  int, float, double, decimal, string, char, bool

public class Program
{
    public static void Main()
    {
        string nome = "Joana";
        int idade = 21;
        double peso = 55.00;
        char sexo = 'F';


        Console.WriteLine($"Registro do paciente Nome: {nome}, {idade} Anos. Peso: {peso}Kg Genêro: {sexo}");
        Console.WriteLine($"Paciente {nome}, apresentou queixas de fortes dores de cabeça e febre alta.");

    }
}
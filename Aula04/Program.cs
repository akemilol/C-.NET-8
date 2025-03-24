namespace Aula04;

public class Program
{
   public static void Main()
    {
        Console.WriteLine("-------CADASTRO DE PACIENTE-------");

        // Solicitar nome do paciente
        Console.WriteLine("Digite o nome do paciente:");  // Output
        string nome = Console.ReadLine(); // Input (READLINE SÓ LER STRINGS!!)

        // Solicitar idade do paciente
        Console.WriteLine("Digite a idade do paciente:"); // Output
        int idade = Convert.ToInt32(Console.ReadLine()); // Input (convertemos para rodar int input)

        Console.WriteLine("-------FICHA DO PACIENTE-------");
        Console.WriteLine($"Nome do paciente: {nome}");
        Console.WriteLine($"Idade do paciente: {idade}");

        Console.WriteLine("-------------------------------");
        Console.WriteLine("Paciente cadastrado com sucesso! :D");
    }
}
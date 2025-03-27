namespace Aula11;

public class Program
{
    public static void Main()
    {
        // Aula de Switch 

        // EXEMPLO 1
        //  int number = 1;
        /* bool boolValue = true;

         switch (boolValue)
         {
             case true:
                 Console.WriteLine("O número é um");
                 break;

             case false:
                 Console.WriteLine("O número é igual a 2");
                 break;
         }*/

        //Console.WriteLine("==========DIA DA SEMANA==========");
        //Console.WriteLine("Digite o número do dia da semana (1 a 7: ");
        //int dayOfWeek = Convert.ToInt32(Console.ReadLine());

        // EXEMPLO 2
        //switch (dayOfWeek)
        //{
        //    case 1:
        //        Console.WriteLine("Domingo");
        //        break;

        //    case 2:
        //        Console.WriteLine("Segunda-feira");
        //        break;

        //    case 3:
        //        Console.WriteLine("Terça-feira");
        //        break;

        //    case 4:
        //        Console.WriteLine("Quarta-feira");
        //        break;

        //    case 5:
        //        Console.WriteLine("Quinta-feira");
        //        break;

        //    case 6:
        //        Console.WriteLine("Sexta-feira");
        //        break;

        //    case 7:
        //        Console.WriteLine("Sábado");
        //        break;

        //    default:
        //        Console.WriteLine("Dia da semana inválido");
        //        break;
        //}

        // EXEMPLO 3
        Console.WriteLine("==========DESEMPENHO ESCOLAR==========");
        Console.WriteLine("Digite a nota do aluno (0 a 10): ");
        int score = Convert.ToInt32(Console.ReadLine());

        switch (score)
        {
            case 10:
            case 9:
            case 8:
                Console.WriteLine("Aprovado!");
                break;

            case 7:
            case 6:
                Console.WriteLine("Aprovado, mas pode melhorar!");
                break;

            case 5:
                Console.WriteLine("Recuperação");
                break;

            case 4:
            case 3:
            case 2:
            case 1:
                Console.WriteLine("Reprovado!");
                break;
        }
        }
}
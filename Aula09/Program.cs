namespace Aula09;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("=======OPERADORES LÓGICOS=======");
        bool isLogged = true;
        bool isAdmin = false;

        Console.WriteLine("\n Informação do Usuário: ");
        Console.WriteLine("Usuário está logado: " + isLogged);
        Console.WriteLine("Usuário é administrador: " + isAdmin);

        Console.WriteLine("\nPermissões");

        // Operador || - OU
        if (isLogged || isAdmin)
        {
            Console.WriteLine("\nUsuario esta logado.");
        }
        else
        {
            Console.WriteLine("\nUsuario não esta logado..");
        }

        // Operador && - E
        if (isLogged && isAdmin)
        {
            Console.WriteLine("\nAcesso ao painel de administrador concedido.");
        }
        else
        {
            Console.WriteLine("\nAcesso ao painel de administrador negado.");
        }

        // Operador ! - NÃO
        // se for true ele vai negar e vai tornar isLogged em false
        if (!isLogged)
        {
            Console.WriteLine("\nUsuario não está logado");
        }
        else
        {
            Console.WriteLine("\nUsuario está logado.");
        }
    }
}

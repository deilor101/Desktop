using System;
class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 8 - Condicionais parte 2");

        int idadeMaria = 16;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 1;
        bool grupo = true;

        if (idadeMaria >= 18 || grupo)
        {
            Console.WriteLine("Pode entrar!");
        }
        else
        {
            Console.WriteLine("Não pode entrar!");
        }


        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}

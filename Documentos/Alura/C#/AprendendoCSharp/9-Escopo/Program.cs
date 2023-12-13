using System;
class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 9 - Escopo");

        int idadeMaria = 16;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 1;

        string textoAdicional;

        if (acompanhado == true)
        {
            textoAdicional = "Maria está acompanhado";
        }
        else
        {
            textoAdicional = "Maria não está acompanhado";
        }


        if (idadeMaria >= 18 || acompanhado)
        {
            Console.WriteLine(textoAdicional);
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

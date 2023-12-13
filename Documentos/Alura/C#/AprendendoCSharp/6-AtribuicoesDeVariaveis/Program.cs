using System;
class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto  6 - Atribuições de variáveis");

        int idade = 25;
        int idadeAna = idade;

        Console.WriteLine(idadeAna);

        idade = 30;
     
        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}

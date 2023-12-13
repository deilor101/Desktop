using System;
class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 13 = Encadeando For");

        for (int contadorLinhas = 0; contadorLinhas <= 9; contadorLinhas++)
        {
            for (int contadorColunas = 0; contadorColunas <= 9; contadorColunas++)
            {
                Console.Write("*");
                if (contadorColunas >= contadorLinhas)
                {
                    break;
                }
            }
            Console.WriteLine();
        }

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}

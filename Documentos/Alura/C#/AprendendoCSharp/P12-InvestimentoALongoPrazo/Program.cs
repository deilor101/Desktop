﻿using System;
class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 12 - Investimento a Longo Prazo");

        double fatorRendimento = 1.005;
        double investimento = 1000;
        int mes;

        for (int anos = 1; anos <= 5; anos++)
        {
            for ( mes = 1; mes <= 12; mes++)
            {
                investimento *= fatorRendimento;
            }

            fatorRendimento += 0.001;
        }

        Console.WriteLine("Depois de 5 anos você terá R$ " + investimento);



        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}

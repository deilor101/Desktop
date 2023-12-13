using System;
class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 5 - Caracteres e Textos");

        char letra = 'a';
        Console.WriteLine(letra);

        letra = (char)65;
        Console.WriteLine(letra);

        letra = (char)(65 + 1);
        Console.WriteLine(letra);

        string primeiraFrase = "Olá, me chamo Matheus Henrique";
        Console.WriteLine(primeiraFrase);

        string vazia = "";
        Console.WriteLine(vazia);

        letra = ' ';

        string cursos = @"Cursos Disponínveis: 
                            - Go 
                            - C# 
                            - Python 
                            - Java";
        Console.WriteLine(cursos);

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}

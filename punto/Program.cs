using System;
using System.Globalization;
using punto;

internal class Program
{
    private static void Main(string[] args)
    {
        String currentFilePath;        

        do
        {
            Console.WriteLine("Informe o caminho do arquivo:");
            currentFilePath = Console.ReadLine();

        } while (String.IsNullOrWhiteSpace(currentFilePath));
            ReadFile readFile = new ReadFile(currentFilePath);
            readFile.showFormatedFile();
            Console.WriteLine();
    } 
}
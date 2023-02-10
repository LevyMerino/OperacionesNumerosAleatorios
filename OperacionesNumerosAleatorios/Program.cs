using OperacionesNumerosAleatorios;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Cuantos numeros aleatorios quieres crear");

        string? input = Console.ReadLine();
        int number;

        if (int.TryParse(input, out number))
        {
            ListNumbers listNumbers = new(number);
            listNumbers.RandomNumbers();
            string numberlist = listNumbers.getInput();
            string average = listNumbers.getAverage();
            string addition = listNumbers.getAddition();
            string descending = listNumbers.getDescending();
            string ascending = listNumbers.getAscending();

            Console.WriteLine($"Entrada: {numberlist}");
            Console.WriteLine($"Promedio: {average}");
            Console.WriteLine($"Suma: {addition}");
            Console.WriteLine($"Mayor: {listNumbers.higher}");
            Console.WriteLine($"Menor: {listNumbers.minor}");
            Console.WriteLine($"Ordenamiento Asc: {ascending}");
            Console.WriteLine($"Ordenamiento Desc: {descending}");
        }
        else
        {
            Console.WriteLine("Ingresa un número valido");
        }
    }
}
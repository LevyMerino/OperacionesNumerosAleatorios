using OperacionesNumerosAleatorios;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {


        Console.WriteLine("Cuantos numeros aleatorios quieres crear");
        int n = int.Parse(Console.ReadLine());      

        ListNumbers listNumbers = new(n);
        listNumbers.RandomNumbers();
        string input = listNumbers.getInput();
        string average = listNumbers.getAverage();
        string addition = listNumbers.getAddition();
        string descending = listNumbers.getDescending();
        string ascending =  listNumbers.getAscending();


        Console.WriteLine($"Entrada: {input}");
        Console.WriteLine($"Promedio: {average}");
        Console.WriteLine($"Suma: {addition}");
        Console.WriteLine($"Mayor: {listNumbers.higher}");
        Console.WriteLine($"Menor: {listNumbers.minor}");
        Console.WriteLine($"Ordenamiento Asc: {ascending}");
        Console.WriteLine($"Ordenamiento Desc: {descending}");
         
    }

}
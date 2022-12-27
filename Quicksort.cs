//namespace Deber02_Ordenamiento;
namespace System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Stopwatch tiempo = new Stopwatch();
        tiempo.Start();


        int[] A = { 51, 21, 39, 80, 36 };
        Console.WriteLine("\nArreglo desordenado: ");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($"A[{i}]={A[i]}, ");
        }

        Array.Sort(A);
        Console.WriteLine("\n\nArreglo ordenado por Quicksort:");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($"A[{i}]={A[i]}, ");
        }
        Console.WriteLine("\n\n ");
        tiempo.Stop();
        Console.WriteLine("Tiempo de ejecución: " + tiempo.Elapsed.TotalMilliseconds);
 }
}

//namespace Deber02_Ordenamiento;
class Program
{
    static void Main1(string[] args)
    {
        int[] A = { 50, 20, 30, 40, 10 };
        Console.WriteLine("\nArreglo desordenado: ");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($"A[{i}]={A[i]}, ");
        }

        Burbuja(A, A.Length);
        Console.WriteLine("\n\nArreglo ordenado: ");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($"A[{i}]={A[i]}, ");
        }
        Console.WriteLine("\n\n ");

        static void Burbuja(int[] A, int n)
        {
            Console.Write("\n\nComienzo:                                                                 Cambio:");
            Console.WriteLine("\n");
            int aux;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (A[j] > A[j + 1])
                    {
                        aux = A[j];
                        A[j] = A[j + 1];
                        A[j + 1] = aux;
                        
                    }
                    for(int k=0;k<n;k++){
                        Console.Write($"A[{k}]={A[k]}, ");
                    }
                    Console.WriteLine("                            A[{0}] = {1}, A[{2}] = {3}", j, A[j], j + 1, A[j + 1]);
                }
            }
        }
    }
}

using System;

class Program
{
    static void ReversePrint(int[] arr, int index)
    {
        if (index >= 0)
        {
            Console.WriteLine(arr[index]);
            ReversePrint(arr, index - 1);
        }
    }

    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };

        ReversePrint(arr, arr.Length - 1);

        Console.ReadLine();
    }
}
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int a = 5,
           b = 6;
        int result = a + b;
        int multiple = 5;
        multiple = multiple * result;
        //ustekinin qisa versi 
        multiple *= result;
        Record4.SumMethods.Sum(2, 2);

        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        string[] ab = new string[10];
        Array.Reverse(arr);
        for (int i = 0; i < arr.Length; i++)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            System.Console.WriteLine("Salam" + arr[i]);
        }

        #region Reverse Method
        Record4.ReverseMethods.ReverseMethod(arr);
        #endregion


        string[] arrayStringTest = { "sala", "FDS", "fdsfdsfdsf", };

        Record4.ReverseMethods.ReverseMethod(arrayStringTest);

        int arrayinIndexsiniTapmaq = Array.IndexOf(arr, 5);
        Console.BackgroundColor = ConsoleColor.Gray;
        System.Console.Write(arrayinIndexsiniTapmaq);
        Console.BackgroundColor = ConsoleColor.Black;
        System.Console.WriteLine("");

        int ArrayIndexFinf = Record4.ArrayFindMetdod.Find(arr, 5);
        Console.BackgroundColor = ConsoleColor.DarkCyan;
        System.Console.Write(arrayinIndexsiniTapmaq);
        Console.BackgroundColor = ConsoleColor.Black;
        System.Console.WriteLine("");

    }
}
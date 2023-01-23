using System;
namespace Record4
{
    public static class ReverseMethods
    {
        public static void ReverseMethod(int[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                System.Console.WriteLine(array[i]);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public static void ReverseMethod(string[] array) 
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                System.Console.WriteLine(array[i]);
                Console.ForegroundColor = ConsoleColor.White;           
            }

            
        }
    }
}
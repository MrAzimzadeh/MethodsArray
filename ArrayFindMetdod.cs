using System;
namespace Record4
{
    public class ArrayFindMetdod
    {
        public static int Find(int[] array, int index)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i == index)
                {
                    return array[i];
                }
            }
            return -1;
        }
    }
}
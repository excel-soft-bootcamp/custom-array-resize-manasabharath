using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayResizeApp
{
    public static class ArrayUtility
    {
        public static void Resize(ref int[] array, int newSize)
        {
            int[] numbers = array;
            array = new int[newSize];
            for (int i = 0; i < numbers.Length; i++)
            {
                array[i] = numbers[i];
            }
        }
    }
}

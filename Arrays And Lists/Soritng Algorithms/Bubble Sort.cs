using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Arrays_And_Lists.Soritng_Algorithms
{
    public static class Bubble_Sort
    {
        private static void Swap<T>(T[] array, int first, int second)
        {
            T temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }
        public static class BubbleSort
        {
            public static void Sort<T>(T[] array) where T : IComparable
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length - 1; j++)
                    {
                        if (array[j].CompareTo(array[j + 1]) > 0)
                        {
                            Swap(array, j, j + 1);
                        }
                    }
                }
            }
        }
    }
}

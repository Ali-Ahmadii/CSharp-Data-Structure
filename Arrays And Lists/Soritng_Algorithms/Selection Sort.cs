using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Arrays_And_Lists.Soritng_Algorithms
{

    public static class Selection_Sort
    {
        private static void Swap<T>(T[] array, int first, int second)
        {
            T temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }
        public static void Sort<T>(T[] array) where T : IComparable
        {

            for (int i = 0; i < array.Length - 1; i++)
            {
                int minimum_value_index = i;
                T minimum_value = array[i];
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j].CompareTo(minimum_value) < 0)
                    {
                        minimum_value_index = j;
                        minimum_value = array[j];
                    }
                }

                Swap(array, i, minimum_value_index);
            }
        }
    }
}

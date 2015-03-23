using System;
using Wzorce1.Interfaces;

namespace Wzorce1.Sorters
{
    public class TxtValuesSorter : ISorter
    {
        public int[] Sort(int[] array)
        {
            var sortedArray = array;
            Array.Sort(sortedArray);
            return sortedArray;
        }
    }
}
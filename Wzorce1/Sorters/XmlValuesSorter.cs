using System.Linq;
using Wzorce1.Interfaces;

namespace Wzorce1.Sorters
{
    public class XmlValuesSorter : ISorter
    {
        public int[] Sort(int[] array)
        {
            return array.OrderBy(i => i).ToArray();
        }
    }
}
using Wzorce1.Interfaces;

namespace Wzorce1
{
    public class DocumentWorker
    {
        public ILoader Loader { get; set; }
        public ISorter Sorter { get; set; }
    }
}

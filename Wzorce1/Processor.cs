using System;

namespace Wzorce1
{
    public class Processor
    {
        private readonly DocumentWorker _worker;

        public Processor(DocumentWorker worker)
        {
            this._worker = worker;
        }

        public void ReadAndSort(string path)
        {
            var valuesArray = _worker.Loader.Load(path);
            var sortedArray = _worker.Sorter.Sort(valuesArray);

            Console.WriteLine("Sorted values are: ");
            foreach (var value in sortedArray)
            {
                Console.WriteLine(value);
            }
            Console.ReadLine();
        }
    }
}
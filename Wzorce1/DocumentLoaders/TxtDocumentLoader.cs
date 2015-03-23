using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Wzorce1.Interfaces;

namespace Wzorce1.DocumentLoaders
{
    class TxtDocumentLoader : ILoader
    {
        public int[] Load(string filePath)
        {
            var doc = File.ReadLines(filePath);
            List<int> valuesList = doc.Select(n => Convert.ToInt32(n)).ToList();
            return valuesList.ToArray();
        }
    }
}

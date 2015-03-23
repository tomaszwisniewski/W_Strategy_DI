using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Wzorce1.Interfaces;

namespace Wzorce1.DocumentLoaders
{
    class XmlDocumentLoader : ILoader
    {
        public int[] Load(string filePath)
        {
            var doc = XDocument.Load(filePath);
            var array = from intValue in doc.Descendants("IntValue")
                select (int)intValue.Element("value");

            return array.ToArray();
        }
    }
}

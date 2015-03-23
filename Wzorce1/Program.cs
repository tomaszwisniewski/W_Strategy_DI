using System;
using System.IO;
using System.Reflection;
using Wzorce1.DocumentLoaders;
using Wzorce1.Enums;
using Wzorce1.Sorters;

namespace Wzorce1
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentType doctype;
            var documentWorker = new DocumentWorker();
            var processor = new Processor(documentWorker);
            var documentPath = @"D:\Projects\Wzorce1\Wzorce1\";
            
            Console.WriteLine("Please set the type of the document you want to read(xml, txt) : ");
            var givenType = Console.ReadLine();
            if (!Enum.TryParse(givenType, out doctype))
            {
                throw new Exception("Incorrect document type, only xml and txt allowed.");
            }

            switch (doctype)
            {
                case DocumentType.Txt :
                    documentWorker.Loader = new TxtDocumentLoader();
                    documentWorker.Sorter = new TxtValuesSorter();
                    documentPath += "txt.txt";
                    break;
                case DocumentType.Xml:
                    documentWorker.Loader = new XmlDocumentLoader();
                    documentWorker.Sorter = new XmlValuesSorter();
                    documentPath += "xml.txt";
                    break;
                default:
                    throw new Exception("Incorrect document type, only xml and txt allowed.");
            }
            processor.ReadAndSort(documentPath);
        }
    }
}

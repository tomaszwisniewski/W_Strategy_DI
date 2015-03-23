using System;
using System.Security.Cryptography.X509Certificates;

namespace Wzorce1.Interfaces
{
    public interface ISorter
    {
        Int32[] Sort(Int32[] array);
    }
}
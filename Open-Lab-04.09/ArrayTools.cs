using System;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace Open_Lab_04._09
{
    public class ArrayTools
    {
        public string[] RemoveDups(string[] strings)
        {
            string[] dupsRemoved = strings.Distinct().ToArray();
            return dupsRemoved;
        }
    }
}

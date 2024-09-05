using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kiszh3Pelda
{
    internal class Extra
    {
        public static List<LimitedStorage<double>> LoadStorageList(string filename)
        {
            var storageList = new List<LimitedStorage<double>>();

            var lines = File.ReadAllLines(filename);
            var lineIndex = 0;

            while (lineIndex < lines.Length)
            {
                int maxSize;
                if (!int.TryParse(lines[lineIndex], out maxSize))
                {
                    throw new FormatException("Invalid file format: Maximum size must be an integer.");
                }

                var storage = new LimitedStorage<double>(maxSize);

                lineIndex++;

                var numbers = lines[lineIndex].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var number in numbers)
                {
                    double value;
                    if (!double.TryParse(number, out value))
                    {
                        throw new FormatException("Invalid file format: Could not parse a number.");
                    }

                    storage.Add(value);
                }

                storageList.Add(storage);
                lineIndex++;
            }

            return storageList;
        }
    }
}

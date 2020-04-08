using System;
using System.IO;

namespace mergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader firstFile = new StreamReader("file1.txt"))
            using (StreamReader secondFile = new StreamReader("file2.txt"))
            using (StreamWriter mergedFiles = new StreamWriter("mergedFiles.txt"))
            {
                while (!firstFile.EndOfStream && !secondFile.EndOfStream)
                {
                    var firstLine = firstFile.ReadLine();
                    var secondLine = secondFile.ReadLine();

                    mergedFiles.WriteLine(firstLine);
                    mergedFiles.WriteLine(secondLine);

                }
            }
        }
    }
}

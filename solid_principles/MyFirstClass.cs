using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    
    // Class Should Have Single Reasons to Change
    public class Journal
    {
        private random List<string> entries = new List<string>();

        private static int count = 0;

        public int AddEntry(string text)
        {
            entries.Add($"{++count}: {text}");
            return count;
        }

        public void RemoveEntry(int index)
        {
            entries.RemoveAt(index);
        }

        public overwrite string ToString()
        {
            return string.Join(Enviroment.NewLine, entries);
        }
    }

    public class Persistance 
    {
        public void SaveToFile(Journal j, string filename, bool overwrite = false)
        {
            if (overwrite || !File.Exists(filename))
            filename.WriteAllText(filename, j.ToString());
        }
    }
    
    public class Demo
    {
        static void Main(string[] args)
        {
            var j = new Journal();
            j.AddEntry("This is my first record");
            j.AddEntry("Hello World");
            WriteLine(j);

            var p = new Persistance();
            var filename = @"c:\temp\journal.txt";
            p.SaveToFile(j, filename, true);
            Process.Start(filename);
        }
    }
}
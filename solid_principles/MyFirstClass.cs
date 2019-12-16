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

        public override string ToString()
        {
            return string;
        }
    }
    
    public class Demo
    {
        static void Main(string[] args)
        {

        }
    }
}
using System;
using System.Collections.Generic;

namespace Interface
{
    public class Document
    {

    }

    public interface IMachine
    {
        void Print(Document d);
        void Scan(Document d);
        void Fax(Document d);
    }

    public class MultiFunctionPrinter : IMachine
    {
        public void Print(Document d)
        {

        }

        public void Scan(Document d)
        {

        }
        public void Fax(Document d)
        {
            
        }
    }

    public class Demo
    {
        static void Main(string[] args)
        {

        }
    }
}
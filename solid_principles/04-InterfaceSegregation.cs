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
    public class OldFashionedPrinter : IMachine
    {
        public void Print(Document d)
        {

        }
        public void Scan(Document d)
        {
            throw new NotImplementedException();
        }
        public void Fax(Document d)
        {
            throw new NotImplementedException();
        }
    }

    // Split features into new Interfaces
    public interface IPrinter
    {
        void Print(Document d);
    }
    
    public interface IScanner
    {
        void Scan(Document d);
    }

    public class Photocopier : IPrinter, IScanner
    {
        public void Print(Document d)
        {
            throw new NotImplementedException();
        }

        public void Scan(Document d)
        {
            throw new NotImplementedException();
        }
    }

    public interface IMultiFunctionDevice : IScanner, IPrinter //..
    {
        
    }
    


    public class Demo
    {
        static void Main(string[] args)
        {

        }
    }
}
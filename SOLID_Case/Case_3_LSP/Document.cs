using System;

namespace SOLID.SOLID_Case_Answer.Case_Answer_3_LSP
{
    #region Bad Code
    //public class Document
    //{
    //    public virtual void Print()
    //    {
    //        Console.WriteLine("Printing Document");
    //    }
    //}

    //public class ReadOnlyDocument : Document
    //{
    //    public override void Print()
    //    {
    //        throw new InvalidOperationException("Cannot print a read-only document");
    //    }
    //}

    #endregion

    public interface IPrintable
    {
        void Print();
    }
    public class Document
    {

    }
    public class ReadOnlyDocument : Document
    {

    }
    public class PrintDocument : Document, IPrintable
    {
        public void Print()
        {
            Console.WriteLine("Printing Document");
        }
    }

}

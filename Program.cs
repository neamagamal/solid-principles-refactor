using SOLID.SOLID_Case_Answer.Case_Answer_3_LSP;
using SOLID.SOLID_Implement_2._2_5_DIP;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            Document do1 = new Document();
            Document do2 = new ReadOnlyDocument();
            Document do3 = new PrintDocument();


            IManager manager = new Manager();
            Worker worker = new Worker(manager);
            worker.DoTask();





            //var book = new Book ( "test", "test" );
            //var book_printer = new BookPrinter();
            //book_printer.Print(book);
            //var saveBook = new SaveBook();
            //saveBook.Save(book);
            ////====
            //var draw = new Drawshape();
            //IDrawShape circle = new Circle();
            //Console.WriteLine(draw.DrawShape(circle));
        }
    }
}

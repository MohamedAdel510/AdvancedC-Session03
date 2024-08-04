using Assignment.Part_02;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] auth1 = { "Mohamed", "Adel" };
            string[] auth2 = { "Sara", "Adel" };
            string[] auth3 = { "Nourhan", "Tareq" };

            DateTime dt1 = new DateTime(2015, 12, 31);
            DateTime dt2 = new DateTime(2016, 12, 31);
            DateTime dt3 = new DateTime(2017, 12, 31);


            Book b1 = new Book("ISBN 01", "Book1", auth1, dt1, 100m);
            Book b2 = new Book("ISBN 02", "Book2", auth2, dt2, 200m);
            Book b3 = new Book("ISBN 03", "Book3", auth3, dt3, 300m);
            
            List<Book> Lbooks = new List<Book>();

            Lbooks.Add(b1);
            Lbooks.Add(b2);
            Lbooks.Add(b3);

            #region using user defined Delegate
            //Console.WriteLine("Books Titles:");
            //LibraryEngine.ProcessBooks(Lbooks, BookFunctions.GetTitle);
            //Console.WriteLine("Books Authors:");
            //LibraryEngine.ProcessBooks(Lbooks, BookFunctions.GetAuthers);
            //Console.WriteLine("Books Prices:");
            //LibraryEngine.ProcessBooks(Lbooks, BookFunctions.GetPrice);
            #endregion

            #region using Built in delegate
            Func<Book, string> func = BookFunctions.GetTitle;

            Console.WriteLine("Books Titles:\n------------");
            
            LibraryEngine.ProcessBooks(Lbooks, func);

            Console.WriteLine("Books Authors:\n-----------");
            func = BookFunctions.GetAuthers;
            LibraryEngine.ProcessBooks(Lbooks, func);

            Console.WriteLine("Books Prices:\n------------");
            func = BookFunctions.GetPrice;
            LibraryEngine.ProcessBooks(Lbooks, func);
            #endregion

        }
    }
}

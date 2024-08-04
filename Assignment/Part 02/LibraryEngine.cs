using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Part_02
{
    internal class LibraryEngine
    {
        public static void ProcessBooks(List<Book> books, Func<Book, string> fPtr)
        {
            foreach (Book book in books)
            {
                Console.WriteLine(fPtr(book));
            }
        }

        public static void ProcessBooks(List<Book> books, BookFuncDelegate fPtr)
        {
            foreach (Book book in books)
            {
                Console.WriteLine(fPtr(book));
            }
        }
    }
}

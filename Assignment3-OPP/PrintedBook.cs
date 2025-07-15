using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_OPP
{
    public class PrintedBook : Book
    {
        public int PageCount { get; }
        public PrintedBook(string title, string author, string isbn, int pageCount) : base(title, author, isbn)
        {
            PageCount = pageCount;

        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Page Count: {PageCount}");
        }
    }
}

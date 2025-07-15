using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_OPP
{
    public class EBook : Book
    {
        public double FileSize { get; }

        public EBook(string title, string author, string isbn , double fileSize) : base(title, author, isbn)
        {
            FileSize = fileSize;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"File Size: {FileSize} MB");
        }
    }   
    
}

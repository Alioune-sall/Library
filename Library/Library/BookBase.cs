using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class BookBase : Books
    {
        public string Title;
        public string Author;
        public int NumberOfBooks;

        public BookBase()
        {
            Title = "Anna Karenina";
            Author = "lev Tolstoj";
            NumberOfBooks = 4;

        }

        public override void Borrow()
        {
            if(NumberOfBooks > 0)
            { 
                NumberOfBooks--;
                Console.WriteLine("You just borrowed a book " + NumberOfBooks + " books are still available");
            }
            else
                Console.WriteLine("No more books aviable");
        }

        public override void GiveBack()
        {
            NumberOfBooks++;
            Console.WriteLine("Thank you for returning the book, " + NumberOfBooks + " books are still available");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Book
    {
        public string title;
        private string author;
        public int pages;
        public static int bookCount = 0;

        public Book(string aTitle, string aAuthor, int aPages)
        {
            title = aTitle;
            Author = aAuthor;
            pages = aPages;
            bookCount++;

            Console.WriteLine($"Added below book successfully!\nTitle: {title}\nAuthor: {author}\nPages: {pages}\nTotal Book Count: {bookCount}\n");
        }

        public string Author
        {
            get { return author;  }
            set 
            {
                if ( value == "JK Rowlings" || value == "Tolkein")
                {
                    author = value;
                }
                else
                {
                    author = "None";
                }
                   
            }
        }
    }
}

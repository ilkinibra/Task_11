using System;
using System.Collections.Generic;
using System.Text;


namespace Task_11.Models
{
    class Liblary
    {
        public  List<Book> Books = new List<Book>();
        public List<Book> FindAllBooksByName(string value)
        {
            return Books.FindAll(book => book.Name.Contains(value));
        }

        public void RemoveAllBooksByName(string value)
        {
            Books.RemoveAll(book => book.Name.Contains(value));
        }

        public List<Book> SearchBooks(string value)
        {
            return Books.FindAll(book => book.Name.Contains(value)|| book.AuthorName.Contains(value)|| book.PageCount.ToString().Contains(value));
        }

        public List<Book> FindAllBooksByPageCountRange(int min,int max)
        {
            return Books.FindAll(book => book.PageCount >= min && book.PageCount <= max);
        }

        public void RemoveBookByCode(string value)
        {
            Book wantedBook = Books.Find(book => book.Code == value);
            if (wantedBook !=null)
            {
                Books.Remove(wantedBook);
            }
        }
    }
}
    

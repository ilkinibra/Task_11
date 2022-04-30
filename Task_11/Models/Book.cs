using System;
using System.Collections.Generic;
using System.Text;

namespace Task_11.Models
{
    class Book
    {
        public string Name { get; set; }
        public  string AuthorName { get; set; }
        public int PageCount { get; set; }
        private static int Counter = 0;
        public string Code { get; set; }
        public Book(string name,string authotName,int pageCount)
        {
            Counter++;
            Name = name;
            AuthorName = authotName;
            PageCount = pageCount;
            Code = Name.Substring(0, 2).ToUpper() + Counter;
        }
    }
}

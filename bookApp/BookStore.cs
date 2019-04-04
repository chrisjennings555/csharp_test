using System;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Collections.Generic;

namespace bookApp
{
    class BookStore
    {
        static void Main(string[] args)
        {
            XElement bookData = XElement.Load(@"bookdata.xml");  

            IEnumerable<XElement> allBookAuthors =  
            from el in bookData.Elements("book").Elements("author")
            select el;  

            foreach (XElement el in allBookAuthors)  
            Console.WriteLine("The author is " + el.Value);

            IEnumerable<XElement> allBookTitles =  
            from el in bookData.Elements("book").Elements("title")
            select el;  

            foreach (XElement el in allBookTitles)  
            Console.WriteLine("The title of the book is " + el.Value);
        }
    }
}

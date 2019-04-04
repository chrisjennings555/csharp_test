using System;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Collections.Generic;

namespace weatherApp
{
    class Weather
    {
        static void Main(string[] args)
        {
            XElement bookData = XElement.Load(@"bookdata.xml");  

            IEnumerable<XElement> allBooks =  
            from el in bookData.Elements("book").Elements("author")
            select el;  

            foreach (XElement el in allBooks)  
            Console.WriteLine(el.Value);  
        }
    }
}

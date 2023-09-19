using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using BenchmarkDotNet.Attributes;
using Library;
using Microsoft.VisualBasic;

namespace Library
{
    public class Book
    {
        public string name;
        public string resume;
        public double value;
        public int pages;
        public string author;
        
        public string GetData()
        {
            string data = " This book is " + name + " and talks about " + resume + ". " + "Wrote by " + author;
            return data;
        }

      
        public string GetPages()

        {
            string page = " This book contains " + Convert.ToInt32(pages);
            return page;
        }
    }
}

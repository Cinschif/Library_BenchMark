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
        public string Name { get; set; }
        public string Resume { get; set; }
        public int Pages { get; set; }
        public string Author { get; set; }
        public Editor Editor { get; set; }


        public string GetData()
        {
            string data = "This book is " + Name + " and talks about " + Resume + ". " + "Wrote by " + Author;
            return data;
        }
        public string GetPages()

        {
            string page = "This book contains " + Convert.ToInt32(Pages) + ".";
            return page;
        }

        public bool HasEditor()
        { 
            return true;
        }
        
    }
}

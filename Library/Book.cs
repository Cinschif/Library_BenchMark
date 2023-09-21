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

        public Book(string name, string resume, int pages, string author)
        {
            this.Name = name;
            this.Resume = resume;
            this.Pages = pages;
            this.Author = author;
        }
        public Book(Editor editor) 
        {
            Editor = editor;
        }

        //metodo preparado para passar a herança para a classe filha
        public virtual string GetBookInfo()
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
            Console.WriteLine("This Book has an Editor? If Yes,type True, if No, Type False ");
            bool haseditor = Convert.ToBoolean(Console.ReadLine());
            return haseditor;
        }
        
    }
}

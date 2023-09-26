using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Enums;

namespace Library
{
    public class PaperBook : Book
    {
        public PaperBook(string name, string resume, int pages,string author) : base(name, resume, pages,author)
        {
            this.Name=name;
            this.Resume=resume;
            this.Pages=pages;
            this.Author=author;

        }
        public override ETypeBook GetBookType()
        {
            return ETypeBook.Físico;
        }
        public override string GetBookInfo()
        {
            string data = "This book is " + Name + " and talks about " + Resume + ". " + "Wrote by " + Author + ".";
            return data;
        }

        public int GetBookPages()
        {
            return Pages;
        }

    }
}

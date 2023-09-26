using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using Library.Enums;

namespace Library
{
    public class DigitalBook : Book
    {   
        public string waterMark { get; set; }

        public DigitalBook():base()
        {

        }
        public DigitalBook(string name, string resume, int pages, string author, string marcadagua) : base(name, resume,
            pages, author)
        {
            this.waterMark = marcadagua;
        }

        //usando heranca e chamando o metodo que existe na classe mae

        public override string GetBookInfo()
        {
            string data = "This book is " + Name + " and talks about " + Resume + ". " + "Wrote by " + Author + "."+ "It has: " + waterMark;
            return data;
           
        }

        public override ETypeBook GetBookType()
        {
            return ETypeBook.Digital;
        }
    }
}

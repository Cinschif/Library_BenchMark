using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class DigitalBook : Book
    {   
        public string waterMark { get; set; }
        public DigitalBook(string name, string resume, int pages, string author, string marcadagua) : base(name, resume,
            pages, author)
        {
            this.waterMark = marcadagua;
        }

        //usando heranca e chamando o metodo que existe na classe mae
        public override string GetBookInfo()
        {
           return base.GetBookInfo() + " This book has  " + waterMark;
        }
    }
}

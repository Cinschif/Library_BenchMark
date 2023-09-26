using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Enums;

namespace Library
{
    public class PocketBook : Book
    {
        public PocketBook(){}

        public override string GetBookInfo()
        {
            return " don´t have book information yet";
        }

        public override ETypeBook GetBookType()
        {
            return ETypeBook.Bolso;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public  class Editor
    {
        public string name;
        public string site;
        public string phoneNumber;
        public void ShowInfo()
        {
            Console.WriteLine("Author name: " + name);
            Console.WriteLine("Author site: " + site);
            // Console.WriteLine("Author phone number: " + phoneNumber);
        }
    }
}

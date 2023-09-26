using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public  class Editor
    {
        //permite acessar os parametros privados
        public string Name { get; set; }
        public string Site { get; set; }
        public string PhoneNumber { get; set; }

        //construtor

        public Editor()
        {

        }
        public Editor(string name, string site, string phoneNumber)
        {
            this.Name = name;
            this.Site = site;
            this.PhoneNumber = phoneNumber;
        }
        //metodo
        public void ShowInfo()
        {
            Console.WriteLine("Editor name: " + Name);
            Console.WriteLine("Editor site: " + Site);
            Console.WriteLine("Editor phone number: " + PhoneNumber);
        }
    }
}


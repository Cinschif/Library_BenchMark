using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundamentals
{
    public class User
    {
        //atributos
        public string name;
        public string phonenumber;
        public string email;
        public string password;
        public string nickname;

        //metodos
        public string GetDados()
        {
           string dados = "Nome: " + name + " " +  "Telefone: " + phonenumber + " " + "Email: " + email;
           return dados;
        }
     
    }


    
}

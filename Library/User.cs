using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class User
    {
        //atributos
        public string Name { get; set; }
        public string Phonenumber { get; set; }
        public string Email { get; set; }
        public string password { get; set; }
        public string nickname { get; set; }
        public EEstadoCivil estadoCivil;

        public User(string name, string email, string phonenumber)
        {
            this.Name = name;
            this.Email = email;
            this.Phonenumber = phonenumber;
        }

        //metodos
        public string GetUserInfo()
        {
            string dados = "Nome: " + Name + " " + "Telefone: " + Phonenumber + " " + "Email: " + Email + " " +
                           "Estado Civil: " + estadoCivil;
           return dados;
        }

        public enum EEstadoCivil
        {
          Solteiro =1,
          Casado = 2,
          Divorciado = 3
        }
     
    }


    
}

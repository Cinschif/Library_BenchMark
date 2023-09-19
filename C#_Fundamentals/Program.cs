
using Library;

namespace CSharp_Fundamentals
{
    public class Program
    {
        static void Main(string[] args)
        {
            //construtor da classe user; tem o mesmo nome da classe, criar objetos em memoria; instancia de um objeto
            
            Book book=new Book();
            Editor editor = new Editor();

            User user = new User();
            user.email = "cinvet01@gmail.com";
            user.name = "Cin";
            user.phonenumber = "67767-9009";

            User user1 = new User();
            user1.email = "rafa@gmail.com";
            user1.name = "Rafa";
            user1.phonenumber = "5555-98989";

            book = new Book();
            book.name = " Harry Potter";
            book.resume = " A boy that survived";
            book.author = "J.k.Rooling";
            book.pages = 435;
            
            editor = new Editor();
            editor.name = "John";
            editor.phoneNumber = " 76767-989";
            editor.site = "jsdhfjehriehriekdeow";


            Console.WriteLine(user.GetDados());
            editor.ShowInfo();
            Console.WriteLine( book.GetPages());
           




        }
       
        
        
    }


    

}

using Library;

namespace CSharp_Fundamentals
{
    public class Program
    {
        static void Main(string[] args)
        {
            //construtor da classe user; tem o mesmo nome da classe, criar objetos em memoria; instancia de um objeto
            
            Book book=new Book();
            Editor editor = new Editor("O Arqueiro", "www.oarqueiro.com","4567 - 7899");
           
            // User user = new User();
            //user.email = "cinvet01@gmail.com";
            //user.name = "Cin";
            //user.phonenumber = "67767-9009";
            
       
            book.Name = " Harry Potter";
            book.Resume = " A boy that survived";
            book.Author = "J.k.Rooling";
            book.Pages = 435;
            book.Editor = editor;
            
           // Console.WriteLine(user.GetDados());

            Console.WriteLine(book.GetPages());
            Console.WriteLine(book.GetData());

            editor.ShowInfo();

            if (book.HasEditor())
            {
                Console.WriteLine(book.Editor.Name);

            }
            else
            {
                Console.WriteLine("This Book don´t have an Editor yet");
            }
        }
    }


    

}
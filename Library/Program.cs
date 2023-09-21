

namespace Library
{
    public class Program
    {
        static void Main(string[] args)
        {
            //construtor da classe user; tem o mesmo nome da classe, criar objetos em memoria; instancia de um objeto
          
            User user = new User("Cin", "cinvet01@gmail.com", "6789-9009");  
           
            Book book=new Book(" Harry Potter", "A boy that survived", 435, "J.K.Roolink");
           
            Editor editor = new Editor("O Arqueiro", "www.oarqueiro.com","4567 - 7899");
            
            DigitalBook digitalBook = new DigitalBook("A colmeia", "Historia de uma abelha", 25, "mamae", "marcadagua");

            //Console.WriteLine(user.GetUserInfo());
            //Console.WriteLine(book.GetBookInfo());
            //Console.WriteLine(book.GetPages());
            //Console.WriteLine(digitalBook.GetDigitalBookInfo());

            Console.WriteLine( digitalBook.GetBookInfo());
           // Console.WriteLine(digitalBook.GetPages());
           
            //editor.ShowInfo();

            //if (book.HasEditor())
            //{
            //    Console.WriteLine(book.Editor.Name);
            //}
            //else
            //{
            //    Console.WriteLine("This Book don´t have an Editor yet");
            //}
        }
    }


    

}
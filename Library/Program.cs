

namespace Library
{
    public class Program
    {
        static void Main(string[] args)
        {
            //construtor da classe user; tem o mesmo nome da classe, criar objetos em memoria; instancia de um objeto
          
            User user = new User("Cin", "cinvet01@gmail.com", "6789-9009");  
           
          PocketBook pocketbook=new PocketBook();
           
            Editor editor = new Editor("O Arqueiro", "www.oarqueiro.com","4567 - 7899");
            
            PaperBook paperbook = new PaperBook("A colmeia", "Historia de uma abelha", 25, "mamae");


            Console.WriteLine(paperbook.GetBookInfo());
           Console.WriteLine(pocketbook.GetBookInfo());
           
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
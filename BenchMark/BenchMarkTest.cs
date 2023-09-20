using BenchmarkDotNet.Attributes;


namespace Library
{
    public class BenchMarkTest
    {
        private Book book;
        private Editor editor;
        public BenchMarkTest() 
        {
            book = new Book();
            book.Name = " Harry Potter";
            book.Resume = " A boy that survived";
            book.Author = "J.k.Rooling";
            book.Pages = 435;
           
           
            editor = new Editor("O Arqueiro", "4567-7899","www.oarqueiro.com");

        } 
        
       [Benchmark]
       public void BenchMarkShowData()=> book.GetData();
       
       [Benchmark]
        public void BenchMarkShowPages() => book.GetPages(); 
        
        [Benchmark]
        public void BenchMarkHasEditor() => book.HasEditor();
 
        [Benchmark]
        public void BenchMarkShowInfo() => editor.ShowInfo();

    }
}

using BenchmarkDotNet.Attributes;


namespace Library
{
    public class BenchMarkTest
    {
        private Book book;
        private Editor editor;
        public BenchMarkTest()
        {
            book = new Book(" Harry Potter", "A boy that survived", 435, "J.K.Roolink");
            editor = new Editor("O Arqueiro", "4567-7899", "www.oarqueiro.com");

        }

        [Benchmark]
       public void BenchMarkShowData()=> book.GetBookInfo();
       
       [Benchmark]
        public void BenchMarkShowPages() => book.GetPages(); 
        
        //[Benchmark]
       //public void BenchMarkHasEditor() => book.HasEditor();
 
        [Benchmark]
        public void BenchMarkShowInfo() => editor.ShowInfo();

    }
}

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
            book.name = " Harry Potter";
            book.resume = " A boy that survived";
            book.author = "J.k.Rooling";
            book.pages = 435;
           
           
            editor = new Editor();
            editor.name = "John";
            editor.phoneNumber = " 76767-989";
            editor.site = "jsdhfjehriehriekdeow";
           } 
        
       [Benchmark]
       public void BenchMarkShowData()=> book.GetData();
       
       [Benchmark]
        public void BenchMarkShowPages() => book.GetPages(); 
        
        [Benchmark]
        public void BenchMarkShowInfo() => editor.ShowInfo();


    }
}

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using System.Threading;
using Microsoft.Diagnostics.Tracing.Parsers;


namespace Library
{
    [IterationCount(15)]
    [MemoryDiagnoser]
    [ThreadingDiagnoser]
    [DisassemblyDiagnoser]
    [RankColumn,MinColumn,MaxColumn,Q1Column,Q3Column,AllStatisticsColumn]
    [CsvMeasurementsExporter,HtmlExporter]
    public class BenchMarkTest
    {
        private PaperBook paperbook;
        private DigitalBook digitalbook;
        private PocketBook pocketbook;
        private Editor editor;
        public BenchMarkTest()
        {
            paperbook = new PaperBook("A colmeia", "Historia de uma abelha", 25, "mamae");
            digitalbook = new DigitalBook("Harry Potter", "Menino bruxo que sobreviveu", 540, "JkRolling", "sim");
            pocketbook = new PocketBook();
            editor = new Editor("O Arqueiro", "4567-7899", "www.oarqueiro.com");

        }

        [Benchmark(Baseline = true)]
       public void BenchMarkShowDigitalBookData() => digitalbook.GetBookInfo(); 

        [Benchmark]    
        public void BenchMarkShowPaperBookData() => paperbook.GetBookInfo();

        [Benchmark]
        public void BenchMarkShowPocketlBookData() => pocketbook.GetBookInfo();

        [Benchmark]
        public void BenchMarkShowPages() => paperbook.GetPages();

        [Benchmark]
        public void BenchMarkShowInfo() => editor.ShowInfo();

    }
}

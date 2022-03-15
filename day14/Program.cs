using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
namespace day14
{
    enum Frequency
    {
        Weekly,
        Monthly,
        Yearly
    }

    class TestCollection
    {
        List<Edition> editions;
        List<string> list;
        Dictionary<Edition, Magazine> dictMagazineAndEdition;
        Dictionary<string, Magazine> dictStringAndMagazine;
        public static int Foo(int n) { return 0; }
        public TestCollection(int n)
        {
            editions = new List<Edition>(n);
            list = new List<string>(n);
            dictMagazineAndEdition = new Dictionary<Edition, Magazine>(n);
            dictStringAndMagazine = new Dictionary<string, Magazine>(n);
        }
        public void Find(int n)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            editions.Find(x => { return x.CountOfPublicashion == n; });
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
            stopwatch.Start();
            list.Find(x => { return x == n.ToString(); });
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> articles = new List<Article>();
            articles.Add(new Article(new Person("Jo", "Maks", DateTime.Parse("11/12/2012")), "A", 9.9));
            List<Edition> editions = new List<Edition>();
            editions.Add(new Edition("NBC", DateTime.Parse("12/12/2012"), 12000));
            Magazine[] magazines = new Magazine[2];
            magazines[0] = new Magazine("BBC", Frequency.Monthly, DateTime.Parse("12/12/2022"), 120000, articles, editions);
            articles.Clear();
            articles.Add(new Article(new Person("Jon", "Grdon", DateTime.Parse("11/12/2022")), "B", 7.9));
            editions.Clear();
            editions.Add(new Edition("NON", DateTime.Parse("12/12/2022"), 120));
            magazines[1] = new Magazine("ABC", Frequency.Weekly, DateTime.Parse("11/11/2021"), 9000000, articles, editions);
            List<Magazine> list = new List<Magazine>();
            //MagazineCollection magazineCollection = new MagazineCollection();
            //magazineCollection.AddMagazines(magazines);
            //Console.WriteLine("------------------------------------------");
            //magazineCollection.SortOnCountOfPublcashion();
            //Console.WriteLine("------------------------------------------");
            //magazineCollection.SortOnDate();
            //Console.WriteLine("------------------------------------------");
            //magazineCollection.SortOnNameOfEdition();
            //Console.WriteLine("------------------------------------------");
            ////magazineCollection.MaxAverageRate();
            //Console.WriteLine("------------------------------------------");
            //magazineCollection.RatingGroup(4);
            //Console.WriteLine("------------------------------------------");
            MagazineCollection<string> magazineCollection = new MagazineCollection<string>();
            Listener<string> listener = new Listener<string>();
            magazineCollection.MagazineAdded += listener.MagazineAdded;
            magazineCollection.MagazineReplaced += listener.MagazineReplaced;
            magazineCollection.PropertyChanged += listener.PropertyChanged;
            magazineCollection.AddMagazines(magazines);
            magazineCollection[0].CountOfPublicashion = 78;
            magazineCollection.Replace(1, new Magazine("QQQ", Frequency.Weekly, DateTime.Now, 39287, articles, editions));
            Console.WriteLine(listener.ToString());
        }
    }
}

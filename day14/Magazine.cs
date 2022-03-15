using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day14
{
    class Magazine : Edition
    {
        List<Article> listOfArticle;
        List<Edition> listOfEdition;
        Frequency frequency;
        public Magazine()
        {
            this.listOfArticle = null;
            this.listOfEdition = null;
        }
        public Magazine(string nameOfedition, Frequency frequency, DateTime dateOfrelise, int countOfPublicashion, List<Article> listOfArticle, List<Edition> listOfEdition) : base(nameOfedition, dateOfrelise, countOfPublicashion)
        {
            this.listOfArticle = listOfArticle;
            this.listOfEdition = listOfEdition;
            this.frequency = frequency;
        }
        public void sortListOfArticleNameOfArticle()
        {
            Article[] mass = this.listOfArticle.ToArray();
            Array.Sort(mass, new SortArticleName());
            for (int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine(mass[i].ToString());
            }
        }
        public void sortListOfArticleBytheSurnameOfAutror()
        {
            Article[] mass = this.listOfArticle.ToArray();
            Array.Sort(mass, new SortArticalSurName());
            for (int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine(mass[i].ToString());
            }
        }
        public void sortListOfArticleBytheRate()
        {
            Article[] mass = this.listOfArticle.ToArray();
            Array.Sort(mass, new SortArticleRate());
            for (int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine(mass[i].ToString());
            }
        }
        public string Print()
        {
            string result = "";
            for (int i = 0; i < listOfArticle.Count; i++)
            {
                result += listOfArticle[i].ToString();
            }
            return result;
        }
        public double AverageScore
        {
            get
            {
                double sum = 0;
                for (int i = 0; i < listOfArticle.Count; i++)
                {
                    sum += listOfArticle[i].Rating;
                }
                return sum / listOfArticle.Count;
            }
        }
        public List<Article> ListOfArtical
        {
            get { return this.listOfArticle; }
        }
        public bool this[Frequency index]
        {
            get
            {
                switch (index)
                {
                    case Frequency.Monthly: return true;
                    case Frequency.Weekly: return true;
                    case Frequency.Yearly: return true;
                    default: return false;
                }
            }
        }
        public Frequency GetFrequency
        {
            get { return this.frequency; }
        }
        public void AddArticle(List<Article> article)
        {
            for (int i = 0; i < article.Count; i++)
            {
                this.listOfArticle.Add(article[i]);
            }
        }
        public void AddEditor(List<Edition> editions)
        {
            for (int i = 0; i < editions.Count; i++)
            {
                this.listOfEdition.Add(editions[i]);
            }
        }
        public new object DeepCopy()
        {
            return this.MemberwiseClone();
        }
        public override string ToString()
        {
            return $"Название журнала:{this.nameOfedition},Частота выпуска:{this.frequency},Дата выпуска:{this.dateOfrelise},Кол-во выпущенных:{this.countOfPublicashion},Список статей:" + Print();
        }
        public string ToShortString()
        {
            return $"Название журнала:{this.nameOfedition},Частота выпуска:{this.frequency},Дата выпуска:{this.dateOfrelise},Кол-во выпущенных:{this.countOfPublicashion}";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace day14
{
    delegate TKey KeySelector<TKey>(Magazine mg);
    class MagazineCollection<TKey> : Magazine
    {
        public delegate void MagazineListHandler(object source, MagazineListHandlerEventArgs<TKey> args);
        public event MagazineListHandler MagazineAdded;
        public event MagazineListHandler MagazineReplaced;
        List<Magazine> listOfmagazine = new List<Magazine>();

        KeySelector<Edition> key;
        public MagazineCollection() { }
        public MagazineCollection(KeySelector<Edition> edition)
        {
            this.key = edition;
        }
        public void AddDefaultList()
        {
            listOfmagazine.Add(new Magazine());
            MagazineAdded(0, new MagazineListHandlerEventArgs<TKey>("list", "called func AddDefaultList", listOfmagazine.Count - 1));
        }
        public void AddMagazines(Magazine[] magazines)
        {
            for (int i = 0; i < magazines.Length; i++)
            {
                this.listOfmagazine.Add(magazines[i]);
                MagazineAdded(0, new MagazineListHandlerEventArgs<TKey>("list", "called func AddDefaultList", listOfmagazine.IndexOf(magazines[i])));
            }
        }
        public bool Replace(int j, Magazine mg)
        {
            if (j < this.listOfmagazine.Count - 1)
            {
                this.listOfmagazine[j] = mg;
                MagazineReplaced(0, new MagazineListHandlerEventArgs<TKey>("list", "called func Replace", j));
                return true;
            }
            return false;
        }
        public Magazine this[int i] { get { return this.listOfmagazine[i]; } set { this.listOfmagazine[i] = value; MagazineReplaced(0, new MagazineListHandlerEventArgs<TKey>("list", "called func Replace", i)); } }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public void SortOnNameOfEdition()
        {
            Magazine[] mass = this.listOfmagazine.ToArray();
            Array.Sort(mass, new SortEditName());
            for (int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine(mass[i].ToString());
            }
        }
        public void SortOnDate()
        {
            Magazine[] mass = this.listOfmagazine.ToArray();
            Array.Sort(mass, new SortEditDate());
            for (int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine(mass[i].ToString());
            }
        }
        public void SortOnCountOfPublcashion()
        {
            Magazine[] mass = this.listOfmagazine.ToArray();
            Array.Sort(mass, new SortEditCountOfPub());
            for (int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine(mass[i].ToString());
            }
        }
        public override string ToString()
        {
            for (int i = 0; i < this.listOfmagazine.Count; i++)
            {
                Console.WriteLine(listOfmagazine[i].ToString());
            }
            return "";
        }
        public new void ToShortString()
        {
            for (int i = 0; i < this.listOfmagazine.Count; i++)
            {
                Console.WriteLine(listOfmagazine[i].ToShortString());
            }
        }
        public IEnumerable<Magazine> GetMonthly
        {
            get { return this.listOfmagazine.Where(x => { return x.GetFrequency == Frequency.Monthly; }); }
        }
        public void RatingGroup(double value)
        {
            List<Magazine> list = this.listOfmagazine.Where(x => { return x.AverageScore > value; }).ToList();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].ToString());
            }
        }
    }
}

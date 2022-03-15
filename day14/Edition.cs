using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace day14
{
    enum Update { Add, Replace, Property }
    class Edition : IComparable<Edition>, IComparer<Edition>, INotifyPropertyChanged
    {
        protected string nameOfedition;
        protected DateTime dateOfrelise;
        protected int countOfPublicashion;
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {

            Console.WriteLine(propertyName);
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public Edition()
        {
            this.nameOfedition = "";
            this.dateOfrelise = DateTime.Now;
            this.countOfPublicashion = -1;
        }

        public Edition(string nameOfedition, DateTime dateOfrelise, int countOfPublicashion)
        {
            this.nameOfedition = nameOfedition;
            this.dateOfrelise = dateOfrelise;
            this.countOfPublicashion = countOfPublicashion;
        }
        public string NameOfEdition { get { return this.nameOfedition; } }
        public DateTime Date { get { return this.dateOfrelise; } }
        public int CountOfPublicashion
        {
            get { return this.countOfPublicashion; }
            set
            {
                try
                {
                    if (value < 0) { throw new Exception("value<0"); }
                    if (this.countOfPublicashion != value)
                    {
                        this.countOfPublicashion = value;
                        OnPropertyChanged("changet count of publicashin");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("value<0 countOfPublicashion = 0");
                    this.countOfPublicashion = 0;
                }
            }
        }
        public object DeepCopy()
        {
            return this.MemberwiseClone();
        }

        public override bool Equals(object obj)
        {
            Edition edition = (Edition)obj;
            return this.nameOfedition == edition.nameOfedition && this.dateOfrelise == edition.dateOfrelise && this.countOfPublicashion == edition.countOfPublicashion;
        }
        public static bool operator ==(Edition edition, Edition edition1)
        {
            return edition1.nameOfedition == edition.nameOfedition && edition1.dateOfrelise == edition.dateOfrelise && edition1.countOfPublicashion == edition.countOfPublicashion;
        }
        public static bool operator !=(Edition edition, Edition edition1)
        {
            return edition1.nameOfedition != edition.nameOfedition && edition1.dateOfrelise != edition.dateOfrelise && edition1.countOfPublicashion != edition.countOfPublicashion;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public int CompareTo(Edition edition)
        {
            return this.nameOfedition.CompareTo(edition.nameOfedition);
        }
        public int Compare(Edition edition, Edition edition1)
        {
            if (edition.Date > edition1.Date)
                return 1;
            else if (edition.Date < edition1.Date)
                return -1;
            else
                return 0;
        }
        public override string ToString()
        {
            return $"Название журнала:{this.nameOfedition},Дата выпуска:{this.dateOfrelise},Кол-во выпущенных:{this.countOfPublicashion}";
        }
    }

}

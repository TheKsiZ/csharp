using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day14
{
    interface IRateAndCopy
    {
        double Rating { get; }
        object DeepCopy();
    }
    class Article : IRateAndCopy
    {
        Person person;
        string nameOfarticle;
        double rate;

        public Article()
        {
            this.person = null;
            this.nameOfarticle = "";
            this.rate = -1;
        }
        public Article(Person person, string nameOfarticle, double rate)
        {
            this.person = person;
            this.nameOfarticle = nameOfarticle;
            this.rate = rate;
        }
        public string NameOfArticle
        {
            get { return this.nameOfarticle; }
        }
        public double Rating
        {
            get { return this.rate; }
        }
        public string SecondNameOfAuthor
        {
            get { return this.person.SecondName; }
        }
        public object DeepCopy()
        {
            return this.MemberwiseClone();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return $"Автор:{this.person},Название  статьи:{this.nameOfarticle}, рейтинг:{this.rate}";
        }

    }
}

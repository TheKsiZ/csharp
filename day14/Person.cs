using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day14
{
    class Person
    {
        string name;
        string second_name;
        DateTime birthday;

        public Person()
        {
            this.name = "";
            this.second_name = "";
            this.birthday = DateTime.Now;
        }

        public Person(string name, string second_name, DateTime birthday)
        {
            this.name = name;
            this.second_name = second_name;
            this.birthday = birthday;
        }
        public string Name
        {
            get { return this.name; }
        }
        public string SecondName
        {
            get { return this.second_name; }
        }
        public DateTime BirthDay
        {
            get { return this.birthday; }
        }
        public int Year
        {
            set { this.birthday.AddYears(value - this.birthday.Year); }
            get { return this.birthday.Year; }
        }

        public override bool Equals(object obj)
        {
            Person person = (Person)obj;
            if (this.name == person.name && this.second_name == person.second_name && this.birthday == person.birthday) return true;
            return false;
        }
        public object DeepCopy()
        {
            return this.MemberwiseClone();
        }
        public static bool operator ==(Person person, Person person1)
        {
            if (person1.name == person.name && person1.second_name == person.second_name && person1.birthday == person.birthday) return true;
            return false;
        }
        public static bool operator !=(Person person, Person person1)
        {
            if (person1.name != person.name && person1.second_name != person.second_name && person1.birthday != person.birthday) return true;
            return false;
        }
        public override string ToString()
        {
            return $"Имя:{this.name},Фамилия:{this.second_name},Дата рождения:{this.birthday}";
        }
        public string ToShortString()
        {
            return $"Имя:{this.name},Фамилия:{this.second_name}";
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}

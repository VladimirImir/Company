using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    abstract class Human
    {
        private string _name;
        private string _surname;
        private string _patronymic;
        private DateTime _birthDate;
        public Nationality nationality;
        public Gender gender;

        public string getName()
        {
            return _name;
        }
        public void setName(string newName)
        {
            if (newName.Length >= 2 && newName.Length < 24)
            {
                _name = newName;
            }
            else
            {
                throw new ArgumentException("Новое имя не корректное");
            }
        }

        public string Name {
            get {
                return _name;
            }
            set {
                this.setName(value); // value - новые поступающие данные.
            }
        }
        public DateTime BirthDate
        {
            private set
            {
                if (value <= DateTime.Now && value > DateTime.Now.AddYears(-104))
                {
                    _birthDate = value;
                }
                else
                {
                    throw new ArgumentException("Человек из будущего");
                }
            }
            get
            {
                return _birthDate;
            }
        }
        public string Surname
        {
            get;set;
        }        
        public string Patronymic
        {
            get;set;
        }
        public Human()
        {
            Name = "Василий";
            Surname = "Станиславович";
            Patronymic = "nopatronymic";
            BirthDate = DateTime.Now;
            gender = default;
            nationality = default;
        }
        public override string ToString()
        {
            return //$"Human: \n\t" +
                $"Name: {Name};\n\t" +
                $"Surname: {Surname};\n\t" +
                $"Patronymic: {Patronymic};\n\t" +
                $"Gender: {gender};\n\t" +
                $"Nationality: {nationality};\n\t" +
                $"Birth Date: {BirthDate.ToShortDateString()};\n\t";
        }
        public Human(string name, string surname, string patronymic, DateTime birthDate, Gender gender, Nationality nationality)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            BirthDate = birthDate;
            this.gender = gender;
            this.nationality = nationality;
        }
        public virtual void Show() // возможность переопределить в классе потомке.
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(this);
            Console.ResetColor();
        }
    }
}

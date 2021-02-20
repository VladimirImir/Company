using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Director:Human
    {
        public DirectorLevel directorLevel;
        private float _salary;
        public float Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value >= 0.0f && value < float.MaxValue)
                {
                    _salary = value;
                }
                else
                {
                    throw new ArgumentException("Что то не так с зарплатой.");
                }
            }
        }

        public Director() : base()
        {
            Salary = default;
        }
        public Director(string name, string surname, string patronymic, DateTime birthDate,
                Gender gender, Nationality nationality, DirectorLevel directorLevel, float salary)
          : base(name, surname, patronymic, birthDate, gender, nationality)
        {
            this.directorLevel = directorLevel;
            Salary = salary;
        }
        public override string ToString()
        {
            return $"Director: \n\t" +
                base.ToString() + "" +
                $"\n\tDirectorLevel: {directorLevel} ;" +
                $"\n\tSalary: {Salary} $ ; \n\t";
        }
    }
}

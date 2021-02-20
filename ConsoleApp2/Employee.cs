using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    //abstract 
    class Employee : Human
    {
        public EducationLevel educationLevel;
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

        public Employee() : base()
        {
            Salary = default;
        }
        public Employee(string name, string surname, string patronymic, DateTime birthDate,
                        Gender gender, Nationality nationality, EducationLevel educationLevel, float salary)
                 : base(name, surname, patronymic, birthDate, gender, nationality)
        {
            this.educationLevel = educationLevel;
            Salary = salary;
        }
        public override string ToString()
        {
            return $"Employee: \n\t" +
                base.ToString() +
                $"\n\tEducationLevel: {educationLevel}; " +
                $"\n\tSalary: {Salary} $ ; ";
        }
        public new void Show() 
        {
            // я новый метод, я затираю метод базового класс.
            base.Show();
            Console.WriteLine(this);
        }
    }
}

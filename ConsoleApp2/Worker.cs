using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{

    enum CloneNameMethod
    {
        Superficial,
        Complete
    }

    /* Унаследоваться от класс Employee
       Реализовать интерфейс IWorker
    */
    internal class Worker : Employee, IWorker, ICloneable, IComparable
    {
        private bool _isWorking;
        private string _workDescription;
        public bool IsWorking { 
            get { 
                return _isWorking;
            }
        } // Поле интерфейса.

        public string Work() // Метод интерфейся.
        {
            return _workDescription;
        }
        public void StopWorking()
        {
            _isWorking = false;
        }
        public void NextTask(string task)
        {
            if(_isWorking == false)
            {
                if(task.Length > 0)
                {
                    _workDescription = task;
                    _isWorking = true;
                }
                else
                {
                    throw new InvalidOperationException("Не понял задачу.");
                }
            }
            else
            {
                throw new Exception("Я уже занят, я работаю.");
            }
        }
        public Worker() : base()
        {
            _isWorking = true;
            _workDescription = "Ведуться работы по организации самой работы.";
        }
        public Worker(string name, string surname, string patronymic, DateTime birthDate,
                        Gender gender, Nationality nationality, EducationLevel educationLevel, float salary,
                        string workDescription)
            : base(name, surname, patronymic, birthDate, gender, nationality, educationLevel, salary)
        {
            _isWorking = false;
            this.NextTask(workDescription);
        }
        public override string ToString()
        {
            return base.ToString() +
                $"\n\tStatus Working: {IsWorking}; " + 
                $"\n\tCurrent Work: {_workDescription}";
        }

        public object Clone()
        {
            Console.WriteLine("Задействую клонирование объкта");

            // поверхносного копирования - использовать только если нету ссылочных полей.
            // полного копирования.

            /*Worker worker = new Worker();
            worker.Name = this.Name;



            return worker;*/

            return this.MemberwiseClone(); // Поверхносное копирование.
        }
        public object Clone(CloneNameMethod method)
        {
            switch (method)
            {
                case CloneNameMethod.Superficial:
                    break;
                case CloneNameMethod.Complete:
                    return new Worker(
                        this.Name,
                        this.Surname,
                        this.Patronymic,
                        this.BirthDate,
                        this.gender,
                        this.nationality,
                        this.educationLevel,
                        this.Salary,
                        this.Work()
                    );
            }
            throw new AggregateException("Clone Worker Method incorrect.");
        }
        public int CompareTo(object obj)
        {
            // Дефолтная сортировка по имени - по ниспаданию

            Worker worker = obj as Worker;

            if(worker != null)
            {
                return worker.Name.CompareTo(this.Name);// воспользовался стандартным стринговым комперером.
            }
            else
            {
                throw new Exception("Incorrect");
            }
        }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    /* Унаследоваться от класс Employee
       Реализовать интерфейс IWorker
    */
    class Worker : Employee, IWorker
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
    }
}

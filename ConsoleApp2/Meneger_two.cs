using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Meneger_two : Employee, IMenege
    {
        private IWorker[] _workers; // Список рабочих текущего экземпляра менеджера.
        public IWorker[] Workers {  // Поле получения доступа к рабочим текущего менеджера.
            get
            {
                return _workers;
            }
        }
        public void addWorker(IWorker worker)
        {

        }
        public void removeWorker(IWorker worker)
        {

        }
        public IWorker GetWorker(int index)
        {
            throw new NotImplementedException(); // заглушка.
        }        
        public IWorker GetWorker(string workDescription)
        {
            throw new NotImplementedException(); // заглушка.
        }
        public void PushWork(string task, IWorker[] workers)
        {

        }
        public Meneger_two()
        {
            _workers = new IWorker[10];
        }










        public void Control()
        {
            throw new NotImplementedException();
        }

        public void Organize()
        {
            throw new NotImplementedException();
        }
    }
}

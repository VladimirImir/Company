using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class ListOfWorkers
    {
        private int _counter = 0;  // кол-во занятых переменных.
        private int _capacity = 8; // кол-во ячеек массива - стартовое.
        private int _currentCopacity = 0;
        private IWorker[] _workers; // массив сотрудников.
        private enum ChoiseResize
        {
            UP,
            DOWN
        }
        public int Count
        {
            get
            {
                return _counter;
            }
        }
        public ListOfWorkers()
        {
            _currentCopacity = _capacity;
            _workers = new IWorker[_currentCopacity];
        }
        public void AddWorker(IWorker worker)
        {
            if (_counter == _currentCopacity) // мест нет.
            {
                Resize(ChoiseResize.UP);
            }
            _workers[_counter] = worker;
            _counter++;
        }
        public int SearchWorker(IWorker worker)
        {
            int deIndex = -1;
            for (int i = 0; i < _counter; i++)
            {
                if (_workers[i] == worker)
                {
                    deIndex = i;
                    break;
                }
            }
            return deIndex;
        }
        public void RemoveWorker(IWorker worker)
        {
            int ind = SearchWorker(worker);
            if (ind == -1) throw new ArgumentOutOfRangeException("");

            for (int i = ind; i < _counter; i++)
            {
                _workers[i] = _workers[i + 1];
            }
            _workers[_counter - 1] = null;
            _counter--;
            if (_counter + _capacity - 1 < _currentCopacity - _capacity)
            {
                Resize(ChoiseResize.DOWN);
            }
        }
        public IWorker[] Workers
        {
            get
            {
                return _workers;
            }
        }
        // listOfWorkers.RemoveWorkers(listOfWorkers.Workers[0]);
        private void Resize(ChoiseResize resize)
        {
            IWorker[] tmp;
            switch (resize)
            {
                case ChoiseResize.UP:
                    { 
                        _currentCopacity += _capacity;
                        break;
                    }
                case ChoiseResize.DOWN:
                    {
                        if (_counter <= _currentCopacity - _capacity)
                        {
                            _currentCopacity -= _capacity;
                            tmp = new IWorker[_currentCopacity];
                            for (int i = 0; i < _counter; i++)
                            {
                                tmp[i] = _workers[i];
                            }
                        }
                        break;

                    }
            }
            tmp = new IWorker[_currentCopacity];
            for (int i = 0; i < _counter; i++)
            {
                tmp[i] = _workers[i];
            }
            _workers = tmp;

        }
        public IWorker this[int index]
        {
            get
            {
                return _workers[index];
            }
            set
            {
                _workers[index] = value;
            }
        }
        public IWorker this[IWorker worker]
        {
            get
            {
                return _workers[this.SearchWorker(worker)];
            }
            set
            {
                _workers[this.SearchWorker(worker)] = value;
            }
        }
    }
}

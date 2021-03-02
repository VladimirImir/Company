using System;
using System.Collections;

namespace Company
{
    internal class ListOfWorkersEnumerator : IEnumerator
    {
        private ListOfWorkers _listOfWorkers;
        private int _position = -1; // За пределами коллекции.

        public ListOfWorkersEnumerator(ListOfWorkers listOfWorkers)
        {
            this._listOfWorkers = listOfWorkers;
        }

        public object Current
        {
            get
            {
                if (_position == -1 || _position >= _listOfWorkers.Count)
                {
                    throw new InvalidOperationException();
                }
                else
                {
                    return _listOfWorkers.Workers[_position];
                }
            }
        }

        public bool MoveNext()
        {
            if (_position < _listOfWorkers.Count -1)
            {
                _position++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            _position = -1;
        }
    }
}
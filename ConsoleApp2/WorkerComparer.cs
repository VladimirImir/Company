using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Company
{
    class WorkerNameAscComparerT : IComparer<Worker>
    {
        public int Compare( Worker x,  Worker y)
        {
            if (x == null || y == null) return -1;
            else if (x.Name == null && y.Name == null) return 0;
            else if (x.Name == null) return -1;
            else if (y.Name == null) return 1;
            else return x.Name.CompareTo(y.Name);
        }
    }
    class WorkerNameDescComparerT : IComparer<Worker>
    {
        public int Compare( Worker x, Worker y)
        {
            if (x == null || y == null) return 1;
            else if (x.Name == null && y.Name == null) return 0;
            else if (x.Name == null) return 1;
            else if (y.Name == null) return -1;
            else return y.Name.CompareTo(x.Name);
        }
    }
    class WorkerNameAscComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            throw new NotImplementedException();
        }
    }
    class WorkerNameDescComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x is Worker && y is Worker)
            {
                return ((Worker)y).Name.CompareTo(((Worker)x).Name);
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
    class WorkerSurnameAscComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            throw new NotImplementedException();
        }
    }
    class WorkerSurnameDescComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            throw new NotImplementedException();
        }
    }
    class WorkerPatronymicAscComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            throw new NotImplementedException();
        }
    }
    class WorkerPatronymicDescComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            throw new NotImplementedException();
        }
    }
    class WorkerBirthDateAscComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            throw new NotImplementedException();
        }
    }
    class WorkerBirthDateDescComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            throw new NotImplementedException();
        }
    }
    class WorkerSalaryAscComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if(x is Worker && y is Worker)
            {
                return ((Worker)x).Salary.CompareTo(((Worker)y).Salary);
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
    class WorkerSalaryDescComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x is Worker && y is Worker)
            {
                return ((Worker)y).Salary.CompareTo(((Worker)x).Salary);
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }

}

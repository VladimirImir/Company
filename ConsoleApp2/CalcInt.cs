﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class CalcInt : ICalc<CalcInt>
    {
        private int _number;
        public CalcInt(int nam)
        {
            Number = nam;
        }
        public int Number
        {
            get
            {
                return _number;
            }
            set
            {
                _number = value;
            }
        }
        public CalcInt Div(CalcInt a, CalcInt b)
        {
            if (b.Number == 0) throw new DivideByZeroException();
            return new CalcInt(a.Number / b.Number);
        }
        public CalcInt Div(CalcInt a)
        {
            if (a.Number == 0) throw new DivideByZeroException();
            return new CalcInt(Number /= a.Number);
        }

        public CalcInt Multy(CalcInt a, CalcInt b)
        {
            return new CalcInt(a.Number * b.Number);
        }
        public CalcInt Multy(CalcInt a)
        {
            if (a.Number == 0) throw new DivideByZeroException();
            return new CalcInt(Number *= a.Number);
        }

        public CalcInt Substr(CalcInt a, CalcInt b)
        {
            return new CalcInt(a.Number - b.Number);
        }
        public CalcInt Substr(CalcInt a)
        {
            if (a.Number == 0) throw new DivideByZeroException();
            return new CalcInt(Number -= a.Number);
        }

        public CalcInt Sum(CalcInt a, CalcInt b)
        {
            return new CalcInt(a.Number + b.Number);
        }
        public CalcInt Sum(CalcInt a)
        {
            if (a.Number == 0) throw new DivideByZeroException();
            return new CalcInt(Number += a.Number);
        }
        public override string ToString()
        {
            return $"Number: {Number}; ";
        }
    }
}

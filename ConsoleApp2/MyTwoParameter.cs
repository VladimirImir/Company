using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class MyTwoParameter <Tkey, Tvalue>
    {
        public Tkey Key
        {
            get;set;
        }
        public Tvalue Value
        {
            get;set;
        }
        public MyTwoParameter()
        {
            Key = default;
            Value = default;
        }
        public MyTwoParameter(Tkey key, Tvalue val)
        {
            Key = key;
            Value = val;
        }
        public override string ToString()
        {
            return $"Key: {Key}; Value: {Value}; ";
        }
    }
}

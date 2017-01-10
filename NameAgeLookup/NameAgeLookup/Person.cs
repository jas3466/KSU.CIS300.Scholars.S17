using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameAgeLookup
{
    class Person
    {
        private string _name;
        private int _age;

        public Person(string n, int a)
        {
            _name = n;
            _age = a;
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }
    }
}

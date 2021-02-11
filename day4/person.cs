using System;
using System.Collections.Generic;
using System.Text;

namespace day4
{
    class person
    {
        string name;
        int age;
        public person(string n, int a)
        {
            name = n;
            age = a;
        }
        public person()
        {

        }
        public override string ToString()
        {
            return $"this person name :{name}\tage:{age}";
        }
    }
}

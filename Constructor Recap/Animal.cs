using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Recap
{
    public class Animal
    {
        private string _name;
        //private int _age;
        //public Animal(string name)
        //{
        //    _name = name;
        //}
        //public Animal(string name, int age)
        //{
        //    _name = name;
        //    _age = age;
        //}

        public Animal()
        {
            Console.WriteLine("Animal Constructor Called");
        }
        public string GetName()
        {
            return _name;
        }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}

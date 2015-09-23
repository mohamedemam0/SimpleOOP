using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleOOP
{
    class Program
    {
        static void Main(string[] args)
        {

            //Object
            Person object1 = new Person();
            //Object 
            Mohamed object2 = new Mohamed();

            Console.WriteLine(object1.Speak());

            Console.WriteLine(object2.Speak());
            
            Console.ReadLine();
        }


        //Class
        public class Person
        {
            //Properties
            public string name;
            public int age;

            //Method of string return type
            //virtual keyword to allow overriding
            public virtual string Speak()
            {
                return "Hello from Speak Method in Person Class";
            }

            //Overloading: Same name but different signature(No. of parameters and/or return type)
            public string Speak(int x)
            {
                return "0";
            }

        }

        //Class
        //Inherits from Person Class
        public class Mohamed : Person
        {

            //Overriding Method
            public override string Speak()
            {
                return "Hello from Speak Method in Mohamed Class";
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInheritance
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name = "no name", int age = 0)
        {
            Name = name;
            Age = age;
        }

        public void GetNameAndAge()
        {
            Console.WriteLine("The Person Has Name : {0} And Age : {1}", Name, Age);
        }
    }
}
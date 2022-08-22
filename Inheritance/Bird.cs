using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Bird : Animal
    {
       public string name { get; set; }
        public int legs { get; set; }
        public int age { get; set; }
        public string blackandWhite { get; set; }

        public Bird(string name, int legs, int age, string blackandWhite)
        {
            this.name = name;
            this.legs = legs;
            this.age = age;
            this.blackandWhite = blackandWhite;
        }

        public Bird()
        {
        }
    }
}

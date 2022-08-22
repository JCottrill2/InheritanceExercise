using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
     internal class Reptile : Animal
    {
        public bool IsColdBlooded { get; set; } = true;

        public bool HasScales { get; set; } = true;

        public string Environment { get; set; }

        public bool HasBeard { get; set; } = true;

        public string Name { get; set; }

        public Reptile(bool isColdBlooded, bool hasScales, string environment, bool hasBeard, string name)
        {
            IsColdBlooded = isColdBlooded;
            HasScales = hasScales;
            Environment = environment;
            HasBeard = hasBeard;   
            Name = name;
        }

        public Reptile()
        {
        }
    }
}

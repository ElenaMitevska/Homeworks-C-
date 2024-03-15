using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Dog
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }
        public string Eat()
        {
            return $"The dog is now eating!";
        }
        public string Play()
        {
            return $"A dog is now playing!";
        }
        public string ChaseTail()
        {
            return $"A dog is now chaising it's tail.";
        }
        public Dog()
        {

        }
        public Dog(string name, string breed, string color)
        {
            Name = name;
            Breed = breed;
            Color = color;
        }
    
    }
}


using System;

namespace Homework6_3
{
    class Cats
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string EyesColor { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public Cats(string Name, string Color, string EyesColor, int Age, string Gender)
        {
            this.Name = Name;
            this.Color = Color;
            this.EyesColor = EyesColor;
            this.Age = Age;
            this.Gender = Gender;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Cats name :{this.Name}");
            Console.WriteLine($"Cats color :{this.Color}");
            Console.WriteLine($"Cats Eyes color :{this.EyesColor}");
            Console.WriteLine($"Cats age :{this.Age}");
            Console.WriteLine($"Cats gender :{this.Gender}");
        }
    }




    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}

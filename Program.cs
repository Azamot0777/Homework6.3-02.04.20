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

        public Cats(string name, string color, string eyescolor, int age, string gender)
        {
            this.Name = name;
            this.Color = color;
            this.EyesColor = eyescolor;
            this.Age = age;
            this.Gender = gender;
        }
        public void GetInfo()
        {
            Console.WriteLine("///////////////////");
            Console.WriteLine($"Cats name :{this.Name}");
            Console.WriteLine($"Cats color :{this.Color}");
            Console.WriteLine($"Cats Eyes color :{this.EyesColor}");
            Console.WriteLine($"Cats age :{this.Age} month");
            Console.WriteLine($"Cats gender :{this.Gender}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cats k1 = new Cats("Чернышь", "Черный", "Зеленые", 2, "Мальчик");
            Cats k2 = new Cats("Кайковус", "Белый", "Голубые", 5, "Девочка");
            Cats k3 = new Cats("Бульон", "Мокрый асфальт", "Желтые", 9, "Мальчик");
            k1.GetInfo();
            k2.GetInfo();
            k3.GetInfo();
        }
    }
}

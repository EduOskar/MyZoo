using System.Drawing;

namespace MyZoo
{
    class Zoo
    {
        public string name;
        public int age;
        public string breed;
        public string gender;
        public string colour;

        public Zoo()
        {
            this.name = "Ina";
            this.age = 0;
            this.breed = "No breed";
            this.gender = "No gender";
            this.colour = "No colour";
        }

        public Zoo(string name, int age, string breed, string gender, string colour)
        {
            this.name = name;
            this.age = age;
            this.breed = breed;
            this.gender = gender;
            this.colour = colour;
        }
        public void PrintInfo()
        {
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(breed);
            Console.WriteLine(gender);
            Console.WriteLine(colour);
            Console.WriteLine();
        }
        public virtual string MakeSound()
        {
            string noSound = "Makes no sound";
            return $"{noSound}";
        }
        public void eat() 
        {
            Console.WriteLine("NomNomNom");
        }
        public void sleep() 
        {
            Console.WriteLine("zzzZZZzzzZZZ");
        }
    }
}
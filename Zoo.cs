using System.Drawing;

namespace MyZoo
{
    class Zoo // Parentclass that every other class in gonna inherit from
    {
        public string name; // Class variables
        public int age;
        public string breed;
        public string gender;
        public string colour;

        public Zoo() //Construct with base-values
        {
            this.name = "Ina";
            this.age = 0;
            this.breed = "No breed";
            this.gender = "No gender";
            this.colour = "No colour";
        }

        public Zoo(string name, int age, string breed, string gender, string colour) //Construct if user wanna implement their own values
        {
            this.name = name;
            this.age = age;
            this.breed = breed;
            this.gender = gender;
            this.colour = colour;
        }
        public void PrintInfo() //Method to print out information
        {
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(breed);
            Console.WriteLine(gender);
            Console.WriteLine(colour);
            Console.WriteLine();
        }
        public virtual string MakeSound() //Makes a base sound that other classes gonna override later
        {
            string noSound = "Makes no sound";
            return $"{noSound}";
        }
        public void eat()  // Method that all other classes can share if they want
        {
            Console.WriteLine("NomNomNom");
        }
        public void sleep()  // Method that all other classes can share if they want
        {
            Console.WriteLine("zzzZZZzzzZZZ");
        }
    }
}
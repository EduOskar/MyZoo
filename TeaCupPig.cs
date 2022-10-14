namespace MyZoo
{
    class TeaCupPig : Zoo //Sub-class that inherits from base-class
    {
        string specialGreting; //unique class greeting
        public TeaCupPig() //Constructor containing pigs defaultvalues
        {
            this.name = "Teacup Ina";
            this.age = 22;
            this.breed = "Teacup pig";
            this.gender = "Female";
            this.colour = "pink";
            this.specialGreting = "Rolls fiercly in the dirt, invites you in for a nice dirtBath, but only for you ofcourse";
        }
        public TeaCupPig(string name, int age, string breed, string gender, string colour, string specialGreting) :base(name, age, breed, gender, colour) //Constructor if user wanna implement their own values
        {
            this.name = name;
            this.age = age;
            this.breed = breed;
            this.gender = gender;
            this.colour = colour;
            this.specialGreting = specialGreting;
        }
        public void PrintInfo() //method to print out information
        {
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(breed);
            Console.WriteLine(gender);
            Console.WriteLine(colour);
            Console.WriteLine(specialGreting);
            Console.WriteLine();
        }
        public override string MakeSound() // pigs makesound that overrides makesound in base-class
        {
            return "Oink oink oink";
        }

        public void PigAttack() //Pigs unique method
        {
            Console.WriteLine("Charges at you furiously, crashing into you with overwhelming force! - Sadly.. what is overwhelming force for the teacup pig is just a adaorable attempt from your perspective.");
        }
    }
}
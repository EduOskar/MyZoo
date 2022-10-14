namespace MyZoo
{
    class DefaultDog : Zoo //SubClass that inherits from Zoo
    {
        public string playfullness; //Unique class varible for defaultdog
        public DefaultDog() : base() //Construct with base-values
        {
            this.name = "Default Dog Ina";
            this.age = 0;
            this.breed = "Dog breed";
            this.gender = "Dog gender";
            this.colour = "Dog colour";
            this.playfullness = "Dog Play";
        }
        public DefaultDog(string name, int age, string breed, string gender, string colour, string playfullness) :  base(name, age, breed, gender, colour) //the inherited values from Zoo and its own unique varibles
        {
            this.name = name;
            this.age = age;
            this.breed = breed;
            this.gender = gender;
            this.colour = colour;
            this.playfullness = playfullness;
        }
        public void PrintInfo() //Method to print out information with the added class-variables
        {
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(breed);
            Console.WriteLine(gender);
            Console.WriteLine(colour);
            Console.WriteLine(playfullness);
            Console.WriteLine();
        }
        public override string MakeSound() //Sound that overrides the one in the base-class
        {
            return "default voff";
        }
        public void DefaultSize()  //Unique method for sub-class
        {
            Console.WriteLine("Default Size of dog");
        }
        public void DefaultPlay()  //Unique method for sub-class
        {
            Console.WriteLine("Plays very defaulty");
        }
    }
}
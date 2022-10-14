namespace MyZoo
{
    class DefaultDog : Zoo
    {
        public string playfullness;
        public DefaultDog() : base()
        {
            this.name = "Default Dog Ina";
            this.age = 0;
            this.breed = "Dog breed";
            this.gender = "Dog gender";
            this.colour = "Dog colour";
            this.playfullness = "Dog Play";
        }
        public DefaultDog(string name, int age, string breed, string gender, string colour, string playfullness) :  base(name, age, breed, gender, colour)
        {
            this.name = name;
            this.age = age;
            this.breed = breed;
            this.gender = gender;
            this.colour = colour;
            this.playfullness = playfullness;
        }
        public void PrintInfo()
        {
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(breed);
            Console.WriteLine(gender);
            Console.WriteLine(colour);
            Console.WriteLine(playfullness);
            Console.WriteLine();
        }
        public override string MakeSound()
        {
            return "default voff";
        }
        public void DefaultSize() 
        {
            Console.WriteLine("Default Size of dog");
        }
        public void DefaultPlay() 
        {
            Console.WriteLine("Plays very defaulty");
        }
    }
}
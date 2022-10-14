namespace MyZoo
{
    class BigDog : DefaultDog
    {
        string bigDogAttack;
        public BigDog() : base()
        {
            this.name = "Ina";
            this.age = 22;
            this.breed = "Samoyed";
            this.gender = "Female";
            this.colour = "White";
            this.bigDogAttack = "Engages with bites and roars";
        }
        public BigDog(string name, int age, string breed, string gender, string colour, string playfullness, string bigDogAttack) : base(name, age, breed, gender, colour, playfullness)
        {
            this.name = name;
            this.age = age;
            this.breed = breed;
            this.gender = gender;
            this.colour = colour;
            this.bigDogAttack = bigDogAttack;
        }
        public void PrintInfo()
        {
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(breed);
            Console.WriteLine(gender);
            Console.WriteLine(colour);
            Console.WriteLine(playfullness);
            Console.WriteLine(bigDogAttack);
            Console.WriteLine();
        }
        public override string MakeSound()
        {
            
            return "RUFFRUFFRUFF!!";
        }
        public void BigSize()
        {
            Console.WriteLine($"Largest {breed} of them all, this one will be fierce! ");
        }
        public void BigPlay()
        {
            Console.WriteLine("Wrestles with the playmate, growl and Nibbles");
        }

    }
}
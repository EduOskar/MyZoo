namespace MyZoo
{
    class BigDog : DefaultDog //Sub-Class that inherits from Parent-class DefaultDog
    {
        string bigDogAttack; //Unique class-variable for BigDog
        public BigDog() : base()  //Constructor that contains Default-values
        {
            this.name = "Ina";
            this.age = 22;
            this.breed = "Samoyed";
            this.gender = "Female";
            this.colour = "White";
            this.bigDogAttack = "Engages with bites and roars";
        }
        public BigDog(string name, int age, string breed, string gender, string colour, string playfullness, string bigDogAttack) : base(name, age, breed, gender, colour, playfullness) //If user wanna implement their own values
        {
            this.name = name;
            this.age = age;
            this.breed = breed;
            this.gender = gender;
            this.colour = colour;
            this.bigDogAttack = bigDogAttack;
        }
        public void PrintInfo() //Method to print the info
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
        public override string MakeSound() //MakeSound that overrides parentclass makesound
        {
            
            return "RUFFRUFFRUFF!!";
        }
        public void BigSize() //Unique method for big Dog that just contain a writeline
        {
            Console.WriteLine($"Largest {breed} of them all, this one will be fierce! ");
        }
        public void BigPlay() //Unique method for big dog that just contain a writeline
        {
            Console.WriteLine("Wrestles with the playmate, growl and Nibbles");
        }

    }
}
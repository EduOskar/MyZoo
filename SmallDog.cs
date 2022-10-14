﻿namespace MyZoo
{
    class SmallDog : DefaultDog //Child-Class that inherits from DefaultDog
    {
        string smallDogAttack; //Class varible for smalldog
        public SmallDog() : base() //Constrctor that contain defaultvalues
        {
            this.name = "Also Ina";
            this.age = 22;
            this.breed = "Small Samoyed";
            this.gender = "Female";
            this.colour = "White";
            this.smallDogAttack = "barks very fiercly, but to no avail because it sounds very much like its opting to reach the Soprano range moreso than scaring away the attacker ";
        }
        public SmallDog(string name, int age, string breed, string gender, string colour, string playfullness, string smallDogAttack) : base(name, age, breed, gender, colour, playfullness) //Constructor incase user wanna implement their own values
        {
            this.name = name;
            this.age = age;
            this.breed = breed;
            this.gender = gender;
            this.colour = colour;
            this.smallDogAttack = smallDogAttack;
        }
        public void PrintInfo() //Method to print out constructor
        {
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(breed);
            Console.WriteLine(gender);
            Console.WriteLine(colour);
            Console.WriteLine(playfullness);
            Console.WriteLine(smallDogAttack);
            Console.WriteLine();
        }
        public override string MakeSound() //Makesound that overries in base-class
        {
            return "voff...voff.voff...?"; ;
        }
        public void SmallSize() //Unique method for smalldog
        {
            Console.WriteLine($"smallest dog i have ever seen, is it a scrawny cat? a rat? this mystery will remain unsolved ages to come!");
        }
        public void SmallPlay() //unique method for small dog
        {
            Console.WriteLine("Walks up and bite the biggest dog only to run back to owner whimpering, then proceeds to bark in its highest pitch possible to cause maximal eardrum damage... From a safe distance ofcourse ");
        }

    }
}
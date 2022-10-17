namespace MyZoo
{
    class Cow : Zoo  //child-class that inherits from base-class
    {
        string cowAttack;  //unique class variable for cow
        public Cow() // constructor containing default cow-values
        {
            this.name = "Ina but Cow";
            this.age = 22;
            this.breed = "Cow";
            this.gender = "Female";
            this.colour = "White with brown spots";
            this.cowAttack = "Attack fiercly, but only with big words.. They do hurt";
        }
        public Cow(string name, int age, string breed, string gender, string colour, string cowAttack) :base(name, age, breed, gender, colour) //If user wanna implement their own values
        {
            this.name = name;
            this.age = age;
            this.breed = breed;
            this.gender = gender;
            this.colour = colour;
            this.cowAttack = cowAttack;
        }
        public void PrintInfo() //method to print info
        {
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(breed);
            Console.WriteLine(gender);
            Console.WriteLine(colour);
            Console.WriteLine(cowAttack);
            Console.WriteLine();
        }
        public override string MakeSound() //Method that overrides Default sound from Zoo
        {
            return "Mooo";
        }
        public void CowDefense() //Unique method for class Cow to use
        {
            Console.WriteLine("Uses excelently shaped horns to reflect the sunlight into the eyes of the attacker, then hides behind a small bush");
        } 

    }

}
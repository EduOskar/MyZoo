namespace MyZoo
{
    class Cow : Zoo 
    {
        string cowAttack;
        public Cow()
        {
            this.name = "Ina but Cow";
            this.age = 22;
            this.breed = "Cow breed";
            this.gender = "Female";
            this.colour = "White with brown spots";
            this.cowAttack = "Attack fiercly, but only with big words.. They do hurt";
        }
        public Cow(string name, int age, string breed, string gender, string colour, string cowAttack) :base(name, age, breed, gender, colour)
        {
            this.name = name;
            this.age = age;
            this.breed = breed;
            this.gender = gender;
            this.colour = colour;
            this.cowAttack = cowAttack;
        }
        public void PrintInfo()
        {
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(breed);
            Console.WriteLine(gender);
            Console.WriteLine(colour);
            Console.WriteLine(cowAttack);
            Console.WriteLine();
        }
        public void CowDefense() 
        {
            Console.WriteLine("Uses excelently shaped horns to reflect the sunlight into the eyes of the attacker, then hides behind a small bush");
        } 

        public override string MakeSound() 
        {
            return "Mooo";
        }
    }

}
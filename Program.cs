namespace MyZoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Initiate all classes
            Zoo defaultZoo = new Zoo(); 
            DefaultDog defaultDog = new DefaultDog();
            BigDog bigDog = new BigDog();
            SmallDog smallDog = new SmallDog();
            Cow firstCow = new Cow();
            TeaCupPig cupPig = new TeaCupPig();

            //Print out all makesounds from the different animals
            Console.WriteLine(defaultZoo.MakeSound());
            Console.WriteLine(defaultDog.MakeSound());
            Console.WriteLine(bigDog.MakeSound());
            Console.WriteLine(smallDog.MakeSound());
            Console.WriteLine(firstCow.MakeSound());
            Console.WriteLine(cupPig.MakeSound());

            Console.WriteLine(); //Made a very simple space between MakeSound and the rest for easier readability in the console

            //Print out all information regarding each class
            defaultZoo.PrintInfo();
            defaultDog.PrintInfo();
            bigDog.PrintInfo();
            smallDog.PrintInfo();
            firstCow.PrintInfo();
            cupPig.PrintInfo();

            
      
            }
            
    }
}
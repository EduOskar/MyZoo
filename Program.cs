namespace MyZoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool b = true;
            Zoo defaultZoo = new Zoo();
            DefaultDog defaultDog = new DefaultDog();
            BigDog bigDog = new BigDog();
            SmallDog smallDog = new SmallDog();
            Cow firstCow = new Cow();
            TeaCupPig cupPig = new TeaCupPig();

            Console.WriteLine(defaultZoo.MakeSound());
            Console.WriteLine(defaultDog.MakeSound());
            Console.WriteLine(bigDog.MakeSound());
            Console.WriteLine(smallDog.MakeSound());
            Console.WriteLine(firstCow.MakeSound());
            Console.WriteLine(cupPig.MakeSound());

            Console.WriteLine();

            defaultZoo.PrintInfo();
            defaultDog.PrintInfo();
            bigDog.PrintInfo();
            smallDog.PrintInfo();
            firstCow.PrintInfo();
            cupPig.PrintInfo();

            
      
            }
            
    }
}
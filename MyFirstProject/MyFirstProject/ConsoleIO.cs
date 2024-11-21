namespace ConsoleIO
{
    class Program
    {
        public static void Consoler()
        {
            System.Console.WriteLine("Hello, my name is Chirag!");

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);
        
            System.Console.WriteLine("Your name is "+name+" and your age is "+age+"!");

            Console.ReadLine();

        }
    }
}

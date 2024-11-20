namespace Exercise
{
    class Program
    {
        // Exercise variables
        public static string name = "Chirag";  // Variable to hold your name
        public static string phoneNumber = "123-456-7890";  // Variable to hold your phone number
        public static int age = 25;  // Variable to hold your age

        // Extra: Defining variables using the 'var' keyword (only inside methods)
        public static void DisplayVariables()
        {
            // Using var here is valid, because it's in a method
            var city = "New York";  // Example of using var (implicit typing)
            Console.WriteLine("City: " + city);  // Print the city variable

            var name = "Chirag";
            var number = "012345678";
            var age  = 22;

            System.Console.WriteLine(name);
            System.Console.WriteLine(number);
            System.Console.WriteLine(age);
        }
    }
}
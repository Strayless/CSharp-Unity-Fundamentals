namespace OddEven
{
    class Program
    {
        /*
        * Create & initialize two ints
        * Make a variable to work out the remainder
        * Output the first int variable to another number
        * Change the first int variable to another number
            * and recalculate the remainder 
            * output new remainder to the screen
        */
        
        public static void OddEvenCheck()
        {
            int num1 = 10;
            int num2 = 2;
            int remainder = num1 % num2; 
            System.Console.WriteLine(remainder);

            num1 = 11;
            remainder = num1 % num2;
            System.Console.WriteLine(remainder);
        }
    }
}

namespace Constants
{
    class Program
    {
        // Constants
        public const int vat = 20;
        public const double percentVAT = vat / 100.0; // Always use a double for fractional values.
        public const string version = "v1.0";

        // Instance variables (can be modified, unlike constants)
        public static int balance = 1000;
    }
}
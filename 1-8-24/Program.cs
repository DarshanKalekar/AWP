class Program
{
     public static void Main(string[] args)
    {
        
        if (args.Length == 0)
        {
            Console.WriteLine("Please provide the price of the item as a command line argument.");
            return;
        }

        
        if (double.TryParse(args[0], out double priceInRupees))
        {
            int priceInPaise = (int)(priceInRupees * 100);
	    Console.WriteLine("{priceInPaise} paise");
        }
        else
        {
            System.Console.WriteLine("Invalid input. Please provide a valid number.");
        }
    }
}

 class Program
    {
        public void demo1( int number)
        {
            int fact = number;
            for (int i = number - 1; i >= 1; i--)
            {
                fact = fact * i;
            }
            System.Console.WriteLine("\nFactorial of Given Number is: "+fact);
            System.Console.ReadLine();
 
        }
    }

class demo
	{
	public static void Main(string[] args)
	{
	 	
            	 int number = int.Parse(args[0]);
		Program obj = new Program();
		obj.demo1(number);

	}
}
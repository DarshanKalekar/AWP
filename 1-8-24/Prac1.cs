class Product
{
	public static void Main(string[] args)
	{
		int product = 0;
		int a = System.Convert.ToInt32(args[0]);
		int b = System.Convert.ToInt32(args[1]);
		int c = System.Convert.ToInt32(args[2]);
		int d = System.Convert.ToInt32(args[3]);
		product = a*b*c*d;
		System.Console.WriteLine("product of 4 integer are " + product);
		
	}
}
class Product
{
	public static void demo(int num1,int num2,int num3,int num4)
	{
		
		
			int product=num1*num2*num3*num4;

			System.Console.WriteLine("The product of the integer entered is: {0}", product);
		
	}
}
class a
{
	public static void Main(string[] args)
	{

		int num1=int.Parse(args[0]);
		int num2=int.Parse(args[1]);
		int num3=int.Parse(args[2]);
		int num4=int.Parse(args[3]);	
		Product.demo(num1,num2,num3,num4);
	}
}
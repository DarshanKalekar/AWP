class FloatPoint
{
	private float a =  20.5F,b = 6.4F;
	public void FloatP()
	{
		
		System.Console.WriteLine("a = " + a);
		System.Console.WriteLine("b = " + b);
		System.Console.WriteLine("a+b = " + (a+b));
		System.Console.WriteLine("a-b = " + (a-b));
		System.Console.WriteLine("a*b = " + (a*b));
		System.Console.WriteLine("a/b = " + (a/b));
		System.Console.WriteLine("a%b = " + (a%b));

		
				
	}
}
class MainFloatPoint
{
	public static void Main(string[] args)
	{
		FloatPoint obj = new FloatPoint();
		obj.FloatP();
	}
}
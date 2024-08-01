class MathTest
{
	public static void main ()
	{
		System.Console.WriteLine("sines of angles from 0 to 90 degrees");
		for (double theta = 0.0; theta < = 90.00; theta + = 15)
		{
			double x = Math.Sin (theta * Math.PI/180);
			System.Console.WriteLine ("Sin" + theta);
			System.Console.WriteLine(" ={0:F4}" + X);
		}
	}
}
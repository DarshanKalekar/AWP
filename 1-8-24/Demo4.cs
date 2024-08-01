class Demo4
{
	int b;
	public Demo4(int x)
	{
		b=x;
		for(int i=1;i<=b;i++)
		{
			System.Console.WriteLine();
			for(int j=1;j<=i;j++)
			{
				System.Console.Write(i);
			}
		}
	}
}
class MainDemo4
{
	public static void Main(string[] args)
	{
		Demo4 obj = new Demo4(5);
	}
}
	 
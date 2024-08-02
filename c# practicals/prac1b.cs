class a 
{
 	public void method(int count)
	{	
		int i, f1=0 , f2=1 , f3=0;
		System.Console.WriteLine(f1);
		System.Console.WriteLine(f2);
		for (i=0; i <= count;i++)
		{
			f3=f1+f2;
			System.Console.WriteLine(f3);
			f1=f2;
			f2=f3;
		}
	}
}
class Fibanocci
{ 
	static void Main (string[] args)
	{
		int count;
		a obj=new a();
		//System.Console.WriteLine ("Enter the number:");
		count = int.Parse(args[0]);
		obj.method(count);
	}
}

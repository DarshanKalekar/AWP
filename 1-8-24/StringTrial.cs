public class StringTrial
{
	string str1;
	public void display()
	{
		str1 = "tyit";
		str2 = "class";

		System.Console.WriteLine(@$"{str1}");
	}
}
class StringTrialClient
{
	public static void Main(string[] args)
	{
		StringTrial obj = new StringTrial();
		obj.Display();
	}
}
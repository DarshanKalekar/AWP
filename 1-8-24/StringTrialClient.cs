public class StringTrial
{
	string str1,str2,str3;
	public void Display()
	{
		str1 = @"t/yit";
		str2 = "class";
		str3 ="c:\\class";
		//str3 =System.String.Empty;
		System.Console.WriteLine("str = {0} \nstr2 = {1} \nstr3 = {2}",str1,str2,str3);
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
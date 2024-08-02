class Program
    {
       public void shri (int number)
        {
           
            bool IsPrime = true;

            for (int i = 2; i < number/2; i++)
            {
                if (number % i == 0)
                {
                    IsPrime = false;
                    break;
                }
            }

            if (IsPrime)
            {
                System.Console.Write("Number is Prime.");
            }
            else
            {
                System.Console.Write("Number is not Prime.");
            }
            System.Console.ReadKey();
        }
    }
class dk
{
	 static void Main(string[] args)
	{
	
            int number = int.Parse(args[0]);
	  Program obj= new Program ();
		obj.shri(number);
	}
}
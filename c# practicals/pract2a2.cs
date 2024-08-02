class Program
    {
       public void demo1(double dollar, double val)
        {
                    
                    double rupee = dollar * val;
                    System.Console.WriteLine("{0} Dollar Equals {1} Rupees", dollar, rupee);               
         }
    }


class demo 
{
	 public static void Main(string[] args)

	{
		double dollar,val;
            	val = double.Parse(args[0]);
            	dollar= int.Parse(args[1]);
		Program obj = new Program();
		obj.demo1(dollar,val);
	
	}
		
}
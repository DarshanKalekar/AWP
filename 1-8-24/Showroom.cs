class Showroom
{
	public static void Main(string[] args)
	{
		double obtained,totalAmount = 0;
		
		obtained = System.Convert.ToDouble(args[0]);
		string cloth = System.Convert.ToString(args[1]);


		switch(cloth)
		{
			case "MilkCloth":
				if(obtained <=100)
				{
				 	totalAmount = obtained;
				}
				else if(obtained <=200)
				{
					totalAmount = obtained - (obtained * 0.05); 	
				}
				else if(obtained <=300)
				{
					totalAmount = obtained - (obtained * 0.075); 	
				}
				else
				{
					totalAmount = obtained - (obtained * 0.1); 	
				}
				break;
			case "HandloonCloth":
				if(obtained <=100)
				{
				 	totalAmount = obtained - (obtained * 0.05);
				}
				else if(obtained <=200)
				{
					totalAmount = obtained - (obtained * 0.075); 	
				}
				else if(obtained <=300)
				{
					totalAmount = obtained - (obtained * 0.01); 	
				}
				else
				{
					totalAmount = obtained - (obtained * 0.15); 	
				}
				break;
				}
			System.Console.WriteLine("YOU HAVE TO PAY : " + totalAmount);

	}
}
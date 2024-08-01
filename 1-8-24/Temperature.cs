class Temperature
{
        public static void Main(string[] args)
        { 
		double temp = System.Convert.ToDouble(args[0]);
		double C = temp - (32 / 1.75);

		System.Console.WriteLine("Temp(C) = {0} \nTemp(F) = {1}",C,temp);
         }

}

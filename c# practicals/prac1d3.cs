class vowel
{
  public void demo1(char ch)
    {
      
       
          switch (ch)  
            {
                case 'a':
                    System.Console.WriteLine("The Alphabet is vowel");  
                    break;
                case 'i':
                    System.Console.WriteLine("The Alphabet is vowel"); 
                    break;
                case 'o':
                    System.Console.WriteLine("The Alphabet is vowel"); 
                    break;
                case 'u':
                    System.Console.WriteLine("The Alphabet is vowel");  
		    break;
                case 'e':
                    System.Console.WriteLine("The Alphabet is vowel"); 
                    break;
                default:
                    System.Console.WriteLine("The Alphabet is consonant");  
                    break;
            }
        
        
	}
}
class demo 
{
	public static void Main(string[] args)
	{
	vowel obj=new vowel();
	
		char ch; 
		  ch = System.Convert.ToChar(args[0]);  
			

       
		obj.demo1(ch);
	}
}
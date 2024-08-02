class Quadratic
{  
    public static void Main(string[] args) 
    {
        int a, b, c; 
        double d, x1, x2;  
        System.Console.Write("\n\n"); 
        System.Console.Write("Calculate root of Quadratic Equation :\n");  
        System.Console.Write("----------------------------------------"); 
        System.Console.Write("\n\n");

        System.Console.Write("Input the value of a : ");  
        a = System.Convert.ToInt32(System.Console.ReadLine());  
        System.Console.Write("Input the value of b : "); 
        b = System.Convert.ToInt32(System.Console.ReadLine()); 
        System.Console.Write("Input the value of c : ");  
        c = System.Convert.ToInt32(System.Console.ReadLine());  

        d = b * b - 4 * a * c;  

        if (d == 0)  
        {
            System.Console.Write("Both roots are equal.\n");  
            x1 = -b / (2.0 * a);  
            x2 = x1; 
            System.Console.Write("First Root Root1= {0}\n", x1);  
            System.Console.Write("Second Root Root2= {0}\n", x2);  
        }
        else if (d > 0)  
        {
            System.Console.Write("Both roots are real and different.\n");  

            x1 = (-b + System.Math.Sqrt(d)) / (2 * a);  
            x2 = (-b - System.Math.Sqrt(d)) / (2 * a);  

            System.Console.Write("First Root Root1= {0}\n", x1);  
            System.Console.Write("Second Root Root2= {0}\n", x2);  
        }
        else
        {
            System.Console.Write("Roots are imaginary;\nNo Solution. \n\n");  
        }
    }
}


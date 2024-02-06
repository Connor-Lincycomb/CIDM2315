namespace Homework4;

class Program
{
    static void Main(string[] args)
    {
        // Connor Lincycomb CIDM 2315 Homework 5 Question 1
        Console.WriteLine("--------Question 1--------");
        int value = Largest(3,5);
        Console.WriteLine("The largest number is: " + value);

        // Question 2
        Console.WriteLine("--------Question 2--------");
        Triangle("right",7); 
        // Change to left for a left triangle, and int to change its size
    }
        
        // Method for Question 1
    static int Largest(int a, int b)
        {
        Console.WriteLine("a = " + a + "; b = " + b);
        if(a>b)
        {
           return a;
        }
        else
        {
            return b;
        }
        }


        // Method for Question 2
    static void Triangle(string shape, int S)
    {
        if(shape=="left")
        {
            Console.WriteLine("N = " + S + "; Shape is " + shape);
            for(int i=0; i<S; i+=1)
            {
            for(int k=0; k<S; k+=1)
            {
                if(k<=i)
                Console.Write("*");
            }
            Console.WriteLine();  
            }
        }
        else if(shape=="right")
        {
            Console.WriteLine("N = " + S + "; Shape is " + shape);
            for(int l=0; l<S; l+=1)
            {
            
            for(int p=(S-2); p>=0; p--)
            {
                if(p>=l)
                Console.Write(" ");
            }
            
            for(int j=0; j<S; j+=1)
            {
                if(j<=l)
                Console.Write("*");
            }
            Console.WriteLine();  
            }
        

        }
    }

}

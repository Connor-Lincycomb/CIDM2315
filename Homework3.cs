namespace Homework3;

class Program
{
    static void Main(string[] args)
    {
        // Connor Lincycomb CIDM 2315 Homework 3 Question 1
        Console.WriteLine(@"--------Question 1--------");
        Console.WriteLine("Input an integer: ");
        string N = Console.ReadLine();
        int N1 = Convert.ToInt16(N);
        if (N1 == 1 || N1 == 2)
        {
            Console.WriteLine("N is prime");
        }
        else
        {
            for (int i = 2; i<=(N1-1); i+=1)
            {
                if (N1%i == 0)
                {
                Console.WriteLine("N is non-prime");
                break;
                }
                else
                {
                    if (i == (N1-1))
                    {
                    Console.WriteLine("N is prime"); 
                    }
                    else
                    {
                        continue;
                    }
                    
                }
            }
        }
        
        // Question 2
        Console.WriteLine(@"--------Question 2--------");
        Console.WriteLine("Assign an int value to N: ");
        string val = Console.ReadLine();
        int val1 = Convert.ToInt16(val);
        for (int k = 0; k<val1; k+=1)
        {
            for (int i = 0; i<val1; i+=1)
            {
              Console.Write("#");
            }
            Console.WriteLine();
        }

        // Question 3
        Console.WriteLine(@"--------Question 3--------");
        Console.WriteLine("Assign an int value to N: ");
        string value = Console.ReadLine();
        int value1 = Convert.ToInt16(value);
        for (int k = 0; k < value1; k+=1)
        {
            for (int i = 0; i<value1; i+=1)
            {
                if (i<=k)
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine();
        }
    }
}

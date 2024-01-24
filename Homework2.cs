namespace Homework2;

class Program
{
    static void Main(string[] args)
    {
        // Connor Lincycomb CIDM2315 HW 2 Question 1 
        Console.WriteLine("Please input letter grade:");
        string grade = Console.ReadLine();
        if (grade == "A")
        {
            Console.WriteLine("GPA Point: 4");
        }
        else if (grade == "B")
        {
            Console.WriteLine("GPA Point: 3");
        }
        else if (grade == "C")
        {
            Console.WriteLine("GPA Point: 2");
        }
        else if (grade == "D")
        {
            Console.WriteLine("GPA Point: 1");
        }
        else if (grade == "F")
        {
            Console.WriteLine("GPA Point: 0");
        }
        else
        {
            Console.WriteLine("Wrong Letter Grade!");
        }

        // Question 2
        Console.WriteLine("Please input the first number:");
        string number1 = Console.ReadLine();
        Console.WriteLine("Please input the second number:");
        string number2 = Console.ReadLine();
        Console.WriteLine("Please input the third number:");
        string number3 = Console.ReadLine();
        int numberone = Convert.ToInt16(number1);
        int numbertwo = Convert.ToInt16(number2);
        int numberthree = Convert.ToInt16(number3);
        if (numberone < numbertwo)
        {
            if (numberone < numberthree)
            {
                Console.WriteLine("The smallest value is: "+numberone);
            }
            else 
            {
                Console.WriteLine("The smallest value is: "+numberthree);
            }
            
        }
        else if (numbertwo < numberthree)
        {
            Console.WriteLine("The smallest value is: "+numbertwo);
        }
        else if (numberthree < numbertwo)
        {
            Console.WriteLine("The smallest value is: "+numberthree);
        }
        else
        {
            Console.WriteLine("Please do not enter integers of equivalent value");
        }

        // Bonus Question
        Console.WriteLine("Please input a year: ");
        string year = Console.ReadLine();
        int yearint = Convert.ToInt16(year);
        if (yearint%4 == 0)
        {
            if (yearint%100 == 0)
            {
                if (yearint%400 ==0)
                {
                    Console.WriteLine(yearint+" is a Leap Year.");
                }
                else 
                {
                    Console.WriteLine(yearint+" is not a Leap Year.");
                }
            }
            else
            {
                Console.WriteLine(yearint+" is a Leap Year.");
            }
            
            
        }
        else 
        {
            Console.WriteLine(yearint+" is not a Leap Year.");
        }

    }

}


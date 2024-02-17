namespace Homework5;

class Program
{
    
    // Connor Lincycomb CIDM 2315 Homework 5
    static void Main(string[] args)
    {
    // Question 1
        int number1 = getInteger();
        int number2 = getInteger();
        Console.WriteLine("a = " + number1 + ", b = " + number2);
        int value = Largest(number1,number2);
        Console.WriteLine("The largest number is: " + value);


    // Question 2
        int x1 = getInteger(); // UDM 1 from Q1
        int x2 = getInteger();
        int x3 = getInteger();
        int x4 = getInteger();
        Console.WriteLine("a = " + x1 + ", b = " + x2 + ", c = " + x3 + ", d = " + x4);
        int max1 = Largest(x1,x2); // UDM 2 from Q1
        int max2 = Largest(x3,x4);
        int max = Largest(max1,max2);
        Console.WriteLine("The largest number is: " + max);


    // Question 3
        createAccount();
    }

    // UDM 1
    static int getInteger()
    {
        Console.WriteLine("Please input an integer: ");
        string a1 = Console.ReadLine();
        int num1 = Convert.ToInt16(a1);
        return num1;

    }

    // UDM 2 
    static int Largest(int one1, int two2)
    {
        if(one1>two2)
        {
           return one1;
        }
        else
        {
            return two2;
        }
    }

    // UDM a for Q3
    static bool checkAge(int birth_year)
    {
    int currentyear = 2024;
	int age = currentyear-birth_year;
	if (age >=18)
    {
        return true;
    } 
	else
    {
        return false;
    }
    }


    // UDM b for Q3
    static void createAccount()
    {
        Console.WriteLine("Enter Your Username: ");
        string Username = Console.ReadLine();
        Console.WriteLine("Enter Your Password: ");
        string Password = Console.ReadLine();
        Console.WriteLine("Enter Your Password Again: ");
        string Password1 = Console.ReadLine();
        Console.WriteLine("Enter Your Birthyear: ");
        string yearborn = Console.ReadLine();
        int yearborn1 = Convert.ToInt16(yearborn);
        bool agevalue = checkAge(yearborn1);
        if (agevalue == true)
        {
            if (Password == Password1)
            {
                Console.WriteLine("Account is created successfully");
            }
            else
            {
                Console.WriteLine("Wrong Password");
            }
        }
        else
        {
            Console.WriteLine("Could not create an account.");
        }
    }

}


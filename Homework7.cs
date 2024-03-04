namespace Homework7;

class Program
{
    static void Main(string[] args)
    {
        // Initial object creation
        Customer cust1 = new Customer(input_cus_age:28, input_cus_name:"Alice", input_cus_id:110);
        cust1.PrintCusInfo();
        Customer cust2 = new Customer(input_cus_age:30, input_cus_name:"Bob", input_cus_id:111);
        cust2.PrintCusInfo();
        // Redefine objects' ids with ChangeID method
        cust1.ChangeID(220);
        cust2.ChangeID(221);
        // Reprint object information
        cust1.PrintCusInfo();
        cust2.PrintCusInfo();
        // Calling CompareAge method to print older customer's name
        cust2.CompareAge(cust1);
    }
}


class Customer
{
    private int cus_id = 0;
    public string cus_name = string.Empty;
    public int cus_age = 0;

    // Method within Customer Class that changes customer ID to new integer
    public void ChangeID(int new_id)
    {
        cus_id = new_id;
    }

    // Method within Customer Class that prints customer info
    public void PrintCusInfo()
    {
        Console.WriteLine($"Customer: {cus_id}, Name: {cus_name}, Age: {cus_age}");
    }
    
    // Customer Constructor that assigns ID, Name, and Age
    public Customer(int input_cus_id, string input_cus_name, int input_cus_age)
    {
        cus_id = input_cus_id;
        cus_name = input_cus_name;
        cus_age = input_cus_age;
        this.cus_age = cus_age;
        this.cus_age = cus_age;
    }
    // Customer method that compares ages of current object's age with others
    public void CompareAge(Customer objCustomer)
    {
        if (this.cus_age > objCustomer.cus_age)
        {
            Console.WriteLine($"{this.cus_name} is older");
        }
        else
        {
            Console.WriteLine($"{objCustomer.cus_name} is older");
        }
    }


}

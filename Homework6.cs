namespace Homework6;

class Program
{
    // Connor Lincycomb Homework 6 CIDM2315 February 27, 2024
    static void Main(string[] args)
    {
        Professor prof1 = new Professor();
        prof1.profName = "Alice";
        prof1.classTeach = "Java";
        prof1.SetSalary(9000);
        Console.WriteLine($"Professor {prof1.profName} teaches {prof1.classTeach}, and the salary is: {prof1.GetSalary()}");

        Professor prof2 = new Professor();
        prof2.profName = "Bob";
        prof2.classTeach = "Math";
        prof2.SetSalary(8000);
        Console.WriteLine($"Professor {prof2.profName} teaches {prof2.classTeach}, and the salary is: {prof2.GetSalary()}");

        Student stu1 = new Student();
        stu1.studentName = "Lisa";
        stu1.classEnroll = "Java";
        stu1.SetGrade(90);
        Console.WriteLine($"Student {stu1.studentName} enrolls {stu1.classEnroll}, and the grade is {stu1.GetGrade()}");
    
        Student stu2 = new Student();
        stu2.studentName = "Tom";
        stu2.classEnroll = "Math";
        stu2.SetGrade(80);
        Console.WriteLine($"Student {stu2.studentName} enrolls {stu2.classEnroll}, and the grade is {stu2.GetGrade()}");

        double salary_difference = prof1.GetSalary() - prof2.GetSalary();
        Console.WriteLine($"The salary difference between Alice and Bob is: {salary_difference}");
        double total_grade = stu1.GetGrade() + stu2.GetGrade();
        Console.WriteLine($"The total grade of Lisa and Tom is: {total_grade}");
    }
}

// First Object Class
class Professor
{
    public string profName;
    public string classTeach;
    private double salary = 0;

    public void SetSalary(double salary_amount)
    {
        salary = salary_amount;
    }

    public double GetSalary()
    {
        return salary;
    }
}


// Second Object Class

class Student
{
    public string studentName;
    public string classEnroll;
    private double studentGrade = 0;

    public void SetGrade(double newGrade)
    {
        studentGrade = newGrade;
    }

    public double GetGrade()
    {
        return studentGrade;
    }
}
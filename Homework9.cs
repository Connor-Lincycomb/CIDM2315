namespace Homework9;

class Program
{
    static void Main(string[] args)
    {
        // 2: In Main, create 4 students
        Student stu1 = new Student(input_studentID: 111, input_studentName: "Alice");
        Student stu2 = new Student(input_studentID: 222, input_studentName: "Bob");
        Student stu3 = new Student(input_studentID: 333, input_studentName: "Cathy");
        Student stu4 = new Student(input_studentID: 444, input_studentName: "David");
        Console.WriteLine("Connor Lincycomb CIDM2315 Homework 9");
        Console.WriteLine("-----Output for Question 1-----");
        // calls the PrintInfo method for each stu in the studentList List.
        foreach(Student stu in Student.studentList)
        {
            stu.PrintInfo();
        }
        // 3: Create a dictionary named gradebook and add the pairs
        Dictionary<string, double> gradebook = new Dictionary<string, double>();
        gradebook.Add("Alice", 4.0);
        gradebook.Add("Bob", 3.6);
        gradebook.Add("Cathy", 2.5);
        gradebook.Add("David", 1.8);

        // 4: Check if Tom has a record (+ insert via if statement) 
        if(gradebook.ContainsKey("Tom") == false)
        {
            gradebook.Add("Tom", 3.3);
        }

        /* 5: Calculate the average GPA of all students. Print it.
        Since I set the names as the keys in the gradebook dictionary
        the GPAs are stored as values, which can be returned with the Dictionary.Values property
        as shown in the geeksforgeeks link in the powerpoint.
        */
        double avgGPA = gradebook.Values.Average();
        Console.WriteLine("-----Output for Question 5-----");
        Console.WriteLine($"The average GPA is: {avgGPA}");

        /* 6: I removed Tom here since since avgGPA remains the same, 
        but if Tom is left in the gradebook then the foreach loop will attempt
        to display his information which doesn't exist as he is not a student object,
        just a pair in the gradebook dictionary.
        */
        gradebook.Remove("Tom");
        Console.WriteLine("-----Output for Question 6-----");
        foreach(var thing in gradebook)
        {
            if(thing.Value > avgGPA)
            {
                foreach(Student stu in Student.studentList)
                {
                    if(thing.Key == stu.studentName)
                    {
                        stu.PrintInfo();
                    }
                }
            }
        
        }
        
}
}

// 1: Create a student class
class Student
{
    // creates list to store objects of class Student
    public static List<Student> studentList = new List<Student>();
    // studentID and studentName variables
    private int studentID = 0;
    public string studentName = string.Empty;
    

    // public PrintInfo method to print studentID and name
    public void PrintInfo()
    {
        Console.WriteLine($"StudentID: {studentID}, Student Name: {studentName}");
        
    }

    // public student constructor for creating new student object
    public Student(int input_studentID, string input_studentName)
    {
        studentID = input_studentID;
        studentName = input_studentName;
        studentList.Add(this);
    }

}

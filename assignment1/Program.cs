class Program
{
    static void Main(string[] args)
    {
        // Default constructor
        Student s1 = new();
        s1.DisplayInfo();
        Console.WriteLine();

        // Parametrized constructor
        Student s2 = new(2436670, "Shayan", 78.0);
        s2.DisplayInfo();
        Console.WriteLine();

        // Updating `s1` grade with a valid input
        s1.UpdateGrade(100);

        // Updating `s2` grade with an invalid input
        s2.UpdateGrade(150);

        Console.WriteLine();
        s1.DisplayInfo();
        Console.WriteLine();
        s2.DisplayInfo();
    }
}

class Student
{
    private int studentID;
    private string name;
    private double grade;

    public Student()
    {
        studentID = 0;
        name = "Unknown";
        grade = 0.0;
    }

    public Student(int studentID, string name, double grade)
    {
        this.studentID = studentID;
        this.name = name;
        this.grade = grade;
    }

    public Student(Student student)
    {
        studentID = student.studentID;
        name = student.name;
        grade = student.grade;
    }

    public void UpdateGrade(double grade)
    {
        if (grade <= 100 && grade >= 0)
        {
            this.grade = grade;
            Console.WriteLine($"Grade has been updated to {grade}");
        }
        else Console.WriteLine("Grade is invalid!");
    }

    public string GetStatus()
    {
        if (this.grade > 50) return "Passed";
        else return "Failed";
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Student name: {this.name}");
        Console.WriteLine($"Student ID: {this.studentID}");
        Console.WriteLine($"Grade: {this.grade}");
        Console.WriteLine($"This student has {this.GetStatus()}");
    }
}
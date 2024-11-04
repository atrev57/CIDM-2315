namespace homework9;

class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student(111, "Alice");
        Student student2 = new Student(222, "Bob");
        Student student3 = new Student(333, "Cathy");
        Student student4 = new Student(444, "David");

        Dictionary<string, double> gradebook = new Dictionary<string,double>{
            {"Alice",4.0},
            {"Bob", 3.6},
            {"Cathy", 2.5},
            {"David", 1.8},
        };

        if(!gradebook.ContainsKey("Tom")){
            gradebook.Add("Tom", 3.3);
        }

        double averageGPA = gradebook.Values.Average();
        Console.WriteLine($"The average GPA is: {averageGPA}");

        foreach(var student in Student.studentList){
            string name = student.GetName();
            if(gradebook.ContainsKey(name)&&gradebook[name]>averageGPA){
                student.PrintInfo();
            }
        }

    }
}
class Student{
    private int studentID;
    private string studentName;
    public static List<Student> studentList=new List<Student>();

    public void PrintInfo(){
        Console.WriteLine($"Student ID: {studentID}, Name: {studentName}");
    }

    public Student(int id, string name){
        studentID = id;
        studentName = name;
        studentList.Add(this);
    }

    public string GetName(){
        return studentName;
    }
}

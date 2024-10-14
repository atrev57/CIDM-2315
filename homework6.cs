namespace homework6;

class Program
{
    static void Main(string[] args)
    {
        //Q1
        Professor professor1 = new Professor();
        professor1.profName="Alice";
        professor1.classTeach="Java";
        professor1.SetSalary(9000);

        Professor professor2 = new Professor();
        professor2.profName="Bob";
        professor2.classTeach="Math";
        professor2.SetSalary(8000);

        Student student1 = new Student();
        student1.studentName="Lisa";
        student1.classEnroll="Java";
        student1.setGrade(90);

        Student student2 = new Student();
        student2.studentName="Tom";
        student2.classEnroll="Math";
        student2.setGrade(80);
        //Q2
        Console.WriteLine($"{professor1.profName} teaches {professor1.classTeach} and the salary is: {professor1.GetSalary()}");
        Console.WriteLine($"{professor2.profName} teaches {professor2.classTeach} and the salary is: {professor2.GetSalary()}");

        Console.WriteLine($"Student {student1.studentName} enrolls {student1.classEnroll} and the grade is; {student1.getGrade()}");
        Console.WriteLine($"Student {student2.studentName} enrolls {student2.classEnroll} and the grade is {student2.getGrade()}");

        double salaryDifference = professor1.GetSalary()- professor2.GetSalary();
        Console.WriteLine($"Salary Difference between Alice and Bob is: {salaryDifference}");

        double totalGrade=student1.getGrade() + student2.getGrade();
        Console.WriteLine($"The total garde of Lisa and Tom is: {totalGrade}");
    }
}
//Q1
class Professor{
    public string profName{get; set;}
    public string classTeach{get;set;}
    private double salary;

    public void SetSalary(double salary_amount){
        salary = salary_amount;
    }

    public double GetSalary(){
        return salary;
    }
}

class Student{
    public string studentName{get;set;}
    public string classEnroll{get;set;}
    private double studentGrade;

    public void setGrade(double newGrade){
        studentGrade = newGrade;
    }

    public double getGrade(){
        return studentGrade;
    }
}
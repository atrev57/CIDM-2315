namespace homework2;

class Program
{
    static void Main(string[] args)
    {
        //Question 1 start
        Console.WriteLine("Please input letter grade:");
        /*Google Gemini 2024, September 9th. "Help me write a 
        char string for this prompt"*/
        char grade = Char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();
        int gpa=0;
        switch(grade){
            case 'A':
            gpa = 4;
            break;
            case 'B':
            gpa = 3;
            break;
            case 'C':
            gpa = 2;
            break;
            case 'D':
            gpa = 1;
            break;
            case 'F':
            gpa = 0;
            break;
        //for invalid input
            default:
            Console.WriteLine("Wrong letter grade!");
            break;
        }
        if (gpa != 0){
            Console.WriteLine("GPA Point:"+gpa);
        }
        //End of question 1 
        //Question 2 start
        //Google Gemini 2024, September 9th "Help me fix this code(inputed my previous incorrect code)
        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Enter the third number: ");
        int num3 = int.Parse(Console.ReadLine());  


        int smallest=num1;
        if (num2 < smallest)
            {
                smallest = num2;
            }

            if (num3 < smallest)
            {
                smallest = num3;
            }
            Console.WriteLine("The smallest value is:"+smallest);
            //End of question 2
    }
}

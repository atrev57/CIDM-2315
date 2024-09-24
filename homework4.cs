namespace homework4;

class Program
{
    static void Main(string[] args)
    {
        //Call Q1 method
        Console.WriteLine("Input first number");
        int num1 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Input second number");
        int num2 = Convert.ToInt16(Console.ReadLine());
        int largest = FindLarger(num1, num2);
        Console.WriteLine("The largest number is:" + largest);

        //Call Q2 method
        Console.WriteLine("N is");
        string input_num = Console.ReadLine();
        int N = Convert.ToInt16(input_num);
        Console.WriteLine("Shape is: ");
        string input_shape = Console.ReadLine();
        Question2(N, input_shape);
    }
    //Q1 method
    static int FindLarger(int num1, int num2){
        if(num1 > num2){
            return num1;
        }
        else{
            return num2;
        }
    }
    //Q2 Method
    static void Question2(int N, string shape){
        if(shape == "left"){
            for(int row = 0; row<5; row++){
                for(int col=0; col<=5; col++){
                    if(row>=col)
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
        else if (shape == "right") {
        int n = 5;
        for (int row = 0; row < n; row++) {
        for (int col = 0; col < n; col++) {
            if (col < n - row - 1)
                Console.Write(" ");
            else
                Console.Write("*");
        }
        Console.WriteLine("");
         }
    }
    }
}

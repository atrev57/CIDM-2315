namespace homework3;

class Program
{
    static void Main(string[] args)
    {
        //Question 1 start
        Console.WriteLine("Please input an integer");
        int N = int.Parse(Console.ReadLine());
        bool isPrime=true;
        for(int i = 2; i < N; i++){
            if(N%i == 0){
                isPrime=false;
            }
        }
        if(isPrime){
            Console.WriteLine($"{N} is prime");
        }
        else{
            Console.WriteLine($"{N} is not prime");
        }
        //Question 1 end

        //Question 2 start
        Console.WriteLine("Assign an int value to N");
        int Num= Convert.ToInt16(Console.ReadLine());
        for(int row = 0; row<5; row++){
            for(int col = 0; col<5; col++){
                Console.Write('#');
            }
            Console.WriteLine("");
        }
        //question 2 end

        //Question 3 start
        Console.WriteLine("Assign an int value to N");
        int Num2= Convert.ToInt16(Console.ReadLine());
        for(int row=0; row<5; row++){
            for(int col=0; col<5; col++){
                if(row>=col)
                Console.Write('*');
            }
            Console.WriteLine("");
        }
    }
}

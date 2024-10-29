namespace homework8;

class Program
{
    static void Main(string[] args)
    {
        Customer cus1 = new Customer(customerName:"Alice", customerAge:33, customerCity:"Amarillo", customerCredit:198.5);
        Customer cus2 = new Customer(customerName:"Bob", customerAge:23, customerCity:"Amarillo", customerCredit:226);
        Customer cus3 = new Customer(customerName:"Cathy", customerAge:45, customerCity:"Amarillo", customerCredit:89.0);
        Customer cus4 = new Customer(customerName:"David", customerAge:58, customerCity:"Amarillo", customerCredit:198.5);
        Customer cus5 = new Customer(customerName:"Jack", customerAge:28, customerCity:"Canyon", customerCredit:561.6);
        Customer cus6 = new Customer(customerName:"Tom", customerAge:36, customerCity:"Canyon", customerCredit:98.4);
        Customer cus7 = new Customer(customerName:"Tony", customerAge:24, customerCity:"Canyon", customerCredit:18.5);
        Customer cus8 = new Customer(customerName:"Sam", customerAge:35, customerCity:"Canyon", customerCredit:228.3);

        Customer[] customer_list={cus1,cus2,cus3,cus4,cus5,cus6,cus7,cus8};
        //Q1 Method
        TotalCredits(customer_list);

        //Q2 Method
        AmarilloAverageAge(customer_list);

        //Q3 Method
        CanyonAge(customer_list);
    }
    //Question 1
    public static void TotalCredits(Customer[] customer_list){
        double totalCredits=0;
        foreach(Customer customer in customer_list){
            totalCredits += customer.CustomerCredit;
        }
        Console.WriteLine("Total Credits: " + totalCredits);
    }

    //Question 2
    public static void AmarilloAverageAge(Customer[] customer_list){
        double totalAge=0;
        int count=0;
        foreach(Customer customer in customer_list){
            if(customer.CustomerCity=="Amarillo"){
                totalAge+=customer.CustomerAge;
                count++;
            }
        }
        double averageAge=(count>0)?totalAge/count:0;
        Console.WriteLine("Average age of customers in Amarillo: "+ averageAge);
    }
    //Question 3
    public static void CanyonAge(Customer[] customer_list){
        Console.WriteLine("Customers that live in Canyon and older than 30:");
        foreach(Customer customer in customer_list){
            if(customer.CustomerCity=="Canyon"&&customer.CustomerAge > 30){
                Console.WriteLine(customer.CustomerName);
            }
        }
    }
}
//Question 0
class Customer{
    public string CustomerName{get;set;}
    public int CustomerAge{get;set;}
    public string CustomerCity{get;set;}
    public double CustomerCredit{get;set;}

    public Customer(string customerName, int customerAge, string customerCity, double customerCredit){
        CustomerName=customerName;
        CustomerAge=customerAge;
        CustomerCity=customerCity;
        CustomerCredit=customerCredit;
    }
}

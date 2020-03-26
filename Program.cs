using System;

namespace domashka2403
{
    class Program
    {
        static void Main(string[] args)
        {
        { //ex #2
         int a = 0 , b = 0;
         if (a != b){
             a = a > b ? a : b;
             b = a > b ? a : b;
         } else {
             a = 0;
             b = 0;
         }
         Console.WriteLine($"{a},{b} ");
        }
        { //ex #3
        Console.Write("Enter number; ");
        int operand1 = int.Parse(Console.ReadLine());
        Console.Write("Enter another number: ");
        int operand2 = int.Parse(Console.ReadLine());
        Console.Write("Enter operation: ");
        string sign = Console.ReadLine();
        switch (sign) {
            case "+":
             Console.WriteLine(operand1 + operand2);
            break;
            case "-":
             Console.WriteLine(operand1 - operand2);
            break;
            case "*":
             Console.WriteLine(operand1 * operand2);
            break;
            case "/":             
            if ( operand2 == 0){
                Console.WriteLine("cannot be divided by zero!");              
            } else {
            Console.WriteLine(operand1 / operand2);
            }
            break;
        }
        Console.ReadKey();
        }
        {
            Console.Write("Enter number from 0 to 100:");
            int number = int.Parse(Console.ReadLine());
            if( number <= 14 && number >= 0){
                Console.WriteLine("This number is from the first gap");
            } if(number <= 35 && number >= 15) { 
                Console.WriteLine("This number is from the second gap");
            } if(number <= 50 && number > 35) { 
                Console.WriteLine("This number is from the third gap");
            } if(number <= 100 && number >= 50) { 
                Console.WriteLine("This number is from the fourth gap");
            } if(number > 100) { 
                Console.WriteLine("Eror");                
            } if(number <= -1) { 
                Console.WriteLine("Eror");
            }

        }
        
        }
    }
}
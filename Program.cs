// Write a program that takes a number (1-7) as input and prints the corresponding day of the week. If the input is not in the range of 1-7, print "Invalid input".

using System;
class Practiceone{
    static void Main(){

        Console.Write("Enter a number (1-7): ");

        int day = Convert.ToInt32(Console.ReadLine());

        switch(day){

            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Invalid input! Please enter a number between 1 and 7.");
                break;
        }
    }
}

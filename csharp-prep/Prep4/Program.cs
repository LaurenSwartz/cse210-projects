using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers  = new List<int>();

        int user = -1;
        while (user!=0)
        {
            
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            Console.Write ("Enter number:");
            string usernumber = Console.ReadLine();
            user = int.Parse(usernumber);

            //Only add the number to the list if it is not 0
            if (user !=0)
            {
                numbers.Add(user);
            }
            
        }

        //Part 1 : Compute the sum
        int sum = 0;

        foreach (int number in numbers)
        {
            sum+= number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum)/ numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max =numbers[0];

        foreach (int number in numbers)
        {
          if (number > max)  
          {
            max= number;

          }

        }

        Console.WriteLine($"The max is: {max}");

    }
}
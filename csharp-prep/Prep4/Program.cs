using System;

class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();
        
        int newNumber = -1;
        while (newNumber != 0)
        {
            Console.Write("Enter a number (0 to finish): ");
            String userNumber = Console.ReadLine();
            newNumber = int.Parse(userNumber);

            //Validate is the number is not 0 so it can be added to the list.
            if (newNumber != 0) 
            {
                numbers.Add(newNumber);
            }

            //Console.WriteLine(newNumber);
        }

        float sum = 0;
        float max = -1;
        for (int i = 0; i < numbers.Count; i++)
        {   
            //Calculate the total sum of the numbers in the list.
            sum += numbers[i];

            //Get the greatest number in the list.
            if (numbers[i] > max) 
            {
                max = numbers[i];
            }
        }


        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {sum / numbers.Count}");
        Console.WriteLine($"The largest number is: {max}");
    }
}
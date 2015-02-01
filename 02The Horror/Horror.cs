using System;

class Horror
{
    static void Main()
    {
        string input = Console.ReadLine();
        
        int position = 0;
        int counter = 0;
        ulong result = 0;


        foreach (char symbol in input)
        {
            int digit = symbol - '0';
            position++;

            if (position % 2 != 0)
            {
                result = result + (ulong)digit;
                counter++;

            }

        }
        Console.WriteLine(counter +" "+ result);



    }
}


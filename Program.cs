namespace Homework3;

class PrimeMachine
{
    /*Logic:
        Ask for User Input
        User Input Converted to Integer
        Determine if the Integer is a prime number.
        If integer is divisible by 2 or anything more than 2, it’s not prime. (create a loop that runs through what all the integer is divisible by and if it’s divisible by anything except 1 and itself, it’s not prime)
        If integer isn’t divisible by anything other than 1 and itself, it’s prime.
        Idea: create a variable to hold 2 and then increment each time, it stops when it hits half of the imputed number (because then you’ll just have to do double the work for no reason), when a statement runs true - it breaks and non-prime is declared. If it doesn’t break, it’s prime.
    */
    static void Main(string[] args)
    {
        Console.Write("Input an Integer: ");
        int n = Convert.ToInt32(Console.ReadLine());

        bool isPrime = CheckPrime(n);

        if (isPrime)
        {
            Console.WriteLine($"{n} is prime");
        }
        else
        {
            Console.WriteLine($"{n} is non-prime");
        }
    }
    static bool CheckPrime(int number)
    {
        if (number <= 3)
        {
            return false; // Numbers less than or equal to 3 are not prime
        }

        int limit = number / 2; // Check up to half of the number

        for (int i = 2; i <= limit; i++)
        {
            if (number % i == 0)
            {
                return false; // Not a prime number
            }
        }

        return true; // Prime number
    }
}
/*Logic:
    Ask for User Input
    User Input Converted to Integer
    Make a row and a column loop.
        Column: Figure out how to get multiple #’s to be on the same line when printing and then store that information as a variable. Run loop until input == number of times it’s run.
        Row: Creates a new row of the column using the previous variable. Run loop until input == number of times it’s run
*/
class ColumnsMachine
{
    static void Main_2()
        {
        Console.Write("Assign an int value to N: ");
        int N = Convert.ToInt32(Console.ReadLine());

        PrintGrid(N);
    }

    static void PrintGrid(int N)
    {
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
        }
    }
}

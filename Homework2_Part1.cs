class Homework2_Part1
{
static void Main()
{
Console.WriteLine("Please Input a Letter Grade: \n");
string letter_grade = Console.ReadLine();
switch(letter_grade)
{
    case "A":
        //print the the text for A
        Console.WriteLine(@"GPA point: 4");
        break;
    case "B":
        //print the the text for B
        Console.WriteLine(@"GPA point: 3");
        break;
    case "C":
        //print the the text for C
        Console.WriteLine(@"GPA point: 2");
        break;
    case "D":
        //print the the text for D
        Console.WriteLine(@"GPA point: 1");
        break;
    case "F":
        //print the the text for F
        Console.WriteLine(@"GPA point: 0");
        break;
    default:
        //print Wrong Letter Grade!
        Console.WriteLine(@"Wrong Letter Grade!");
        break;
    }
}
}

internal class Homework2_Part2
{
    private static void Main()
{

//number one
Console.Write("Please input the first num: ");
int one = Convert.ToInt16(Console.ReadLine());

//number two
Console.Write("Please input the second num: ");
int two= Convert.ToInt16(Console.ReadLine());

//number three
Console.Write("Please input the third num: ");
int three = Convert.ToInt16(Console.ReadLine());

//comparison using if statements
if (one < two && one < three)
{
    Console.Write($"The smallest value is {one}");
}
else if (two < one && two < three)
{
    Console.Write($"The smallest value is {two}");
}
else
{
    Console.Write($"The smallest value is {three}");
}

}
}
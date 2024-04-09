
// call the method
using System.Diagnostics;

/*PrintName();
Add(3,5);
Add(4,6);
Add('A', 'a');  //face conversia char-ului in Ascii unicode 

Console.WriteLine("Please input the first number");
var firstNumber = ReadFromConsole();


Console.WriteLine("Please input the second number");
var secondNumber = ReadFromConsole();

Add(firstNumber, secondNumber);

*//*var result = ReadFromConsole();
Console.WriteLine(result); *//* 
static void PrintName()
{
    Console.WriteLine("My name is Valentin");
}
static int ReadFromConsole()
{
    var line = Console.ReadLine();
    var success = int.TryParse(line, out int result);
    if (success)
    {
        return result;
    }
    else
    {
        Console.WriteLine("Sorry, the input cannot be transformed to a number, ");
    }
    return result;
}
static void Add(int a, int b)
{
  
    Console.WriteLine(a + b);
}
*/
/*PrintNumbers(4,7);
PrintNumbers(start:5, end: 8);
static void PrintNumbers(int start = 0, int end = 100)
{
    for (int i = start; i <= end; i++)
    {
        Console.Write("{0} ", i);
    }
}*/


/*Console.WriteLine(CalcSum(2, 5));
static long CalcSum(params int[] elements)
{
    long sum = 0;
    foreach (int element in elements)
        sum += element;
    return sum;
}
static void Main()
{
    Console.WriteLine(CalcSum(2, 5));
    Console.WriteLine(CalcSum(4, 0, -2, 12));
    Console.WriteLine(CalcSum());
}*/



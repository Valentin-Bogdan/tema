

/*PrintSign(7);
PrintSign(-8);
PrintSign(0);

static void PrintSign(int number)
{
    if (number > 0)
        Console.WriteLine("Positive");
    else if (number < 0)
        Console.WriteLine("Negative");
    else
        Console.WriteLine("Zero");
}*/
/*ReadFromConsole();
static void ReadFromConsole()
{
    var numarulmeu = int.Parse(Console.ReadLine());
    if (numarulmeu > 0)
        Console.WriteLine("Positive");
    else if (numarulmeu < 0)
        Console.WriteLine("Negative");
    else
        Console.WriteLine("Zero");



}*/
using System;
class MonthsExample
{
    
    static void SayMonth(int month)
    {
        string[] monthNames = new string[] {
"January", "February", "March", "April",
"May", "June", "July", "August", "September",
"October", "November", "December"};
        Console.Write(monthNames[month - 1]);
    }
    static void Main()
    {
        SayMonth(1);
        SayPeriod(1, 6);
    }
    static void SayPeriod(int startMonth, int endMonth)
    {
        int period = endMonth - startMonth;
        if (period < 0)
        {
            period = period + 12;
            // From December to January the period is 1 month, not -11!
        }
        Console.Write("There are {0} + months from ", period);
        SayMonth(startMonth); Console.Write(" to ");
        SayMonth(endMonth);
    }
}
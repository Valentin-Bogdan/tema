

using System.Diagnostics;

static void Handout2()
{
    PrintMinFloat();
    PrintMinInt();

    static float GetMin(float a, float b)
    {
        if (a < b)
        {
            return a;
        }
        return b;
    }

    static int GetMin(int a, int b)
    {
        if (a < b)
        {
            return a;
        }
        return b;
    }

    static void PrintMinFloat()
    {
        float a = float.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());
        float min = GetMin(a, b);
        Console.WriteLine($"Min between {a} and {b} is {min}");
        //Console.WriteLine($"Min between {a} and {b} is {GetMin(a, b)}");
    }
    static void PrintMinInt()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int min = GetMin(a, b);
        Console.WriteLine($"Min between {a} and {b} is {min}");
        //Console.WriteLine($"Min between {a} and {b} is {GetMin(a, b)}");
    }
}
static void Main(string[] args)
{
    Handout2();
}
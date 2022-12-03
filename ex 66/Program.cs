Console.Clear();
Console.Write("Enter firsrt number:");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number:");
int SecondNumber = Convert.ToInt32(Console.ReadLine());
int NumbersSum(int a, int b)
{
    int result = 0;
    if (a < b)
    {
        for (int i = a; i <= b; i++)
        {
            result += i;
        }
        return result;
    }
    else
    {
        for (int i = b; i <= a; i++)
        {
            result += i;
        }
        return result;
    }

}

Console.Write($"Sum = {NumbersSum(FirstNumber, SecondNumber)}");
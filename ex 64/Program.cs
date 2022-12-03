Console.Clear();
Console.Write("Enter your number:");
int number = Convert.ToInt32(Console.ReadLine());

string NumberRec(int a, int b)
{
    if (b <= a) return $"{a} " + NumberRec(a - 1, b);
    else return String.Empty;
}

Console.Write(NumberRec(number, 1));
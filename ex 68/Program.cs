Console.Clear();
Console.Write("Enter firsrt number:");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number:");
int SecondNumber = Convert.ToInt32(Console.ReadLine());

int A(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return A(n - 1, 1);
    else
        return A(n - 1, A(n, m - 1));
}

Console.WriteLine($"Result = {A(FirstNumber, SecondNumber)}");

while (1 > 0)
{
    System.Console.Write("The first number is: ");
    double a = Convert.ToDouble(Console.ReadLine());

    System.Console.Write("The operation is: ");
    char c = Convert.ToChar(Console.ReadLine());

    System.Console.Write("The second number is: ");
    double b = Convert.ToDouble(Console.ReadLine());

    Calculator d = new Calculator(a, b);
    if (c == '+')
    {
        System.Console.WriteLine(d.Sum());
    }
    else if (c == '-')
    {
        System.Console.WriteLine(d.Subtract());
    }
    else if (c == '*')
    {
        System.Console.WriteLine(d.Multiplication());
    }
    else if (c == '/')
    {
        System.Console.WriteLine(d.Division());
    }

}
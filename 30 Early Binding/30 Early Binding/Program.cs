class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
}

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator(); // Known at compile time
        int result = calc.Add(10, 20);      // Early binding
        Console.WriteLine("Sum: " + result);
    }
}

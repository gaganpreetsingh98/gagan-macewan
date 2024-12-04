
using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating an instance of the generic class with T as int
        Calculator<int> calculator = new Calculator<int>();

        // Example usage
        int result = calculator.AddValues(35, 10);
        Console.WriteLine("Result: " + result);
    }
}

class Calculator<T>
{
    // Generic method to add two values of type T
    public T AddValues(T value1, T value2)
    {
        dynamic val1 = value1;
        dynamic val2 = value2;
        return val1 + val2;
    }
}
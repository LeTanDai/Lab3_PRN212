using System;

public class Calculate<T>
{
    public T Add(T x, T y)
    {
        dynamic a = x;
        dynamic b = y;
        return a + b;
    }

    public T Subtract(T x, T y)
    {
        dynamic a = x;
        dynamic b = y;
        return a - b;
    }

    public T Multiply(T x, T y)
    {
        dynamic a = x;
        dynamic b = y;
        return a * b;
    }

    public T Divide(T x, T y)
    {
        dynamic a = x;
        dynamic b = y;
        if (b == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero");
        }
        return a / b;
    }
}

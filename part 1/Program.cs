using System;
class PrimitiveTypeApp
{
    public static void Main()
    {
        bool b;
        int i = int.MaxValue;//모든 자료형이c#에서 객체로 처리됨
        uint j = uint.MaxValue;
        double d = double.MaxValue;
        b = (i != 0);
        Console.WriteLine("boolean b = " + b);
        Console.WriteLine("max value of signed integer = " + i);
        Console.WriteLine("max value of unsigned integer = " + j);
        Console.WriteLine("max value of double = " + d);
    }
}
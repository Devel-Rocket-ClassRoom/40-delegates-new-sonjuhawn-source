using System;

// README.md를 읽고 아래에 코드를 작성하세요.
//Console.WriteLine("'''");
//{
//    Calculator calc = new Calculator();
//    Transformer trans = calc.multiplier;
//    Console.WriteLine(trans(5));

//    delegate int Transformer(int t);
//}
//Console.WriteLine("'''\n");

//Console.WriteLine("'''");
//{
//    CarDriver go = GoForward;
//    go += GoLeft;
//    go += GoRight;

//    go();

//    Console.WriteLine();

//    go -= GoLeft;
//    go();

//    delegate void CarDriver();

//    static void GoForward() => Console.WriteLine("직진");
//    static void GoLeft() => Console.WriteLine("좌회전");
//    static void GoRight() => Console.WriteLine("우회전");
//}
//Console.WriteLine("'''\n");

//Console.WriteLine("'''");
//{
//    int[] numbers = { 1, 2, 3, 4, 5 };

//    Transform(numbers, Square);
//    PrintArray(numbers);

//    numbers = new int[] { 1, 2, 3, 4, 5 };

//    Transform(numbers, Cube);
//    PrintArray(numbers);

//    delegate int Transformer(int x);

//    static int Square(int x) => x * x;
//    static int Cube(int x) => x * x * x;

//    static void Transform(int[] values, Transformer t)
//    {
//        for (int i = 0; i < values.Length; i++)
//        {
//            values[i] = t(values[i]);
//        }
//    }

//    static void PrintArray(int[] arr)
//    {
//        Console.WriteLine(string.Join(", ", arr));
//    }
//}
//Console.WriteLine("'''\n");

class Calculator
{
    public int multiplier = 3;

    public int Multiply(int x) => x * multiplier;
}
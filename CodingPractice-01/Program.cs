using System;
using System.Text;

// README.md를 읽고 아래에 코드를 작성하세요.
//Console.WriteLine("'''");
//{
//    SayDelegate sayhi = Hello;

//    sayhi();
//    sayhi.Invoke();

//    delegate void SayDelegate();

//    static void Hello() => Console.WriteLine("Hello Delegate");
//}
//Console.WriteLine("'''\n");

//Console.WriteLine("'''");
//{
//    SayDelegate hi = Hi();
//    SayDelegate hi1 = new SayDelegate(hi);

//    hi();
//    hi1();

//    delegate void SayDelegate();

//    static void Hi()
//    {
//        Console.WriteLine("안녕하세요");
//    }
//}
//Console.WriteLine("'''\n");

//Console.WriteLine("'''");
//{
//    GetAreaDelegate area = GetArea;

//    area(10);
//    area.Invoke(10);

//    delegate int GetAreaDelegate();

//    static double GetArea(int r) => 3.14 * r * r;
//}
//Console.WriteLine("'''\n");

//Console.WriteLine("'''");
//{
//    MathOperation pow = Math.Pow();
//    double result = pow(2, 10)
//    Console.WriteLine(result);

//    delegate double MathOperation();
//}
//Console.WriteLine("'''\n");

//Console.WriteLine("'''");
//{
//    Transformer trans = Calculator.Square;

//    int result = trans(5);
//    Console.WriteLine(result);

//    delegate int Transformer(int x);
//}
//Console.WriteLine("'''\n");

//Console.WriteLine("'''");
//{
//    ProgressReporter report = WriteToConsole;
//    report += WriteToFile;

//    for(int i = 0; i < 100; i += 25)
//    {
//        report(i);
//        Console.WriteLine();
//    }

//    delegate void ProgressReporter(int percent);

//    static void WriteToConsole(int percent)
//    {
//        Console.WriteLine($"진행률 {percent}%");
//    }
//    static void WriteToFile(int percent)
//    {
//        Console.WriteLine($"[파일 기록] {percent}%");
//    }
//}
//Console.WriteLine("'''\n");

//Console.WriteLine("'''");
//{
//    delegate void Runner();

//    RunCall(Go);
//    RunCall(Back);
//    static void Go()
//    {
//        Console.WriteLine("직진");
//    }
//    static void Back()
//    {
//        Console.WriteLine("후진");
//    }
//    static void RunCall(Runner runner) 
//    {
//        Console.WriteLine("=== 실행 시작 ===");
//        runner();
//        Console.WriteLine("=== 실행 종료 ===");
//    }
//}
//Console.WriteLine("'''\n");

//Console.WriteLine("'''");
//{
//    Action greet = () => Console.WriteLine("안녕하세요!");
//    greet();

//    Action<string> print = (msg) => Console.WriteLine(msg);
//    print("Hello, Action!");

//    Action<string, int> printRepeat = (msg, count) =>
//    {
//        for (int i = 0; i < count; i++)
//        {
//            Console.WriteLine(msg);
//        }
//    };
//    printRepeat("반복", 3);
//}
//Console.WriteLine("'''\n");

//Console.WriteLine("'''");
//{
//    Func<int> getNumber = () => 42;
//    Console.WriteLine(getNumber());

//    Func<int, int> square = (x) => x * x;
//    Console.WriteLine(square(5));

//    Func<int, int, int> add = (a, b) => a + b;
//    Console.WriteLine(add(3, 7));

//    Func<int, int, string> addToString = (a, b) => (a + b).ToString();
//    Console.WriteLine(addToString(3, 5));
//}
//Console.WriteLine("'''\n");

//Console.WriteLine("'''");
//{
//    Predicate<int> isEven = (x) => x % 2 == 0;
//    Predicate<int> isPositive = (x) => x > 0;

//    Console.WriteLine(isEven(4));      
//    Console.WriteLine(isEven(7));      
//    Console.WriteLine(isPositive(5));  
//    Console.WriteLine(isPositive(-3)); 
//}
//Console.WriteLine("'''\n");

//Console.WriteLine("'''");
//{
//    SayDelegate say = delegate ()
//    {
//        Console.WriteLine("반갑습니다.");
//    };

//    say();

//    delegate void SayDelegate();
//}
//Console.WriteLine("'''\n");

class Calculator
{
    public static int Square(int x) => x * x;
}
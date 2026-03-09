using System;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("'''");
{
    Action driver = GoForward;
    driver += GoLeft;
    driver += GoRight;
    driver();

    
}
Console.WriteLine("'''\n");

Console.WriteLine("'''");
{
    Action driver = GoForward;
    driver += GoLeft;

    driver += delegate ()
    {
        Console.WriteLine("우회전");
    };
}
Console.WriteLine("'''\n");

static void GoForward() => Console.WriteLine("직진");
static void GoLeft() => Console.WriteLine("좌회전");
static void GoRight() => Console.WriteLine("우회전");
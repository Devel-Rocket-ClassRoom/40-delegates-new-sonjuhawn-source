using System;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("'''");
{
    SayDelegate sayhi = Hello;

    sayhi();
    
    delegate void SayDelegate();

    static void Hello() => Console.WriteLine("Hello Delegate");
}
Console.WriteLine("'''\n");

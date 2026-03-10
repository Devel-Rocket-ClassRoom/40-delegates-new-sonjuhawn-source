using System;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("코드를 작성하세요.");

Action<string> print = ();

void PrintOriginal(string str)
{
    Console.WriteLine($"원본: {str}");
}
void PrintUpper(string str)
{
    Console.WriteLine($"대문자: { str.ToUpper()}");
}
void PrintLower(string str)
{
    Console.WriteLine($"소문자: {str.ToLower()}");
}
void PrintLength(string str)
{
    Console.WriteLine($"길이: {str.Length}");
}


Action<string> print = (msg) => 


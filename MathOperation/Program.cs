using System;

// README.md를 읽고 코드를 작성하세요.
Console.WriteLine("코드를 작성하세요.");

MathOp op = Add;

Console.WriteLine("[덧셈]");
Console.WriteLine($"20 + 4 = {op(20,4)}");
op -= Add;

Console.WriteLine("[뺄셈]");
op = Subtract;
Console.WriteLine($"20 - 4 = {op(20, 4)}");
op -= Subtract;

Console.WriteLine("[곱셈]");
op = Multiply;
Console.WriteLine($"20 * 4 = {op(20, 4)}");
op -= Multiply;

Console.WriteLine("[나눗셈]");
op = Divide;
Console.WriteLine($"20 / 4 = {op(20, 4)}");


int Add(int a, int b) => a + b;
int Subtract(int a, int b) => a - b;
int Multiply(int a, int b) => a * b;
int Divide(int a, int b) => a / b;

delegate int MathOp(int x, int y);


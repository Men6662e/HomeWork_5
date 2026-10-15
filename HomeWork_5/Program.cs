Console.WriteLine("--- Улучшенный калькулятор ---");
Console.WriteLine("Доступные операции: +, -, *, /");
Console.WriteLine();

double num1 = ReadNumber();
double num2 = ReadNumber();
string op = ReadOperation();

CalculateAndPrint(num1, num2, op);

Console.ReadLine();

double ReadNumber()
{
    Console.Write("Введите число: ");
    string input = Console.ReadLine()!;
    return Convert.ToDouble(input);
}

string ReadOperation()
{
    Console.Write("Введите символ операции: ");
    return Console.ReadLine()!;
}

void CalculateAndPrint(double a, double b, string op)
{
    double result = 0;

    if (op == "+")
    {
        result = a + b;
    }
    if (op == "-")
    {
        result = a - b;
    }
    if (op == "*")
    {
        result = a * b;
    }
    if (op == "/")
    {
        result = a / b;
    }

    Console.WriteLine();
    Console.WriteLine("Результат: " + a + " " + op + " " + b + " = " + result);
}

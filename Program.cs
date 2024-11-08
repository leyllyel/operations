using System.IO;
using static System.Net.Mime.MediaTypeNames;


Console.WriteLine("Введите простое арифметическое выражение: ");
try { 
string c = Console.ReadLine();
    char[] symbols = new char[] { '+', '-', '*', '/', };
string[] vars = c.Split(symbols);


if (vars.Length != 2)
{
    Console.WriteLine("Ошибка: неверный формат выражения.");
    return;
}

int operand1 = int.Parse(vars[0].Trim());
int operand2 = int.Parse(vars[1].Trim());
char operation = c[vars[0].Length];

int result = 0;
    StreamReader sr = new StreamReader("C:\\Users\\prdb\\source\\repos\\ConsoleApp15\\Вывод.txt");
    switch (operation)
{
    case '+':
        result = operand1 + operand2;
        break;
    case '-':
        result = operand1 - operand2;
        break;
    case '*':
        result = operand1 * operand2;
        break;
    case '/':
        if (operand2 == 0)
        {
            Console.WriteLine("Ошибка: деление на ноль.");
            return;
        }
        result = operand1 / operand2;
        break;
    default:
        Console.WriteLine("Ошибка: неизвестная операция.");
        return;
}
Console.WriteLine($"Результат: {result}");

}
        catch (FormatException)
        {
    Console.WriteLine("Ошибка: неверный формат числа.");
}
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
   }

using System.Diagnostics.CodeAnalysis;
Console.WriteLine("Введите число 1:");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2:");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Выбиерите функцию: +, -, *, / ");
char operation = Convert.ToChar(Console.ReadLine());

switch (operation)
{
    case '+':
        Console.WriteLine(num1 + num2);
        break;

    case '-':
        Console.WriteLine(num1 - num2);
        break;

    case '*':
        Console.WriteLine(num1 * num2);
        break;

    case '/':
        Console.WriteLine(num1 / num2);
        break;

    default:
        Console.WriteLine("Вы ввели неправильный знак, повторите попытку");
        break;

}
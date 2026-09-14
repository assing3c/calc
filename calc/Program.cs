using System.Diagnostics.CodeAnalysis;
Console.WriteLine("Введите первое число:");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите действие");
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

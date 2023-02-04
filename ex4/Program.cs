Console.Write("Введите первое число: ");
double firstValue = double.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
double secondValue = double.Parse(Console.ReadLine()!);
double divResult = firstValue / secondValue;
Console.Write("Результат деления двух чисел: " + divResult);
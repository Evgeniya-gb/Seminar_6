// Pадача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Введите числа через пробел: ");
int[] num = Array.ConvertAll( Console.ReadLine().Split(), int.Parse );
int count = 0;
 
for (int m = 0; m < num.Length; m++)
{
    if (num[m] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"Количество введенных чисел > 0: {count}");



// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


Console.Write("Введите значение k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());
 
Console.Clear();

var x = -(b1 - b2) / (k1 - k2);
var y = k1 * x + b1;
 
x = Math.Round(x, 3);
y = Math.Round(y, 3);
 
Console.WriteLine($"Точка пересечения прямых: ({x};{y})");


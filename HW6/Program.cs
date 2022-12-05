/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3


int [] RandomMassiv (int size, int minValue, int maxValue)
{
    int [] newArray = new int [size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue+1);
    }
    return newArray;
}
 void ShowArray (int[] array)
 {
    Console.Write("Massiv -> ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
     Console.WriteLine();
 }

void AmountPositiveNumbers (int [] array)
{
    int amountNumbers = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) amountNumbers = amountNumbers = amountNumbers +1;
    }
    Console.Write($"amount positive numbers = {amountNumbers}");
}


  Console.WriteLine("Введите размер массива");
 int a = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Введите минимальный элемент");
 int min = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Введите максимальный элемент");
 int max = Convert.ToInt32(Console.ReadLine());
 int[] myArray = RandomMassiv(a, min, max); 
 ShowArray (myArray);
AmountPositiveNumbers (myArray);
*/
/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

void PointIntersection (double k1, double b1, double k2, double b2)
{
    double firstCoordinat = ((b1-b2) / (k2-k1)); // (5-9)/(4-2)=-0.5
    double secondCoordinat = k1 * firstCoordinat + b1;
    Console.Write($"Coordinats point intersection ({firstCoordinat}:{secondCoordinat})");
}

Console.WriteLine("Input coordinat K1 first line =");
 double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinat B1 first line =");
 double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinat K2 second line =");
 double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinat B2 second line =");
 double b2 = Convert.ToDouble(Console.ReadLine());

PointIntersection(k1, b1, k2, b2);

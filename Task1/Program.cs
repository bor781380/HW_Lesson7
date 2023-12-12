// Задача 1: 
//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.


Console.Write("Введите начальное число диапазона: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конечное число диапазона: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m>n) Console.Write("Введено начальное число дольше конечного. Решения нет");
NaturalRange(m, n);
        
    
void NaturalRange(int x, int y)
{
    if (x <= y)
    {
        Console.Write(x + " ");
        NaturalRange(x+1, y);
    }
}
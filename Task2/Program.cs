// Задача 2: 
//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Write("Для вычисления функции Аккермана введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Для вычисления функции Аккермана введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m<0 || n <0) Console.Write("Число не может быть отрицательным, попробуйте еще");
else Console.Write(AckermanFunction(m,n));
   
int AckermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0 && m>0) return AckermanFunction(m - 1, 1);
    
    else if (m>0 && n>0) return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
    
    else return -1;
}
    
// Комментарий к выполненному заданию. В примере ответа в презентации указан ответ как А(2,3) = 29, 
// это ошибка, А(3,2) =29, 
// а А(3,3) = 9.
// В качестве доказательства приложены скрины с таблицы ответов функции Аккермана
//  и скрин он-лайн калькулятора функции.
//Дано: 1) m = 2, n = 3; A(m,n) = 9
//      2) m = 3, n = 2; A(m,n) = 29
//Вычислите функцию Аккермана.

Console.WriteLine("Введите значение m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Функция Аккермана = {AckermanFunction(m, n)}");

int AckermanFunction(int m, int n)
{
   if (m == 0)
     {
        return n + 1;
     }
   if (m != 0 && n == 0)
    {
        return AckermanFunction(m - 1, 1);
     }
   if (m > 0 && n > 0)
     {
        return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
     }
   return AckermanFunction(m, n);
}
//Задайте значения m и n. 
//Выведите все чётные натуральные числа от m до n.

Console.WriteLine("Введите значение m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение n: ");
int n = Convert.ToInt32(Console.ReadLine());
EvenNumbers(m,n);

void EvenNumbers(int m, int n)
{
   if(m > n)
     {
        return;
     }
   if(m % 2 == 0)
     {
        Console.WriteLine($"{m}; ");
     EvenNumbers(m + 2, n);
     }
   else 
     {
        EvenNumbers(m + 1, n);
     }
}

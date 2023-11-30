//Задайте значения m и n.
//Найдите сумму натуральных элементов от m до n.

Console.WriteLine("Введите значение m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение n: ");
int n = Convert.ToInt32(Console.ReadLine());
SumOfElements(m, n);

void SumOfElements(int m, int n)
{
    Console.WriteLine(sum(m - 1, n));
}

int sum(int m, int n)
{
    int result = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        result = m + sum(m, n);
        return result;
    }
}
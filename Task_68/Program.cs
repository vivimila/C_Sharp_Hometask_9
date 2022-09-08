// Hапишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

//int Akk(n, m);

int Akk(int m, int n)
{
    if (m == 0) return n + 1;
    else if ((m != 0) && (n == 0)) return Akk(m - 1, 1);
    else if ((m > 0) && (n > 0)) return Akk(m - 1, Akk(m, n - 1));
    return Akk(m, n);
}
Console.WriteLine($"Функция Аккермана  = {Akk(m, n)}");
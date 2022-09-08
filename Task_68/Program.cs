// Hапишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число m: ");
int m = 3; 
Console.Write("Введите число n: ");
int n = 2; 

//int Akk(n, m);

int Akk(int m, int n)
{
    if (m == 0) return n + 1;
    else if ((m != 0) && (n == 0)) return Akk(m - 1, 1);
    else if ((m > 0) && (n > 0)) return Akk(m - 1, Akk(m, n - 1));
    return Akk(m, n);
}
Console.WriteLine($"Функция Аккермана  = {Akk(n, m)}");
// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите значение числа M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение числа N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int sum = 0;

void NaturalNumber(int sum)
{
    if (numberM < numberN) return;
    sum = sum + (numberM++);
    //Console.Write($"Сумма от M до N: {sum} ");
   
}

Console.Write($"Сумма от M до N: {sum} ");

NaturalNumber(sum);
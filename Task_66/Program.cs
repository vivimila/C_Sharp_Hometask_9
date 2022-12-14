// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите значение числа M = ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение числа N = ");
int numN = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int numM, int numN)
{
    if (numM == numN) return numM;                       
    else if (numM < numN) return numN + SumNumbers(numM, numN - 1); 
    else return numN + SumNumbers(numM, numN + 1);            
}
Console.WriteLine($"Сумма натуральных чисел = {SumNumbers(numM, numN)}");
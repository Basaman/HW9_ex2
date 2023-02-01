//Задача 66: Задайте значения M и N. 
//Напишите программу, которая найдёт сумму 
//натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.Write("Введите целое число M: ");
int numberM = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите целое число N: ");
int numberN = int.Parse(Console.ReadLine() ?? "");

int sumNumbers = GetSumNumbers(numberM, numberN);
Console.Write($"M = {numberM}; N = {numberN}; -> {sumNumbers}");

int GetSumNumbers(int startNumber, int lastNumber)
{
    int sum = 0;
    if (startNumber <= lastNumber)
    {
        sum = startNumber + GetSumNumbers(startNumber + 1, lastNumber);
    }
    return sum;
}
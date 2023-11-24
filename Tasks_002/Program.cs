/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int ReadInt(string text)
{
    Console.WriteLine(text);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}
int SumDigits(int startNumber, int stopNumber)
{
    if (startNumber >= stopNumber) return startNumber;
    return startNumber + SumDigits(startNumber +1, stopNumber);
}
Console.WriteLine (SumDigits(ReadInt("Введите значение M:"), ReadInt("Введите значение N:")));
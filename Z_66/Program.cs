/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Clear();

int GetDataFromUser(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int numM = GetDataFromUser("Введите начальное число: ");
int numN = GetDataFromUser("Введите конечное число: ");


void SumNumberMid (int numM, int numN, int sum)
{
    if (numM > numN) 
    {
        Console.Write($"Сумма чисел от M до N равна {sum}"); 
        return;
    }
    sum = sum + (numM++);
    SumNumberMid(numM, numN, sum);
}

SumNumberMid(numM, numN, 0);

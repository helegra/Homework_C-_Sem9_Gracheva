// Задача 66: 
// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое натуральное число");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе натуральное число");
int m = Convert.ToInt32(Console.ReadLine());

if (n <= 0 || m <= 0)                                // Проверка корректного ввода
{
    Console.WriteLine("Введено не натуральное число, введите целое положительное");
    return;
}

int PrintSum(int start, int end)
{
    if (start > end)
    {
        return (start + PrintSum(start - 1, end));
    }
    if (start == end)
    {
        return start;
    }
    return (start + PrintSum(start+1, end));
}

Console.WriteLine($"N = {n}; M = {m} -> " +(PrintSum(n, m)));

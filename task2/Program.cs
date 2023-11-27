// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void EnterNumbers ()
{
Console.Write("Введите число M: ");
int M;
if (!int.TryParse(Console.ReadLine(),out M) || M < 1)
{
    Console.WriteLine($"Введенное значение M={M} не является натуральным числом, повторите ввод.");
    EnterNumbers();
    return;
}
Console.Write("Введите число N: ");
int N;
if (!int.TryParse(Console.ReadLine(),out N) || N < 1)
{
    Console.WriteLine($"Введенное значение N={N} не является натуральным числом, повторите ввод.");
    EnterNumbers();
    return;
}
PrintSum(M,N);
}

void PrintSum(int start, int end)
{
    Console.WriteLine($"Результат: M = {start}; N = {end}. -> {SumRecursive(start, end)}");
}

int SumRecursive (int start, int end)
{
    if (start == end) return start;
    if (start > end) return start + SumRecursive(start - 1, end);
    if (start < end) return start + SumRecursive(start + 1, end);
    return 0;
}

EnterNumbers();
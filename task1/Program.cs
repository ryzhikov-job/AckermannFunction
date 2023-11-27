// Задача 64: Задайте значения M и N. 
// Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"

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
PrintNumbers(M,N);
}

void PrintNumbers (int start, int end)
{
    Console.WriteLine($"Результат: M = {start}; N = {end}. -> \"{PrintNumbersRecursive(start, end)}\"");
}

string PrintNumbersRecursive (int start, int end)
{
    if (start == end) return start.ToString();
    if (start > end) return (start + ", " + PrintNumbersRecursive(start - 1, end));
    if (start < end) return (start + ", " + PrintNumbersRecursive(start + 1, end));
    return string.Empty;
}

EnterNumbers();
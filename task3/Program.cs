// Задача 68: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 29

void EnterAckermannM ()
{
Console.Write("Введите введите неотрицательное число m: ");
int m;
if (!int.TryParse(Console.ReadLine(),out m) || m < 0)
{
    Console.WriteLine($"Введенное значение m={m} имеет отрицательное значение или не является числом, повторите ввод.");
    EnterAckermannM();
    return;
}
EnterAckermannN(m);
}

void EnterAckermannN (int m)
{
Console.Write("Введите число n: ");
int n;
if (!int.TryParse(Console.ReadLine(),out n) || n < 0)
{
    Console.WriteLine($"Введенное значение n={n} имеет отрицательное значение или не является числом, повторите ввод.");
    EnterAckermannN(m);
    return;
}
PrintAckermann(m, n);
}

void PrintAckermann(int m, int n)
{
    Console.WriteLine($"Результат: m = {m}; n = {n}. -> A(m,n) = {AckermannFunction(m, n)}");
}

int AckermannFunction(int m, int n)
    {
        if (m == 0) return n + 1;
        if (m > 0 && n == 0) return AckermannFunction(m - 1, 1);
        if (m > 0 && n > 0) return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
        return 0;
    }

EnterAckermannM();
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Console.Write("Введите значение M: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите значение N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int akkerman(int m, int n)
// {
//     if (m == 0) return n + 1;
//     else 
//     if (n == 0) return akkerman(m - 1, 1);
//     else 
//     return akkerman(m, n - 1, akkerman(m, n - 1));
// }
// Console.Write($"Функция Аккермана равно {akkerman(m, n)}");

int Ackermann(int m, int n)
{
    if (m == 0)
    return n + 1;

    if (n == 0)
    return Ackermann(m -1, 1);

    return Ackermann(m -1, Ackermann(m, n -1));
}
int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int m = ReadInt("Введите значение m: ");
int n = ReadInt("Введите значение n: ");

int result = Ackermann(m, n);

Console.WriteLine($"Результат:{result}");

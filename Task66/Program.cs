// Задача 66: Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Clear();
Console.ForegroundColor = ConsoleColor.Blue;
int m = Input("Введите M: ");
int n = Input("Введите N: ");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"Сумма элементов от {m} до {n} = {CountNatSum(m, n)}");

int Input(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int CountNatSum(int m, int n)
{
    if (m == n)
        return n;
    return n + CountNatSum(m, n - 1);
}
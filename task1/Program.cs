// Задайте значения M и N.
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.

void Main()
{
    System.Console.Write("Введите значение M : ");
    int m = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Введите значение N : ");
    int n = Convert.ToInt32(Console.ReadLine());
   
    PrintInterval(m, n);
    PrintInterval(n, m);
}

void PrintInterval(int max, int min)
{
    if (max < min)
        return;
    PrintInterval(max - 1, min);
    System.Console.Write(max + " ");
}

Main();



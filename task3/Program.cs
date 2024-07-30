// Задайте произвольный массив.
// Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

void Main()
{
    System.Console.Write("Введите размер массива : ");
    int arraySize = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[arraySize];
    Random rand = new Random();
    System.Console.Write("Заданный массив : ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(0, 100);
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
    System.Console.Write("Развернутый массив :");
    PrintArray(array.Length);

    void PrintArray(int n)
    {
        if (n < 1)
            return;
        System.Console.Write(array[n - 1] + " ");
        PrintArray(n - 1);
    }
}

Main();

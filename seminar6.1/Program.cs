int CountZeros(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}


Console.Write("Сколько чисел Вы хотите ввести: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];

Console.WriteLine("Вводит числа после каждого нажимая Enter");
for (int i = 0; i < n; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Write($"Вы ввели {CountZeros(arr)} чисел больше нуля");
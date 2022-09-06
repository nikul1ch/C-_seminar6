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
// int n = Convert.ToInt32(Console.ReadLine());


// int[] arr = new int[n];

// void FillingArrayRandom(int[] array)
// {
//     for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(-100, 100);
// }

// int SumOddElements(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i += 2) sum += array[i];  //Счётчик указываю с нуля, т.к. нулевой индекс это 1 позиция)
//     return sum;
// }

// void PrintArray(int[] array)
// {
//     Console.Write("[ ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i == array.Length - 1) Console.Write(array[i]);
//         else Console.Write(array[i] + ", ");
//     }
//     Console.WriteLine(" ]");
// }

// FillingArrayRandom(arr);
// PrintArray(arr);

// Console.Write("Cумма элементов, стоящих на нечётных позициях: " + SumOddElements(arr));
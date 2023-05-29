int[] FillArray()
{
    int[] array = new int[4];
    int index = 0;
    while (index < array.Length)
    {
        array[index] = new Random().Next(-100, 100);
        index++;
    }
    return array;
}

int OddSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) sum += array[i];
    }
    return sum;
} 

void PrintArray(int[] array)
{
   
    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {   
        if (i == array.Length - 1) System.Console.Write($"{array[i]}");
        else System.Console.Write($"{array[i]},");
    }
    Console.Write("]");
}

int[] array = FillArray();
PrintArray(array);
Console.WriteLine($" -> {OddSum(array)}");
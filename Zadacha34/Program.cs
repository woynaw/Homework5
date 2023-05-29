int[] FillArray()
{
    int[] array = new int[5];
    int index = 0;
    while (index < array.Length)
    {
        array[index] = new Random().Next(100, 1000);
        index++;
    }
    return array;
}

int EvenCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
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
Console.WriteLine($" -> {EvenCount(array)}");

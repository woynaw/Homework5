float[] FillArray()
{
    float[] array = new float[5];
    int index = 0;
    while (index < array.Length)
    {
        array[index] = new Random().Next(-100, 100);
        index++;
    }
    return array;
}

float Max_(float[] array)
{
    float max = -101;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

float Min_(float[] array)
{
    float min = 101;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

void PrintArray(float[] array)
{

    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1) System.Console.Write($"{array[i]}");
        else System.Console.Write($"{array[i]},");
    }
    Console.Write("]");
}

float[] array = FillArray();
PrintArray(array);
Console.WriteLine($" -> {Max_(array) - Min_(array)}");
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] RandomArray(int size)
{
    int[] newArray = new int[size];
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(99, 999);
    }
    return newArray;
}
void PrintArray(int[] newArray)
{
    for(int i = 0; i < newArray.Length; i++)
    {
        Console.Write(newArray[i] + " ");
    }
}
int kol(int[] RandomArray)
{
    int kol = 0;
    for (int i = 0; i < RandomArray.Length; i++)
    {
        if (RandomArray[i] % 2 == 0)
        kol = kol + 1;
    }
    return kol;
}
Console.WriteLine("Input array size");
int size = Convert.ToInt32(Console.ReadLine());
int[] myArray = RandomArray(size);

PrintArray(myArray);
Console.WriteLine($"\nThe number of even numbers in the array: -> {kol(RandomArray(size))}");
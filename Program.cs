// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int[] RandomArray(int size)
// {
//     int[] newArray = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(99, 999);
//     }
//     return newArray;
// }
// void PrintArray(int[] newArray)
// {
//     for(int i = 0; i < newArray.Length; i++)
//     {
//         Console.Write(newArray[i] + " ");
//     }
// }
// int kol(int[] RandomArray)
// {
//     int kol = 0;
//     for (int i = 0; i < RandomArray.Length; i++)
//     {
//         if (RandomArray[i] % 2 == 0)
//         kol = kol + 1;
//     }
//     return kol;
// }
// Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] myArray = RandomArray(size);

// PrintArray(myArray);
// Console.WriteLine($"\nThe number of even numbers in the array: -> {kol(RandomArray(size))}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// int[] RandomArray(int size, int minValue, int maxValue)
// {
//     int[] newArray = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue);
//     }
//     return newArray;
// }
// void PrintArray(int[] newArray)
// {
//     for(int i = 0; i < newArray.Length; i++)
//     {
//         Console.Write(newArray[i] + " ");
//     }
// }
// int kol(int[] RandomArray)
// {
//     int sum = 0;
//     int i = 0;
//     while (i < RandomArray.Length)
//     {
//          sum = sum + RandomArray[i];
//          i = i + 2;
//     }
//     return sum;
// }

// Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maximal value of element");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = RandomArray(size, minValue, maxValue);

// PrintArray(myArray);
// Console.WriteLine($"\nThe sum of the elements standing in odd positions: -> {kol(myArray)}");


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input minimal value of element");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maximal value of element");
int maxValue = Convert.ToInt32(Console.ReadLine());
double[] randomArray = new double[a];

void mas(int a, int minValue, int maxValue)
{
    Random rand = new Random();
    for (int i = 0; i < a; i++)
    {
        randomArray[i] = rand.NextDouble() + rand.Next(minValue,maxValue);
        Console.Write($"{randomArray[i]} ");
    }
}

double raz(double[] randomArray)
{
    double min = randomArray[0];
    double max = randomArray[0];
    int i = 1;
    while (i < randomArray.Length)
        {
            if (max<randomArray[i])
            max = randomArray[i];
            if (min>randomArray[i])
            min = randomArray[i];
            i = i + 1;
        }
    return max-min;
}

mas(a,minValue,maxValue);
Console.Write($"\nРазница между максимальным и минимальным элементов массива: {raz(randomArray)}");


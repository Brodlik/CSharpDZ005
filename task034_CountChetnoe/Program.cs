// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] FillArray(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[] arr = new int[size];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}
int[] array = FillArray(4, 100, 1000);
Console.WriteLine('[' + string.Join(", ", array) + ']');

int countChetnoe = 0; 
for (int i=0; i<array.Length; i++)
{
    if (array[i]%2==0)
    {
         countChetnoe ++;
    }
}
Console.Write($"Количество четных чисел = {countChetnoe}");
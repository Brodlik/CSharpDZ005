// Задача 38: Задайте с клавиатуры массив вещественных (double) чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// Задать размер (int) массива с клавиатуры
// [3 7 22 2 78] -> 76
Console.Write ("Введите размер массива:");
int size = Convert.ToInt32 (Console.ReadLine());

double[] FillArray(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    double[] arr = new double[size];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}
double[] array = FillArray(size, 0, 100);
Console.WriteLine('[' + string.Join(", ", array) + ']');

double max = array[0];

for (int i=0; i<array.Length; i++)
{
    if (array[i]>max)
    {
        max= array[i];
    }
}
Console.WriteLine($"Максимальное число = {max}");

double min = array[0];

for (int i=0; i<array.Length; i++)
{
    if (array[i]<min)
    {
        min= array[i];
    }
}
Console.WriteLine($"Минимальное число = {min}");

double chastnoeMaxMin=max-min;

Console.WriteLine($"Разница между максимальным и минимальным значением равна = {chastnoeMaxMin}");
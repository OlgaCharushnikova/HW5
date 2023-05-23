// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void Massiv(double[] array, int l)
{
     for (int i = 0; i < array.Length; i++)
     {
          array[i] = new Random().Next(0, 100);
          Console.Write($"{array[i]} ");
     }
}


double Max(double[] array, int l)
{
    int i = 0;
    double max = array[i];
    for (i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}


double Min(double[] array, int l)
{
    int i = 0;
    double min = array[i];
    for (i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}


double DifferenceMaxMin(double max, double min)
{
    double diff = max - min;
    return diff;
}


Console.WriteLine("Введите количество элементов массива: ");
int l = Convert.ToInt32(Console.ReadLine());
double[] arr = new double[l];
Massiv(arr, l);
Console.Write(" -> ");
Console.WriteLine(DifferenceMaxMin(Max(arr, l), Min(arr, l)));
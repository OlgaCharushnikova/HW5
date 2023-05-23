// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void Massiv(int[] array, int l)
{
     for (int i = 0; i < array.Length; i++)
     {
          array[i] = new Random().Next(-100, 100);
          Console.Write($"{array[i]} ");
     }
}
int SumElemens(int[] array, int l)
{ 
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i%2 != 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

Console.WriteLine("Введите количество элементов массива: ");
int l = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[l];
Massiv(arr, l);
Console.WriteLine();
Console.WriteLine(SumElemens(arr, l));

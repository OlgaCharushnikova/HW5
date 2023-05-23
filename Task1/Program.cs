// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


void Massiv(int[] array, int l)
{
     for (int i = 0; i < array.Length; i++)
     {
          array[i] = new Random().Next(100, 1000);
          Console.Write($"{array[i]} ");
     }
}

void KolichestvoChetChis(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]%2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine(count);
}
Console.WriteLine("Введите количество элементов массива: ");
int l = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[l];
Massiv(arr, l);
Console.Write(" -> ");
KolichestvoChetChis(arr);



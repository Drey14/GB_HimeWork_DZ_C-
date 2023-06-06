/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

void RandomNumberArrayIndex(){
int totalCount = 0;
int[] array = new int[4];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-999,1000);
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]}; ");
    if (i%2 != 0)
    {
        totalCount = totalCount+array[i];
    }
}
    Console.WriteLine();
    Console.WriteLine($"Cумма элементов, стоящих на нечётных индексах равна: {totalCount}");
}

RandomNumberArrayIndex();
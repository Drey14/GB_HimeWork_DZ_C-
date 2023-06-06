//Задача 38: Задайте массив вещественных случайных чисел. Найдите разницу между максимальным и минимальным элементов массива.
void RandomDoubleArray(){
int totalCount = 0;
double[] array = new double[4];

for (int i = 0; i < array.Length; i++)
{
    array[i] = (new Random().NextDouble()) * 10*(i+1);
    Console.Write($"{array[i]}; ");
}

array.Min();

    Console.WriteLine();
    Console.WriteLine($"Разницуа между максимальным и минимальным элементов массива: {array.Max() - array.Min()}");
}

RandomDoubleArray();
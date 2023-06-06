/*
Урок 5. Функции и одномерные массивы
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2

*/

void RandomNumberArray(){
int count=0;
int[] arrayNum = new int[4];

for (int i = 0; i < arrayNum.Length; i++)
{
    arrayNum[i] = new Random().Next(100,1000);
}

for (int i = 0; i < arrayNum.Length; i++)
{
    Console.Write($"{arrayNum[i]};");
    if (arrayNum[i]%2 == 0)
    {
        count++;
    }
}
    Console.WriteLine();

    Console.WriteLine($" Количество чётных чисел в массиве {count}");
}
RandomNumberArray();
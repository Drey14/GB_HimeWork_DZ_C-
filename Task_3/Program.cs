/*
Условия задачи не корректны, а именно тесты ниже !!!! Задача согласно условию написана ниже

Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

void arrayEightNumber(){
int[] arrayNum = new int[8];
    for (int i = 0; i < arrayNum.Length; i++)
    {
        Console.WriteLine($"Введите числовой {i} элемент массива!");
        arrayNum[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Ниже список элементов массива!");
    for (int i = 0; i < arrayNum.Length; i++)
    {
    Console.Write($"{arrayNum[i]}; ");
    }
Console.WriteLine("Hapy End!");
}

arrayEightNumber();

/*
Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/


 Console.Clear();
    Console.WriteLine("Введите число - m строк двумерного массива!");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число - n столбцов двумерного массива!");
    int n  = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("Введите число (+/- Х) для поиска в двумерном массиве!");
    int x  = Convert.ToInt32(Console.ReadLine());
    int[,] twoDimensionalArray = new int[m,n];
    
    void FillingTwoDimensionalArrayWithRandomNumbers(int[,] twoDimensionalArray){
    
        for (int i = 0; i < twoDimensionalArray.GetLength(0); i++)
        {
            for (int j = 0; j < twoDimensionalArray.GetLength(1); j++)
            {
                twoDimensionalArray[i,j] = new Random().Next(-10,10);
            }
        }
    
    }
    
    void ShowTwoArrayValues(int[,] twoDimensionalArray){
          for (int i = 0; i < twoDimensionalArray.GetLength(0); i++)
        {
            for (int j = 0; j < twoDimensionalArray.GetLength(1); j++)
            {
                 Console.Write($"{twoDimensionalArray[i,j]}, ");
            }
            Console.WriteLine(String.Empty);
        }
    }

    void FindingNumberIn2DArray(int[,] twoDimensionalArray, int valueX){
        Boolean flag = false;
        int count = 0;
          for (int i = 0; i < twoDimensionalArray.GetLength(0); i++)
        {
            for (int j = 0; j < twoDimensionalArray.GetLength(1); j++)
            {
                if (twoDimensionalArray[i,j] == valueX)
                {
                    flag = true;
                    count++;
                }
            }
        }
        if (flag)
        {
        Console.WriteLine($"Заданное число X: {valueX} в массиве:  найдено, {count} раз(/а) !!!");
        }else 
        Console.WriteLine($"Заданное число Х: {valueX} в массиве НЕ найдено!!!");
    }

    FillingTwoDimensionalArrayWithRandomNumbers(twoDimensionalArray);
    ShowTwoArrayValues(twoDimensionalArray);
    FindingNumberIn2DArray(twoDimensionalArray,x);
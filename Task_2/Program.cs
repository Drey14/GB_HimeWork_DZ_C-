/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

Console.Clear();
    Console.WriteLine("Введите число - m строк двумерного массива!");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число - n столбцов двумерного массива!");
    int n  = Convert.ToInt32(Console.ReadLine());
    int[,] twoDimensionalArray = new int[m,n];
    
    
    void FillingTwoDimensionalArrayWithRandomNumbers(int[,] twoDimensionalArray){
    
        for (int i = 0; i < twoDimensionalArray.GetLength(0); i++)
        {
            for (int j = 0; j < twoDimensionalArray.GetLength(1); j++)
            {
                twoDimensionalArray[i,j] = new Random().Next(0,10);
            }
        }
    
    }
    
    void ShowTwoArrayValues(int[,] twoDimensionalArray){
    Console.WriteLine("**************************************");

          for (int i = 0; i < twoDimensionalArray.GetLength(0); i++)
        {
            for (int j = 0; j < twoDimensionalArray.GetLength(1); j++)
            {
                 Console.Write($"{twoDimensionalArray[i,j]}, ");
            }
            Console.WriteLine(String.Empty);
        }
    Console.WriteLine("**************************************");
    }

 void MinimumSumValueInTheArray (int[,] twoDimensionalArray ){   
    int[] arraySummCol = new int[m];   
    int summator = 0;
    int minSum = -1;
    int minRow = -1;

        for (int i = 0; i < twoDimensionalArray.GetLength(0); i++)
        {
            for (int j = 0; j < twoDimensionalArray.GetLength(1); j++)
            {
            summator = summator+twoDimensionalArray[i,j];
            }
            arraySummCol[i] = summator;
            summator=0;
        }

        minSum=arraySummCol[0];
        minRow = 0;
        for (int i = 1; i < arraySummCol.Length; i++)
        {
           if(minSum>arraySummCol[i]){
            minSum=arraySummCol[i];
            minRow = i;
           } 
        }
    Console.WriteLine($"Строка с минимальной суммой {minRow} __ минимальная сумма равна {minSum}");
    }

    FillingTwoDimensionalArrayWithRandomNumbers(twoDimensionalArray);
    ShowTwoArrayValues(twoDimensionalArray);
    MinimumSumValueInTheArray(twoDimensionalArray);

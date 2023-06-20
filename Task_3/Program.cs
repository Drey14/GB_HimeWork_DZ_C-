/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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

    void ArgNumberIn2DArray(int[,] twoDimensionalArray){
        double[] argArray = new double[m];
        double argCount = 0.0;
          for (int i = 0; i < twoDimensionalArray.GetLength(0); i++)
        {
            for (int j = 0; j < twoDimensionalArray.GetLength(1); j++)
            {
                argCount=argCount+(twoDimensionalArray[i,j]*1.0);
            }
            argArray[i] = argCount/2;
            argCount=0;
        }
        for (int i = 0; i < argArray.Length; i++)
        {
            Console.WriteLine($"Строка № {i} среднее значение {argArray[i]}");
        }
    }

    FillingTwoDimensionalArrayWithRandomNumbers(twoDimensionalArray);
    ShowTwoArrayValues(twoDimensionalArray);
    ArgNumberIn2DArray(twoDimensionalArray);

/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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

    void MinimumValueInTheArray (int[,] twoDimensionalArray ){        
        int maxValue = -1;
        int maxRow = -1;
        int maxCol = -1;
        int curValue = -1;
        int curRow = -1;
        int curCol = -1;
        

        for (int i = 0; i < twoDimensionalArray.GetLength(0); i++)
        {
            for (int j = 0; j < twoDimensionalArray.GetLength(1); j++)
            {
            curValue = twoDimensionalArray[i,j];
            curRow = i;
            curCol = j;
            maxValue = twoDimensionalArray[i,j];;
            maxRow = i;
            maxCol = j;
               for (int k = j+1; k < twoDimensionalArray.GetLength(1); k++)
               {
                if (maxValue<twoDimensionalArray[i,k])
                {
                    maxValue = twoDimensionalArray[i,k];
                    maxRow = i;
                    maxCol = k;
                }
               }
               twoDimensionalArray[curRow,curCol] = maxValue;
               twoDimensionalArray[maxRow,maxCol] = curValue;
            }
        }
    }

    FillingTwoDimensionalArrayWithRandomNumbers(twoDimensionalArray);
    ShowTwoArrayValues(twoDimensionalArray);
    MinimumValueInTheArray(twoDimensionalArray);
    ShowTwoArrayValues(twoDimensionalArray);
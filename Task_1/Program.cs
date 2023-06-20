    // See https://aka.ms/new-console-template for more information
    /*
    Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
    
    m = 3, n = 4.
    
    0,5 7 -2 -0,2
    
    1 -3,3 8 -9,9
    
    8 7,8 -7,1 9
    */
    Console.Clear();
    Console.WriteLine("Введите число - m строк двумерного массива!");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число - n столбцов двумерного массива!");
    int n  = Convert.ToInt32(Console.ReadLine());
    double[,] twoDimensionalArray = new double[m,n];
    
    void FillingTwoDimensionalArrayWithRandomNumbers(double[,] twoDimensionalArray){
    
        for (int i = 0; i < twoDimensionalArray.GetLength(0); i++)
        {
            for (int j = 0; j < twoDimensionalArray.GetLength(1); j++)
            {
                twoDimensionalArray[i,j] = new Random().Next(-1000,1000)*1.5;
            }
        }
    
    }
    
    void ShowTwoArrayValues(double[,] twoDimensionalArray){
          for (int i = 0; i < twoDimensionalArray.GetLength(0); i++)
        {
            for (int j = 0; j < twoDimensionalArray.GetLength(1); j++)
            {
                 Console.Write($"{twoDimensionalArray[i,j]}, ");
            }
            Console.WriteLine(String.Empty);
        }
    }

    FillingTwoDimensionalArrayWithRandomNumbers(twoDimensionalArray);
    ShowTwoArrayValues(twoDimensionalArray);




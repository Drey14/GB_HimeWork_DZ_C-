/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
Console.Clear();
    Console.WriteLine("Введите число - m1 строк первого двумерного массива!");
    int m1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число - n1 столбцов первого двумерного массива!");
    int n1  = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число - m1 строк первого двумерного массива!");
    int m2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число - n1 столбцов первого двумерного массива!");
    int n2  = Convert.ToInt32(Console.ReadLine());
    int[,] twoDimensionalArrayOne = new int[m1,n1];
    int[,] twoDimensionalArrayTwo = new int[m2,n2];


    void FillingTwoDimensionalArrayWithRandomNumbers(int[,] twoDimensionalArray){
    
        for (int i = 0; i < twoDimensionalArray.GetLength(0); i++)
        {
            for (int j = 0; j < twoDimensionalArray.GetLength(1); j++)
            {
                twoDimensionalArray[i,j] = new Random().Next(1,4);
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

    int[,] CompatibilytyCheckMatrix(){
        if (n1 != m1)
        {
            Console.WriteLine("Матрицы могут быть перемножены, если они совместимы в том смысле, что число столбцов первой матрицы равно числу строк второй ");
            Console.WriteLine("Условия равества у ВАс при создании матриц НЕ выполнено (n1 != m1). ");
            return null;
        }else
            return MultipalNewMatrix();
    }

    int[,] MultipalNewMatrix(){
      int m3 = 0, n3 = 0;
    
        if (m1>m2)
        {
          m3=m1;
        }else 
          m3=m2;

        if (n1>n2)
        {
          n3=n1;
        }else 
          n3=n2;
    return new int[m3,n3];
    } 


    int[,] MultiplicationOfTwoMatrices(int[,] matrix1, int[,] matrix2){
        int[,] newMultMatrix = CompatibilytyCheckMatrix();
        int sumatorElement = 0;


        for (int i = 0; i < matrix1.GetLength(0); i++)
        {   
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                for (int k = 0; k < matrix2.GetLength(0); k++)
                {
                    sumatorElement = sumatorElement+(matrix1[i,k]*matrix2[k,j]);
                }
                newMultMatrix[i,j] = sumatorElement;
                sumatorElement=0;
            }
        }
    
        return newMultMatrix;
    }

    FillingTwoDimensionalArrayWithRandomNumbers(twoDimensionalArrayOne);
    FillingTwoDimensionalArrayWithRandomNumbers(twoDimensionalArrayTwo);
    ShowTwoArrayValues(twoDimensionalArrayOne);
    ShowTwoArrayValues(twoDimensionalArrayTwo);
    ShowTwoArrayValues(MultiplicationOfTwoMatrices(twoDimensionalArrayOne,twoDimensionalArrayTwo));


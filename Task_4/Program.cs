/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

    void FillingThreeDimensionalArrayWithRandomNumbers(int[,,] threeDimensionalArray){
    
        for (int i = 0; i < threeDimensionalArray.GetLength(0); i++)
        {
            for (int j = 0; j < threeDimensionalArray.GetLength(1); j++)
            {
                for (int k = 0; k < threeDimensionalArray.GetLength(2); k++)
                {
                  threeDimensionalArray[i,j,k] = new Random().Next(10,100);
                }
            }
        }
    
    }
    
        void ShowTwoArrayValues(int[,,] threeDimensionalArray){
    Console.WriteLine("**************************************");

          for (int i = 0; i < threeDimensionalArray.GetLength(0); i++)
        {
            for (int j = 0; j < threeDimensionalArray.GetLength(1); j++)
            {
                for (int k = 0; k < threeDimensionalArray.GetLength(2); k++)
                {
                Console.Write($" значение: {threeDimensionalArray[i,j,k]}, индексы: i={i} j={j} k={k}  ");
                }
            }
            Console.WriteLine(String.Empty);
        }
    Console.WriteLine("**************************************");
    }

int[,,] threeDimensionalArray = new int[2,2,2];

FillingThreeDimensionalArrayWithRandomNumbers(threeDimensionalArray);
ShowTwoArrayValues(threeDimensionalArray);
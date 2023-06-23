/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int sum = 0;
void АllNaturalNumbersUpToN(int num1, int num2){
    sum = sum+num1;
    if(num1 == num2){
    Console.Write($" сумма чисел от M до N равна: {sum}; ");
    return;
    }
    АllNaturalNumbersUpToN(num1+1,num2);
}

Console.WriteLine("Задайте начальное значение M.");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте конечное значение N.");
int num2 = Convert.ToInt32(Console.ReadLine());
АllNaturalNumbersUpToN(num1,num2);
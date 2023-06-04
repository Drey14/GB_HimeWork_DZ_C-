/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/
Console.WriteLine("Введите число!");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма чисел: {SumAmountOfNumbers(number)}");


int SumAmountOfNumbers(int number){
int numberDivideTen=number;
int numberRemainderDivideTen = number%10;
while(numberDivideTen!=0){
numberDivideTen = numberDivideTen/10;
numberRemainderDivideTen = numberRemainderDivideTen+numberDivideTen%10;
}
    return numberRemainderDivideTen;
}
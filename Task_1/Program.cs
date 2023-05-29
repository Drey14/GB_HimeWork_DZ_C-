// See https://aka.ms/new-console-template for more information
/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.
456 -> 5
782 -> 8
918 -> 1
*/
Console.Clear();

System.Console.WriteLine($"Введите трехзначное число!");
int num = Convert.ToInt32(Console.ReadLine());

if(num>=100 && num<=999){

System.Console.WriteLine($"Мы получаем следущее число без второго разряда {num/100}{num%10}");
}else{
System.Console.WriteLine($"Число не техзначное!");
}




/*
начинайте использовать функции , со следующего ДЗ это будет обязательно!

Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.

14212 -> нет

12821 -> да

23432 -> да

*/

void PalindromeIntFive (int num){
    int a1 = num/10000;
    int a2 = (num/1000)%10;
    int a3 = (num%100)/10;
    int a4  = num%10;

if(a1 == a4 && a2 == a3 ){
    Console.WriteLine($"Введенное число палиндром: {num}!");
}else
    Console.WriteLine($"число {num} НЕ палиндром!");

}
Console.WriteLine("Введите пятизначное число!");
int num = Convert.ToInt32(Console.ReadLine());
PalindromeIntFive(num);

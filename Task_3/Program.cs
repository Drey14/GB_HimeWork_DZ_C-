// See https://aka.ms/new-console-template for more information
/*Задача 3: 
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

sevenDay(num);

void sevenDay(int num){
if(num>=1 && num<=5){
System.Console.WriteLine($" {num} - 'это рабочий день!");
 }
if(num>=6 && num<=7){
System.Console.WriteLine($" {num} - 'это выходной день!"); 
 }
}


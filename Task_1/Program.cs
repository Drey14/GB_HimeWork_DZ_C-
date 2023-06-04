/*
Урок 4. Функции
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16

*/

void DegreeOfNumber(int numberNatural, int degre){
int totalNum=numberNatural;
for (int i = 1; i < degre; i++)
{
    totalNum= totalNum*numberNatural;
}
Console.WriteLine($" Число {numberNatural} в степени {degre} равно: {totalNum}");
}

Console.WriteLine("Введите число: ");
int numberNatural = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень числа: ");
int degre = Convert.ToInt32(Console.ReadLine());
DegreeOfNumber(numberNatural,degre);


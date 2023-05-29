// See https://aka.ms/new-console-template for more information
/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.Через строку решать нельзя.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
Console.Clear();
System.Console.WriteLine($"Введите трехзначное число!");
int num = Convert.ToInt32(Console.ReadLine());
int numberDigit = 0;
int numBuffer = num;
int firstNumTwo = -1;
int tailNum = -1;
while((numBuffer=numBuffer/10)!=0){
numberDigit++;
}

firstNumTwo=firstNumber(numberDigit);
tailNum = tailNumber(numberDigit);
System.Console.WriteLine($"Третьей цифры нет {firstNumTwo}{tailNum}");



int firstNumber(int numberDigit){
    int localDel = 10;
    for(int i=0; i<numberDigit-2; i++){
        localDel = localDel*10;
    }
    return num/localDel;
}

int tailNumber(int numberDigit){
    int localDel = 10;
    for(int i=0; i<numberDigit-3; i++){
        localDel = localDel*10;
    }
    return num%localDel;
}


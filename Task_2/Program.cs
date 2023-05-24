// See https://aka.ms/new-console-template for more information
/*
Задача 4: 
Напишите программу, которая принимает на вход три числа и выдаёт 
максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
Console.Clear();
Console.WriteLine("Введите первое число:");
int num1 =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int num2 =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int num3 =Convert.ToInt32(Console.ReadLine());
int max = num1;
if(max>num2){
    if(max>num3){
        Console.WriteLine("Первое введеное число максимальное max="+max);
    }else{
        max = num3;
        Console.WriteLine("Третье введеное число максимальное max="+max);
    }
}else{
    max = num2;
    if(max>num3){
        Console.WriteLine("Второе введеное число максимальное max="+max);
    }else{
        max = num3;
        Console.WriteLine("Третье введеное число максимальное max="+max);
    }
}



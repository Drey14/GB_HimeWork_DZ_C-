
int CalculationOfTheAckermannFunction (int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return CalculationOfTheAckermannFunction(n - 1, 1);
    else
      return CalculationOfTheAckermannFunction(n - 1, CalculationOfTheAckermannFunction(n, m - 1));
}
Console.WriteLine("Задайте значение N.");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте значение M.");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"значение функции Аккермана равно: {CalculationOfTheAckermannFunction(num1,num2)}");

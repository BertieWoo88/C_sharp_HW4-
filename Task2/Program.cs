// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11

//82 -> 10

//9012 -> 12

int asknum (string name)
{
    Console.Write($"Введите число {name}: ");
    int n = int.Parse(Console.ReadLine()!);
    return n; 
}

int summer (int num)
{
  int sum = 0;
  int res = num%10;
  if (res == 0)
  {
    sum = num;
    return sum;
  }
  else
  {
    num = num/10;
    return sum = res + summer(num);
  }  
}

int chislo = asknum("A");
Console.WriteLine(summer(chislo));
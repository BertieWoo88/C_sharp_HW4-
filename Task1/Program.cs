//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16

int Stepen (int a, int b)
{
    int res = 1;
    for (int i = 1; i<=b; i++)
    {
        res *= a;
        
    } return res;
}

int asknum (string name)
{
    Console.Write($"Введите число {name}: ");
    int n = int.Parse(Console.ReadLine()!);
    return n; 
}

int a = asknum("A");
int b = asknum("B");

Console.WriteLine(Stepen(a,b));
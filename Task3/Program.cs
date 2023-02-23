// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

//6, 1, 33 -> [6, 1, 33]

int asknum (string name)
{
    Console.Write($"Введите число {name}: ");
    int n = int.Parse(Console.ReadLine()!);
    return n; 
}

int[] arr_a(int length_arr, bool manual)
{
    int[] arr = new int[length_arr];
    if (manual == false)
    {
    for(int i = 0; i < arr.Length; i ++)
    {
    arr[i] =  new Random().Next(100);
    //Console.Write($"{arr[i]}, ");
    }
    }
    else
    {
     for(int i = 0; i < arr.Length; i ++)
     {
       arr[i] = asknum(Convert.ToString(i+1));     
     }   
    //for(int i = 0; i < arr.Length; i ++)
    //{
       //Console.Write($"{arr[i]}, "); 
    //}    
    }

    return arr;
}

void Printarr (int [] arr)
{
  Console.Write("[");
  for(int i = 0; i < arr.Length-1; i ++)
  {
    Console.Write($"{arr[i]}, ");
  }
    Console.Write($"{arr[arr.Length-1]} ");
    Console.Write("]");
}

int [] mass = arr_a(8, false );
Printarr(mass);
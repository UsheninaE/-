﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

//void InputArray(int[] array)
//{
  //  for (int i = 0; i < array.Length; i++)
    //    array[i] = new Random().Next(100, 1000); 
//}
//int ReleaseArray(int[] array)
//{
  //  int count = 0;
    // for (int i = 0; i < array.Length; i++)
      //  if (array[i] % 2 == 0)
        //    count++;
   // return count;     
//}
//Console.Clear();
//Console.Write("Введите кол-во элементов в массиве: ");
//int n = Convert.ToInt32(Console.ReadLine());
//int[] array = new int[n];
//InputArray(array);
//Console.WriteLine($"[{string.Join(", ", array)}]");
//Console.WriteLine(ReleaseArray(array));

//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 100); 
}
int ReleaseArray(int[] array)
{
    int sum = 0;
     for (int i = 0; i < array.Length; i++)
        if (i % 2 != 0)
            sum = sum + array[i];
    return sum;     
}
Console.Clear();
Console.Write("Введите кол-во элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine(ReleaseArray(array));
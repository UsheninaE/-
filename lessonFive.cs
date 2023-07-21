// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
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

//void InputArray(int[] array)
//{
 //   for (int i = 0; i < array.Length; i++)
 //       array[i] = new Random().Next(-100, 100); 
//}
//int ReleaseArray(int[] array)
//{
//    int sum = 0;
  //   for (int i = 0; i < array.Length; i++)
    //    if (i % 2 != 0)
      //      sum = sum + array[i];
    //return sum;     
//}
//Console.Clear();
//Console.Write("Введите кол-во элементов в массиве: ");
//int n = Convert.ToInt32(Console.ReadLine());
//int[] array = new int[n];
//InputArray(array);
//Console.WriteLine($"[{string.Join(", ", array)}]");
//Console.WriteLine(ReleaseArray(array));

//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 100); 
}
int ReleaseArray(double[] array)
{
    double max = array[0];
    double min = array[0];
    double sum = 0;
     for (int i = 0; i < array.Length; i++)
        if (array[i] > max)
            max = array[i];
            if (array[i] < min)
                min = array[i];
    sum = max - min;
    return sum;     
}
Console.Clear();
Console.Write("Введите кол-во элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine(ReleaseArray(array));
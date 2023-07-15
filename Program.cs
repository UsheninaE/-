  // Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

//Console.Clear();
//Console.WriteLine("введите число - ");
//int firstNumber = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите число - ");
//int secondNumber = Convert.ToInt32(Console.ReadLine());
//if (firstNumber > secondNumber)
//    Console.WriteLine($"max = {firstNumber}");
//else
//   Console.WriteLine($"max ={secondNumber}");


//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22


//Console.Clear();
//Console.WriteLine("введите число - ");
//int n1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите число - ");
//int n2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите число - ");
//int n3 = Convert.ToInt32(Console.ReadLine());
//int maximum = n1;
//if (n2 > maximum)
//  maximum = n2;
//    if (n3 > maximum)
 //      maximum = n3;
 //   else maximum = n1;
//Console.WriteLine(maximum);

//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

Console.Clear();
//Console.WriteLine("введите число - ");
//int a = Convert.ToInt32(Console.ReadLine());
//if (a % 2 == 0)
//   Console.WriteLine("yes");
//  else 
//Console.WriteLine("no");


//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N. -> 2, 4
//8 -> 2, 4, 6, 8

Console.Clear();
Console.WriteLine("введите число - ");
int F = Convert.ToInt32(Console.ReadLine());
int i;
for (i = 2; i <= F; i = i + 2)
  {
    Console.WriteLine($"{i}", ", ");
  }
   


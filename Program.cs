 
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

//Console.Clear();
//Console.WriteLine("введите трехзначное число -");
//int number = Convert.ToInt32(Console.ReadLine());
//int second = (number % 100 - number % 10) / 10;
//Console.WriteLine(second);


//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

//Console.Clear();
//Console.WriteLine("введите число -");
//string a =  Console.ReadLine();
//if (a.Length >=3)
 //Console.WriteLine(a[2]);
//else
    //Console.WriteLine("нет третьей цифры");

 //   Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
 
 Console.Clear();
Console.WriteLine("введите номер дня -");
int day = Convert.ToInt32(Console.ReadLine());
if (day < 6)
 Console.WriteLine("no");
else
    Console.WriteLine("yes");
 
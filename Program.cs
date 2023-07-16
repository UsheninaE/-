 
//Console.Clear();
//int sum = 0;
//int t = 0;
//int r = 0;
//Console.Write("Введите пятизначное число: ");
//int num = Convert.ToInt32(Console.ReadLine());
//if(num > 9999 && num < 100000)
//{
//for(t=num;num!=0;num=num/10)
//{
//r=num % 10;
//sum=sum*10+r;
//}
//if(t==sum)
//Console.Write($"{t} является палиндромом");
//else
//Console.Write($"{t} не является палиндромом");
//}
//else
//Console.Write("Введите пятизначное число! ");

//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.WriteLine("Введите координаты точки А");
int xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки А");
int yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки А");
int zA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B");
int xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B");
int yB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B");
int zB = Convert.ToInt32(Console.ReadLine());
double distans = Math.Sqrt(Math.Pow(xA - xB, 2)+Math.Pow(yA - yB, 2)+Math.Pow(zA - zB, 2));
Console.WriteLine(Math.Round(distans, 2));

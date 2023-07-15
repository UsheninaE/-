 
Console.Clear();
int sum = 0;
int t = 0;
int r = 0;
Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num > 9999 && num < 100000)
{
for(t=num;num!=0;num=num/10)
{
r=num % 10;
sum=sum*10+r;
}
if(t==sum)
Console.Write($"{t} является палиндромом");
else
Console.Write($"{t} не является палиндромом");
}
else
Console.Write("Введите пятизначное число! ");
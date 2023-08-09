//Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
// void ShowNumbers (int n)
//     {
//         Console.Write(n + " ");
//         if (n>1) ShowNumbers(n-1);
//     }
// ShowNumbers(5);

// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int Summa (int N, int M)
//     { 
       
//     if (M == N) return M;                       // Если M=N
//     else if (M < N) return N + Summa(M, N - 1); // Если M<N
//     else return N + Summa(M, N + 1);            // Если M>N
        
//     }
// Console.Write(Summa (15, 1));

// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
int Accerman (int n, int m)
{
 if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Accerman(n - 1, 1);
    else
      return Accerman(n - 1, Accerman(n, m - 1));
}
Console.Write(Accerman(1, 1));
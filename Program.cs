//  Задача 54: Задайте двумерный массив. Напишите программу, которая 
//упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int [,] Create2DArray (int row, int column)
    {
        int[,] createdArray = new int[row,column];
        for (int i=0; i < row; i++)
            for (int j=0; j < column; j++)
            createdArray[i,j] = new Random().Next(0,10);
        return createdArray;
    }

void Print2DArray (int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i,j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine(" ");
    }


void Sort2DArray(int[,] array)
{
    int temp;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int t = 0; t < array.GetLength(1) - 1; t++)
                    if (array[i,t] < array[i,t+1])
                {
                    temp = array[i,t+1];
                    array[i,t+1] = array[i,t];
                    array[i,t] = temp;
                }
}

Console.WriteLine("Input count of rows: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input cont of collumns: ");
int cols1 = Convert.ToInt32(Console.ReadLine());

int[,] arrayTask54 = Create2DArray(rows1,cols1);
Print2DArray(arrayTask54);
Sort2DArray(arrayTask54);
Print2DArray(arrayTask54);


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void MinSumRow (int[,] array)
{
    int[] minSumArr = new int [array.GetLength(0)];
    int sum;
    for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum +=array[i,j];
                }
            minSumArr[i] = sum;
        }
    for (int i = 0; i < minSumArr.Length; i++)
        Console.Write(minSumArr[i] + " ");
int minimumRow = minSumArr[0];
int minRow = 1;
for (int v = 0; v < minSumArr.Length; v ++)
{
    if (minSumArr[v] < minimumRow)
        {
            minimumRow = minSumArr[v];
            minRow = v+1;
        }
}
Console.WriteLine(minRow);
}

Console.WriteLine("Input count of rows: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input cont of collumns: ");
int cols1 = Convert.ToInt32(Console.ReadLine());

int[,] arrayTask56 = Create2DArray(rows1,cols1);
Print2DArray(arrayTask56);
MinSumRow(arrayTask56);

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int [,] DoubleMatrix (int[,] array1, int[,] array2)
    {
        int[,] finalMatrix = new int[array1.GetLength(0), array2.GetLength(1)];
        for (int i = 0; i < array1.GetLength(0); i++)
            for (int j = 0; j < array2.GetLength(1); j++)
                for (int w = 0; w < array2.GetLength(0); w++)
                finalMatrix[i,j] += array1[i,w]*array2[w,j];
        return finalMatrix;
    }

Console.WriteLine("Input count of rows: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input cont of collumns: ");
int cols1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input count of rows: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input cont of collumns: ");
int cols2 = Convert.ToInt32(Console.ReadLine());

if (cols1 != rows2)
    Console.WriteLine("Количество столбцов первой матрицы не равно количеству строк во второй матрице");

int[,] arrayTask58_1 = Create2DArray(rows1,cols1);
Print2DArray(arrayTask58_1);
int[,] arrayTask58_2 = Create2DArray(rows2,cols2);
Print2DArray(arrayTask58_2);
int[,] resultMatrix = DoubleMatrix(arrayTask58_1, arrayTask58_2);
Print2DArray(resultMatrix);


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
//которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int [,,] FillArray (int x, int y, int z)
{
    int [,,] array3D = new int [x,y,z];
    int tempSize = x*y*z;
    if (tempSize <= 90)
    {
    int [] tempArr =  UniqueArray(tempSize);
    int iTemp = 0;

    for (int i = 0; i < x; i++)
        for (int j = 0; j < y; j ++)
            for (int k = 0; k < z; k ++)
                if (iTemp >= 0 && iTemp < tempSize)
                {
                    array3D[i,j,k] = tempArr [iTemp];
                    iTemp++;
                }
    }
    return array3D;
}
void Print3DArray (int[,,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2); k++)
                {
                Console.Write($"{array[i,j,k]} ({i},{j},{k} )");
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine(" ");
    }

int [] UniqueArray (int size)
{
    int [] uniqArr = new int [size];
    for (n = 0; n < size; n++)
        uniqArr [n] = new Random().Next(10,100)
        if (n != 0)
        {
            for (int r = 0; r < i; r ++)
                while (uniqArr[r] == uniqArr[i])
                uniqArr [r] = new Random().Next(10,100);           
        }
return uniqArr;
}


int [,,] arrayTask60 = FillArray(2,2,2);
Print3DArray(arrayTask60);

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int n = 4;
int[,] sqareMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
  sqareMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(sqareMatrix);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}

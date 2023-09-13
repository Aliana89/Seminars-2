
////Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18
int Prompt(string message)
{
  Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int[,] CreateArray(int m, int n)
{
  int[,] array = new int[m, n];
  return array;
}

void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
  }
}

int[,] FillArrayRandom(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1, 10);
    }
  }
  return array;
}

int[,] MultiplyArray(int[,] firstArr, int[,] secondArr)
{
  int newRow, newCol;
  if (firstArr.GetLength(0) > secondArr.GetLength(0))
  {
    newRow = secondArr.GetLength(0);
  }
  else
  {
    newRow = firstArr.GetLength(0);
  }
  if (firstArr.GetLength(1) > secondArr.GetLength(1))
  {
    newCol = secondArr.GetLength(1);
  }
  else
  {
    newCol = firstArr.GetLength(1);
  }

  int[,] newArray = new int[newRow, newCol];

  for (int i = 0; i < newRow; i++)
  {
    for (int j = 0; j < newCol; j++)
    {
      for (int e = 0; e < newRow; e++)
      {
        newArray[i, j] += firstArr[i, e] * secondArr[e, j];
      }
    }
  }
  return newArray;
}

int[,] firstArr = CreateArray(Prompt("Введите количество строк массива1: "), Prompt("Введите количество столбцов массива1: "));
int[,] secondArr = CreateArray(Prompt("Введите количество строк массива2: "), Prompt("Введите количество столбцов массива2: "));
Console.WriteLine("Первый массив:");
FillArrayRandom(firstArr);
PrintArray(firstArr);
Console.WriteLine("Второй массив:");
FillArrayRandom(secondArr);
PrintArray(secondArr);
Console.WriteLine("Результирующая матрица:");
int[,] newArray = MultiplyArray(firstArr, secondArr);
PrintArray(newArray);
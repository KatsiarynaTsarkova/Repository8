// Программа на вход принимает позицию элемента в двумерном массиве
//и возвращает значение или указание, что элемента нет.
Console.WriteLine(" Введите число: ");
int num = int.Parse(Console.ReadLine());
int[,] matrix = new int[3, 4];
FillArray( matrix);
Console.WriteLine();
PrintArray( matrix);

if (FindNumber(matrix, num))
{
   Console.WriteLine("Число совпадает"); 
}
else{
    Console.WriteLine("Такого числа нет");
}


bool FindNumber(int[,] inArray, int number)
{
    bool result = false;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
       for (int j = 0; j < inArray.GetLength(1); j++)
       {
        if (inArray[i, j]==number)
        {
            result=true;
        }
       } 
    }
    return result;
}
void PrintArray( int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
          Console.Write($"{matr[i, j]} "); 
         
        }
         Console.WriteLine();
    }
   
}

void FillArray( int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
      for (int j = 0; j < matr.GetLength(1); j++)
      {
        matr[i,j]=new Random().Next(1,10);
      }  
    }
}
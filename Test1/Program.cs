// Задайте двумерный массив размером мхn заполненный случайными 
//вещественными числами m=3; n=4.
Console.WriteLine("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());
double[,] matrix = new double[3, 4];
Random random = new Random();
void PrintArray( double[,] matr)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
          Console.Write($"{matr[i, j]} "); 
         
        }
         Console.WriteLine();
    }
   
}
void FillArray( double[,] matr)
{
    for (int i = 0; i < m; i++)
    {
      for (int j = 0; j < n; j++)
      {
        matr[i,j]=Convert.ToDouble(random.Next(-100,100)/10.0);
      }  
    }
}
FillArray( matrix);
Console.WriteLine();
PrintArray( matrix);


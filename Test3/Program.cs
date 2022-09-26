// Расчет среднего арифметического по столбцам заданного массива
int[,] array = new int[,]
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
};
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
PrintArray(array);
    double[] sred = new double[4]; 
    //double sum=0; 
    //double avg = 0;
    for (int j = 0; j < 4; j++)
            {
              double sum=0; 
              double avg = 0;

                for (int i = 0; i < 3; i++)
                {
                   sum += array[i, j]; //сумма эл-тов
                  
                }
                avg = sum / 3; // (сумма/число строк)
                sred[j] = avg; // среднее арифм для j столбца
            }  
   Console.WriteLine("average: ");
            for (int j = 0; j < 4; j++) // цикл по столбцам
              { 
                Console.Write($"{sred[j]}  ");
               } // Вывод среднего арифм каждого столбца

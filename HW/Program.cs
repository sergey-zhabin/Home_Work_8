//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.WriteLine();
 void Zadacha54()
{
    Random random = new Random();
    int rows = random.Next(2,7);
    int colums = random.Next(3,7);
    
    int [,] array = new int [ rows, colums]; 
    
    FillArray(array);
    PrintArray(array); 
    NewArray(array);
    Console.WriteLine();
    Console.WriteLine("Вывод отсортированного массива");
    Console.WriteLine();
    PrintArray(array);
    void NewArray(int [,] array)
    {
    
    for ( int i =0; i < rows ; i++)
    {       
           
        for (int j =0; j < colums; j++)
        for (int k =0; k < colums-j-1; k++)
        {
            int temp = 0;
            if (array[i,k]< array[i,k+1] )
            {
                temp = array[i,k];
                array[i,k]=array[i,k+1];
                array[i,k+1] =temp;
            }            
                 
        }
            
    }
    }


void FillArray(int [,] array)
{
    Random random = new Random();
    int rows =array.GetLength(0);
    int colums = array.GetLength(1);
    for ( int i =0; i < rows; i++)
    {
        for (int j =0; j < colums; j++)
        {
             (array[i, j]) = random.Next(0,10); 
        }
            
    }
}

void PrintArray(int [,] array)
{
    int rows =array.GetLength(0);
    int colums = array.GetLength(1);
        for ( int i =0; i < rows; i++)
    {
        for (int j =0; j < colums; j++)
        {
             Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();   
    }
}
}
//Zadacha54();

//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine();
 void Zadacha56()
{
    Random random = new Random();
    int rows = random.Next(2,7);
    int colums = random.Next(3,7);
    
    int [,] array = new int [ rows, colums]; 
    
    FillArray(array);
    PrintArray(array); 
    SumMetod(array);
    Console.WriteLine();
   
    void SumMetod(int [,] array)
    {
        int minSum =0; 
        int minSumIndex =0; 
        for ( int j =0; j < colums ; j++)
    {     
        minSum = minSum + array[0,j];         
    }   
    Console.WriteLine( $"Сумма 1 -й строки равна : {minSum}");
        for ( int i =1; i < rows; i++)
    {
        int sum =0;
        for (int j =0; j < colums; j++)
        {
            sum = sum + array[i,j];             
        }
        Console.WriteLine($"Сумма {i+1} -й строки равна : {sum}");  
        if (sum < minSum)
        {
            minSum= sum; 
            minSumIndex = i;
        }            
    }
    Console.WriteLine($"Минимальная сумма строки равна : {minSum} и это {minSumIndex +1} строка ");       
    }
}    


void FillArray(int [,] array)
{
    Random random = new Random();
    int rows =array.GetLength(0);
    int colums = array.GetLength(1);
    for ( int i =0; i < rows; i++)
    {
        for (int j =0; j < colums; j++)
        {
             (array[i, j]) = random.Next(0,10); 
        }
            
    }
}

void PrintArray(int [,] array)
{
    int rows =array.GetLength(0);
    int colums = array.GetLength(1);
        for ( int i =0; i < rows; i++)
    {
        for (int j =0; j < colums; j++)
        {
             Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();   
    }
}

Zadacha56();





//Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
/*void Zadacha53()
{
    
    int rows =4;
    int colums = 5;
    Random random = new Random();
    int [,] array = new int [ rows, colums]; 
    FillArray(array);
    PrintArray(array); 
    
    ChangeNumber(array);

    PrintArray(array);
}


void FillArray(int [,] array)
{
    Random random = new Random();
    int rows =array.GetLength(0);
    int colums = array.GetLength(1);
    for ( int i =0; i < rows; i++)
    {
        for (int j =0; j < colums; j++)
        {
             (array[i, j]) = random.Next(1,11); 
        }
            
    }
}

void PrintArray(int [,] array)
{
    int rows =array.GetLength(0); 
    int colums = array.GetLength(1);
        for ( int i =0; i < rows; i++)
    {
        for (int j =0; j < colums; j++)
        {
             Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();   
    }
}
void ChangeNumber(int [,] array)
{
    int maxindex =array.GetLength(0)-1 ;
    int colums = array.GetLength(1);
    
    
        for (int j =0; j < colums; j++)
        {
             (array[0, j], array[maxindex,j]) = (array[maxindex,j], array[0,j]);
        }
        Console.WriteLine();
       
}   
Zadacha53();*/
// Задайте двумерный массив. Напишите программу,которая заменяет строки на столбцы. В случае, если это
//невозможно, программа должна вывести сообщение для пользователя.
/*void Zadacha55()
{
    
    int rows =4;
    int colums = 4;
    Random random = new Random();
    int [,] array = new int [ rows, colums]; 
    FillArray(array);
    PrintArray(array); 
    
    ChangeNumber(array);
    Console.WriteLine();
    PrintArray(array);
}


void FillArray(int [,] array)
{
    Random random = new Random();
    int rows =array.GetLength(0);
    int colums = array.GetLength(1);
    for ( int i =0; i < rows; i++)
    {
        for (int j =0; j < colums; j++)
        {
             (array[i, j]) = random.Next(1,11); 
        }
            
    }
}

void PrintArray(int [,] array)
{
    int rows =array.GetLength(0);
    int colums = array.GetLength(1);
        for ( int i =0; i < rows; i++)
    {
        for (int j =0; j < colums; j++)
        {
             Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();   
    }
}
void ChangeNumber(int [,] array)
{
    int rows =array.GetLength(0) ;
    int colums = array.GetLength(1);
    if (rows == colums)
    for ( int i =0; i < colums; i++)
    {    
        for (int j =i; j < rows; j++)
        {
            
            {
             (array[i, j],array[j,i]) = (array[j,i],array[i, j]);
            }
            
            
        }
        
    }   
    else Console.WriteLine("Заменить невозможно");
}   
Zadacha55();*/
//Составить частотный словарь элементов двумерного массива. Частотный словарь содержит
//информацию о том, сколько раз встречается элемент входных данных.
/*void Zadacha57()
{
    Random random = new Random();
    int rows = random.Next(2,6);
    int colums = random.Next(3,5);
    
    int [,] array = new int [ rows, colums]; 
    int[] dictionary = new int [10];
    FillArray(array);
    PrintArray(array); 
    for ( int i =0; i < rows; i++)
    {
        for (int j =0; j < colums; j++)
        {
            dictionary[array[i,j]]++; 
        }
            
    }
    Console.WriteLine();
    for ( int i =0; i < dictionary.Length; i++) 
    {
        
    if (dictionary[i] !=0) Console.WriteLine($"Элемент {i} встречается {dictionary[i]} раз");
    }
    
}


void FillArray(int [,] array)
{
    Random random = new Random();
    int rows =array.GetLength(0);
    int colums = array.GetLength(1);
    for ( int i =0; i < rows; i++)
    {
        for (int j =0; j < colums; j++)
        {
             (array[i, j]) = random.Next(1,10); 
        }
            
    }
}

void PrintArray(int [,] array)
{
    int rows =array.GetLength(0);
    int colums = array.GetLength(1);
        for ( int i =0; i < rows; i++)
    {
        for (int j =0; j < colums; j++)
        {
             Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();   
    }
}
Zadacha57();*/

/*void Zadacha59()
{
    Random random = new Random();
    int rows = random.Next(2,7);
    int colums = random.Next(3,7);
    
    int [,] array = new int [ rows, colums]; 
    
    FillArray(array);
    PrintArray(array); 
    int min = array[0,0];
    int i_min=0;
    int j_min=0;
    for ( int i =0; i < rows; i++)
    {
        for (int j =0; j < colums; j++)
        {
            if ( array[i,j] < min)
            { 
                 min =array[i,j];
                 i_min = i;
                 j_min = j;
            }     
        }
            
    }
    Console.WriteLine($"Минимальный элемент находится на позиции {i_min}, {j_min} и равен: {min} ");
 
    int[,] newArray = new int [rows -1 , colums -1];
    int bias_i =0;
    for ( int i =0; i < rows -1; i++)
    {
        if (i == i_min) bias_i++;
        int bias_j = 0;
        for (int j =0; j < colums-1 ; j++)
        {
            if ( j == j_min) bias_j++;
            newArray[i, j] = array [i+bias_i, j+bias_j];            
                 
        }
            
    }
    Console.WriteLine("Вывод итгового массива ");
    PrintArray(newArray);
}


void FillArray(int [,] array)
{
    Random random = new Random();
    int rows =array.GetLength(0);
    int colums = array.GetLength(1);
    for ( int i =0; i < rows; i++)
    {
        for (int j =0; j < colums; j++)
        {
             (array[i, j]) = random.Next(-10,10); 
        }
            
    }
}

void PrintArray(int [,] array)
{
    int rows =array.GetLength(0);
    int colums = array.GetLength(1);
        for ( int i =0; i < rows; i++)
    {
        for (int j =0; j < colums; j++)
        {
             Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();   
    }
}

Zadacha59();*/

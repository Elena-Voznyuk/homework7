// Задача 47
/*double [,] CreateArray2D (int rows, int columns, int minV, int maxV)
{
    double [,] array = new double [rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
                {
                array[i,j] = Math.Round((new Random().Next(minV, maxV + 1) + new Random().NextDouble()), 1);
                }
        }     
    return array;         
            
}

void PrintArray2D (double [,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            Console.Write(array2D[i,j] + " ");
        }
        Console.WriteLine();
    }        
    Console.WriteLine();
}

Console.WriteLine("Input count of rows to array:");
int userRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input count of columns to array:");
int userColumns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input minimum:");
int minVal = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maximum:");
int maxVal = Convert.ToInt32(Console.ReadLine());
double [,] userArray = CreateArray2D (userRows, userColumns, minVal, maxVal);
PrintArray2D (userArray);*/


// Задача 50

/*int [,] CreatedArray2d ()
{
    Console.WriteLine("Input count of rows:");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input count of columns:");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input minimal value of array:");
    int minV = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input maxmal value of array:");
    int maxV = Convert.ToInt32(Console.ReadLine());
    int [,] array2D = new int [rows, columns];
    {
    for (int i = 0; i < rows; i++)
        {
        for (int j = 0; j < columns; j++)
            array2D [i,j] = new Random().Next(minV,maxV + 1);
        }
    return array2D;    
    }    
}

void ShowArray (int [,] printArray2d)
{
    for (int i = 0; i < printArray2d.GetLength(0); i++)
    {
        for (int j = 0; j < printArray2d.GetLength(1); j++)
        {
            Console.Write(printArray2d[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void CountOfArray (int [,] userArray2D)
{
    Console.WriteLine("Input value of row:");
    int rowVal = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input value of column:");
    int columnVal = Convert.ToInt32(Console.ReadLine());
    if (rowVal < userArray2D.GetLength(0) && columnVal < userArray2D.GetLength(1))
         Console.WriteLine($"Value of array is {userArray2D[rowVal - 1, columnVal - 1]}");
    else
        Console.WriteLine("This element of array doesnot exist!");
}


int [,] userArray2D = CreatedArray2d ();
ShowArray(userArray2D);
CountOfArray(userArray2D);*/

// Задача 52


int [,] CreateArray2D ()
{
Console.WriteLine("Input count of rows:");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input count of columns:");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input minimal value of array:");
    int minV = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input maxmal value of array:");
    int maxV = Convert.ToInt32(Console.ReadLine());
    int [,] array2D = new int [rows, columns];
    {
    for (int i = 0; i < rows; i++)
        {
        for (int j = 0; j < columns; j++)
            array2D [i,j] = new Random().Next(minV,maxV + 1);
        }
    return array2D;    
    }    
}

void ShowArray (int [,] printArray2d)
{
    for (int i = 0; i < printArray2d.GetLength(0); i++)
    {
        for (int j = 0; j < printArray2d.GetLength(1); j++)
        {
            Console.Write(printArray2d[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void AverageOfColumns (int [,] array2D)
{


    for (int j = 0; j < array2D.GetLength(1); j++)
    {  
    double result = 0;    
        for (int i = 0; i < array2D.GetLength(0); i++)
            {
            result += array2D[i,j];
            } 
    double average = Math.Round((result / array2D.GetLength(0)), 1);
    Console.Write($"{average} ");
    }
     
      
}


int [,] userArray = CreateArray2D();
ShowArray(userArray);
AverageOfColumns(userArray);

// Массив, заполненный случайными положительными 3-ех значными числами.
// Написать программу, которая покажет количество четных чисел в массиве.
/*void FillArr(int [] array)                       // заполнение массива       
{
    int index = 0;
    while (index < array.Length)                        
    {                                                   
        array[index] = new Random().Next(100, 1000);
        index++;                                          
    }
}

void PrintArr(int [] array1)                        // вывод массива на экран                
{
    int count = array1.Length;                           
    int pos = 0;                                         
    while (pos < count)                                  
    {                                                    
        Console.Write($"{array1[pos]} ");  
        pos++;                                          
    }
}

void SumEven (int[]array)                                  
{
    int count = 0;                                   
    int sum = 0;                                                                       
    while (count < array.Length)                        
    {
        if (array[count] %2 == 0)                           
        {
            sum = sum + (array[count]);                  
        }
        count++;
    }
    Console.WriteLine($"Сумма положительных чисел = {sum}");
}


int []arr = new int [10];
FillArr(arr);
PrintArr(arr);
Console.WriteLine();
SumEven(arr);*/

// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечетных позициях.
/*void FillArr(int [] array)                       // заполнение массива       
{
    int index = 0;
    while (index < array.Length)                        
    {                                                   
        array[index] = new Random().Next(1, 10);
        index++;                                          
    }
}

void PrintArr(int [] array1)                        // вывод массива на экран                
{
    int count = array1.Length;                           
    int pos = 0;                                         
    while (pos < count)                                  
    {                                                    
        Console.Write($"{array1[pos]} ");  
        pos++;                                          
    }
}

void SumIndexOdd (int[]array)                                  
{
    int index = 0;                                   
    int sum = 0;                                                                       
    while (index < array.Length)                        
    {
        if (index %2 != 0)                           
        {
            sum = sum + (array[index]);                  
        }
        index++;
    }
    Console.WriteLine($"Сумма чисел с нечетной позицией = {sum}");
}


int []arr = new int [10];
FillArr(arr);
PrintArr(arr);
Console.WriteLine();
SumIndexOdd(arr);*/


// Задайте массив вещественных чисел. 
// Найдите разницу между max и min элеметов массива.
/*Console.Clear();
void FillArr(double [] array)                       // заполнение массива       
{
    int index = 0;
    while (index < array.Length)                        
    {                                                   
        array[index] = new Random().NextDouble();
        index++;                                          
    }
}

void PrintArr(double [] array1)                        // вывод массива на экран                
{
    int count = array1.Length;                           
    int pos = 0;                                         
    while (pos < count)                                  
    {                                                    
        Console.Write($"{array1[pos]} ");  
        pos++;                                          
    }
}

void Difference (double [] array)                                  
{
    int index = 0;                                   
    double dif = 0; 
    double Min = array[0];
    double Max = array[0];
    while (index < array.Length)                        
    {
        if (array[index] > Max)                           
        {
             Max = array[index];              
        }
        else if (array[index] < Min)
        {
            Min = array[index];
        }
        index++;
    }
    Console.WriteLine($"Максимальный элемент массива = {Math.Round(Max, 2)}");
    Console.WriteLine($"Минимальный элемент массива = {Math.Round(Min, 2)}");
    dif = Max - Min;
    Console.WriteLine($"Разница между max и min элементом = {Math.Round(dif, 2)}");
}


double []arr = new double [10];
FillArr(arr);
PrintArr(arr);
Console.WriteLine();
Difference(arr);*/


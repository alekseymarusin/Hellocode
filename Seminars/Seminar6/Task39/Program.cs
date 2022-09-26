// Напишите программу, которая перевернёт одномерный массив 
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int n = 10;

void PrintArray( int[] arr)
    {
    for( int i = 0; i < n; i++)
        {    
        if (i!=arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.WriteLine($"{arr[i]}");
        }
    }
int [] numbers = new int[n];
for(int i = 0; i < n; i++)
    {
        numbers[i] = new Random().Next(0,100);
    }
PrintArray(numbers);
Console.WriteLine();
int buf;
for(int i = 0; i < n/2; i++)
    {
        buf = numbers[i];
        numbers[i] = numbers[n - 1 - i];
        numbers[n-1-i] = buf;
    }
PrintArray(numbers);

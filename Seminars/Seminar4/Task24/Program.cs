int[] array = {5,6,7,99,11,100,55,4};
//foreach (int i in array) Console.Write($"{i}, ");
for (int i = 0; i < array.Lenght; i++)
    {
    Console.Write($"{array[i]}, ");
    }
Console.WriteLine();
array[3] = 777;
Console.WriteLine("Выдергиваю число 99 " + array[3]/11);

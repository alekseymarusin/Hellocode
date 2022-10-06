//Задание - 1 уровень - найти максимальное число и его индекс, 
//найти минимальное число и его индекс, найти среднее арифметическое всех элементов массива

int[] FindMinMaxAvg(int[] array)
{
    int minIndex = 0;
    int maxIndex = 0;
    int min = array[0];
    int max = array[0];
    int sum = 0;
    int[] result = new int[5];

    for (int i=0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            minIndex = i;
        }
        else if (max < array[i])
        {
            max = array[i];
            maxIndex = i;
        }

        sum = sum + array[i];
    }
    //Console.Write($"min: {min}; min index: {minIndex }; max: {max}; max index: {maxIndex}; avg: {sum/array.Length}");

    result[0] = min;
    result[1] = max;
    result[2] = minIndex;
    result[3] = maxIndex;
    result[4] = sum/array.Length;

    return result;
}



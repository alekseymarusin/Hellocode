// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


Console.Write("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int [] array = new int [N];
for (int i = 0; i < N; ++i)
    array [i] = new Random().Next(1,10);

Console.Write("Наш сгенерированный массив: [");

for (int i = 0; i < N - 1; ++i)
    Console.Write(array[i] + " ");

Console.WriteLine(array[N - 1] + "]");

int[] result = new int[N / 2 + N % 2];

for (int i = 0; i < array.Length / 2; ++i)
    result[i] = array[i] * array[array.Length - 1 - i];

if (array.Length % 2 == 1)
    result[array.Length / 2] = array[array.Length / 2];

for(int i = 0; i < result.Length - 1; ++i)
    Console.Write(result[i] + " ");

Console.WriteLine(result[result.Length - 1]);

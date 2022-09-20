// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3 7 22 2 78] -> 76

Console.Write("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
double [] array = new double [N];
for (int i = 0; i < N; ++i)
    array [i] = new Random().Next(-1000,1000);

Console.Write("Наш сгенерированный массив: [");

for (int i = 0; i < N - 1; ++i)
    Console.Write(array[i] + " ");

Console.WriteLine(array[N - 1] + "]");

double max = 0, min = 0;
for (int i = 0; i < N; i++)
{
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
}

double difference = max - min;

Console.WriteLine("Разница между максимальным и минимальным значением данного массива равна " + difference);



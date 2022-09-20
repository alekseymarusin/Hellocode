// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int [] array = new int [N];
for (int i = 0; i < N; ++i)
    array [i] = new Random().Next(-100,100);

Console.Write("Наш сгенерированный массив: [");
for (int i = 0; i < N - 1; ++i)
    Console.Write(array[i] + " ");

Console.WriteLine(array[N - 1] + "]");

int Summa = 0;
for (int i = 0; i < N; i = i + 2)
    Summa = Summa + array[i];

Console.WriteLine("Сумма элементов, стоящих на нечетных позициях равна: " + Summa);

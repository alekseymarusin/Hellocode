//Задача 32: Напишите программу замена элементов массива: 
//положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]


Console.WriteLine("Задайте число элементов массива");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = new int [n];

for (int i = 0; i < n; i++)
{
    array [i] = new Random().Next (-100, 101);
    Console.Write($"{array[i]}, ");
}
Console.WriteLine(" - это изначальный массив");
for (int i = 0; i < n; i++ )
{
    array [i] = array [i] * -1;
    Console.Write($"{array[i]}, ");
};
Console.WriteLine(" - это массив с инвертированными элементами");


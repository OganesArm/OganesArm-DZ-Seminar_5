//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
Console.Clear();
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
int[] Array = GetArray(1000, 0, 1000);
int res = 0;
for (int i = 0; i < Array.Length; i++)
{
    if (Array[i] % 2 == 0)
        res = res + 1;
}
Console.Write("Количество чисел на четных позициях: " + res);
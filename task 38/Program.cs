//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным 
//и минимальным элементов массива.
//[3 7 22 2 78] -> 76

Console.Clear();
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{res[i]} ");

    }
    return res;
}
int[] Array = GetArray(5, 0, 10);

int min = Array[0]; int max = Array[0];
for (int i = 0; i < Array.Length; i++)
{
    if (max < Array[i])
    {
        max = Array[i];
    }
    if (min > Array[i])
    {
        min = Array[i];
    }
}
Console.Write("\nМинимальное число: " + min + "\nМаксимальное число: " + max + "\nРазница между числами: " + (max - min));

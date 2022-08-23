/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

int[] numbers = new int [5];
int count = 0;
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(100, 999);
    if ((numbers[i] % 2) == 0)
    {
        count++;
    }
}
Console.WriteLine(count);
Console.WriteLine("[{0}]", string.Join(", ", numbers));


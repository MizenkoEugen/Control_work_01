// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

int n = 3;
string[] input = FirstArray();
string[] output = ResultArray(input, n);
Console.WriteLine($"[{string.Join(", ", input)}] -> [{string.Join(", ", output)}]");

string[] FirstArray()
{
    Console.Write("Введите значения через пробел: ");
    return Console.ReadLine().Split(" ");
}

string[] ResultArray(string[] input, int n)
{
    string[] output = new string[Count(input, n)];
    for (int i = 0, j = 0; i < input.Length; i++)
    {
        if (input[i].Length <= n)
        {
            output[j] = input[i];
            j++;
        }
    }
    return output;
}

int Count(string[] input, int n)
{
    int count = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i].Length <= n)
        {
            count++;
        }
    }
    return count;
}

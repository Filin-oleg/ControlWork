// Написать программу, которая из имеющегося массива строк формирует массив из строк,
//длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести 
//с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.

Console.Clear();
string[] arrayA = new string[5] { "hello", "2", "world", ":-)", "Russia" };
string[] arrayB = new string[arrayA.Length];
void NewArray3SymbolsMax(string[] arrayA, string[] arrayB)
{
    int count = 0;
    for (int i = 0; i < arrayA.Length; i++)
    {
        if (arrayA[i].Length <= 3)
        {
            arrayB[count] = arrayA[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
NewArray3SymbolsMax(arrayA, arrayB);
PrintArray(arrayB);
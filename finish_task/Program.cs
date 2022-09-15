
// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символам.

Console.Clear();

Console.Write($"Задайте массив, вводя данные через запятую: ");
string info = Console.ReadLine();
string[] arr = info.Split(',').ToArray();

Console.Write($"[{string.Join(" ", arr)}] -> ");
GetArray(arr);


void GetArray(string[] array)
{
    Console.Write("[");
    string[] array2 = new string[array.Length];
    for (int i = 0; i < array2.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Console.Write($"{array[i]} ");
        }
    }
    Console.WriteLine("]");
}
 
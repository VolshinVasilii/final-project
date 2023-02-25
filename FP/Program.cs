
// Написать программу, которая 
//из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равно 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

Console.Write("Введите количество элементов в массиве: ");
int elementsCount = Convert.ToInt32(Console.ReadLine());

string[] array = new string[elementsCount];

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите {i + 1} элемент массива: ");
    array[i] = Console.ReadLine();
}

string[] result = LessThenFourElements(array);

PrintArray(array);
Console.Write(" -> ");
PrintArray(result);


string[] LessThenFourElements(string[] arr)
{
    int index = 0;
    string[] newArr = new string[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (arr[i].Length <= 3 && arr[i].Length > 0)
        {
            newArr[index] = arr[i];
            index++;
        }
    }

    string[] resultArr = new string[index];
    for (int i = 0; i < resultArr.GetLength(0); i++)
    {
        resultArr[i] = newArr[i];
    }
    return resultArr;
}

void PrintArray(string[] arr)
{
    Console.Write('[');
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"\"{arr[i]}\"" + ", ");
        else Console.Write($"\"{arr[i]}\"");
    }
    Console.Write("]");
}
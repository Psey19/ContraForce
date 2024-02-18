// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести 
// с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


// Вариант с заданием массива строк через консоль (с клавиатуры):
// Console.Write("Enter count of strings:");
// int size = Int32.Parse(Console.ReadLine());
// string[] Array = new string[size];
// Console.WriteLine("Enter array: ");
// for (int i = 0; i < Array.Length; i++)
// {
//     Console.Write("Array[{0}] = ", i);
//     Array[i] = Console.ReadLine();
// }

// Console.Write("Your Array is: ");
// string str = string.Join(", ", Array);
// Console.WriteLine($"[{str}]");


// Вариант с заданием массива строк на старте:
string[] Array = { "Hello", "my", "girlfriends", "35", "cat",".йо" };
string str = string.Join(", ", Array);
Console.WriteLine($"Your Array is: [{str}]");

int FindSize2(string[] Array)
{
    int size2 = 0;
    for (int i = 0; i < Array.Length; i++)
    {

        if (Array[i].Length < 4)
        {
            size2++;
        }

    }
    return size2;
}

int size2 = FindSize2(Array);



string[] CreateNewArray(string[] Array)
{
    string temp = "";
    string[] NewArray = new string[size2];
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i].Length < 4)
        {
            for (int j = 0; j < size2; j++)
            {
                temp = NewArray[size2-1-j];
                NewArray[size2-1-j] = Array[i];
                Array[i] = temp;
            }
        }
    }
    return NewArray;
}

string[] NewArray = CreateNewArray(Array);
string str2 = string.Join(", ", NewArray);
Console.WriteLine($"Finished Array is: [{str2}]");



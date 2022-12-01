/*
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых 
меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
выполнения алгоритма.

Примеры: 
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []
*/

string[] text = {"hello", "2", "world", ":-)"};

WriteArray(text, "Исходный массив:");
Console.WriteLine();

int sizeNewArray = 0;

for (int i = 0; i < text.Length; i++)
{
    string temp = text[i];

    int size = temp.Length;

    if (size <= 3)
        sizeNewArray++;
}

string[] newText = new string[sizeNewArray];

int j = 0;

for (int i = 0; i < text.Length; i++)
{
    string temp = text[i];

    int size = temp.Length;

    if (size <= 3)
        {
            newText[j] = temp;
            j++;
        }
}

WriteArray(newText, "Получившийся массив:");


void WriteArray(string[] array, string message)
{
    Console.WriteLine(message);
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
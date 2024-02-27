//  Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

void Main()
{
    string stringIsArrayOfChars = "dlrow olleH";
    printReverseString(stringIsArrayOfChars, 0);
}

void printReverseString(string str, int index)
{
    if(index > str.Length -1) return;
    printReverseString(str, index + 1);
    System.Console.Write(str[index] + " ");
}

Main();
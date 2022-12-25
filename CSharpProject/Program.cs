Console.WriteLine("Введите несколько строк," +
                "\nнажмите ENTER, чтобы закончить ввод текущей строки и начать вводить следующую," +
                "\nвведите слово stop, чтобы закончить:");
string[] stringArray = Array.Empty<string>();
string nextLine = Console.ReadLine();
while (nextLine != "stop")
{
    Array.Resize(ref stringArray, stringArray.Length + 1);
    stringArray[^1] = nextLine;
    nextLine = Console.ReadLine();
}
Console.WriteLine("Массив введенных Вами строк:");
PrintStringArray(stringArray);
Console.WriteLine("Массив строк длины не больше 3 символов:");
PrintStringArray(RemoveLongStrings(stringArray));
//----------------ФУНКЦИЯ-ВЫВОД-МАССИВА-НА-ЭКРАН------------------------------
void PrintStringArray(string[] stringArray)
{
    if (stringArray.Length == 0) System.Console.WriteLine("[]");
    else
    {
        Console.Write("[");
        for (int i = 0; i < stringArray.Length - 1; i++)
        {
            Console.Write("\"" + stringArray[i] + "\"" + ", ");
        }
        Console.WriteLine("\"" + stringArray[^1] + "\"" + "]");
    }
}
//----------ФУНКЦИЯ-ВОЗВРАЩАЮЩАЯ-МАССИВ-СТРОК-ДАННОГО-МАССИВА-НЕ-ДЛИННЕЕ-ТРЕХ-СИМВОЛОВ----
string[] RemoveLongStrings(string[] stringArray)
{
    string[] newStringArray = Array.Empty<string>();
    if (stringArray.Length == 0) return newStringArray;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
        {
            Array.Resize(ref newStringArray, newStringArray.Length + 1);
            newStringArray[^1] = stringArray[i];
        }
    }
    return newStringArray;
}


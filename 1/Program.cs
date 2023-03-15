Console.Clear();

string[] StringArray(int max, int min)
{
    int L = new Random().Next(min, max);
    string[] array = new string[L];

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите любую строку: ");
        array[i] = Console.ReadLine()!;
    }

    return array;

}

string[] NewArray(string[] inarray)
{
    string[] result = new string[inarray.Length];

    int j = 0;

    for (int i = 0; i < inarray.Length; i++)
    {

        if (inarray[i].Length <= 3)
        {
            result[j] = inarray[i];
        }
        j++;
    }

    return result;
}


Console.Write("Введите max число:  ");
int Max = int.Parse(Console.ReadLine()!);
Console.Write("Введите min число:  ");
int Min = int.Parse(Console.ReadLine()!);

string[] arraystring = StringArray(Max, Min);
string[] newarraystring = NewArray(arraystring);

Console.WriteLine(String.Join(", ", newarraystring));
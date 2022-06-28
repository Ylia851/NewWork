/*	Задача. Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []
*/

string[] CreateArray()
{
    int length = new Random().Next(0, 10);
    Console.Write($"{length} ");
	string[] array = new string[length];
	return array;
}

string[] CreateArrayfromKeybord()
{
	Console.WriteLine("Введите количество n элементов массива: ");
	int leng = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите n элементов массива: ");
    string[] arrOfKeybord = new string[leng];
    return arrOfKeybord;

}

void PrintArray(string[] array)
{
    Console.Write($"[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"'{array[i]}'");
        if (i < array.Length - 1)
        {
            Console.Write($", ");
        }
    }
    Console.Write($"]");
}

int StringAmoundLess3Symbols(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

string[] NumberOfStringLess3Simb(string[] array, int count)
{
    string[] arrayOfStringsLess3Symbols = new string[count];
    int n = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            arrayOfStringsLess3Symbols[n] = array[i];
            n++;
        }
    }
    return arrayOfStringsLess3Symbols;
}



Console.WriteLine("Хотите ли вы ввести массив с клавиатуры? Если да, нажмите +");
string answer = Console.ReadLine();
if(answer == "+")
{
	string[] arr = CreateArrayfromKeybord();	
	int num = StringAmoundLess3Symbols(arr);
	string[] MyArr = NumberOfStringLess3Simb(arr, num);
	PrintArray(MyArr);
}
else
{
	string[] newArr = CreateArray();
	PrintArray(newArr);
	int num = StringAmoundLess3Symbols(newArr);
	string[] MyArr1 = NumberOfStringLess3Simb(newArr, num);
	PrintArray(MyArr1);
}

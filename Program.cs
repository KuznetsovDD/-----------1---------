
System.Console.WriteLine("Введите значения массива через пробел: ");
string str = Console.ReadLine()??"";

string[] array = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);


void PrintArray(string[] arr)
{
    for(int i=0; i<arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
}


string[] NewArray(string[] arra)
{
    string[] result = new string[new Random().Next(0,4)];
    if(result.Length == 0)
    {
        System.Console.WriteLine("нет значений");
        return result;
    }
    else
    {
    for(int i=0; i< result.Length; i++)
    {
       result[i] = arra[new Random().Next(0, arra.Length)];
    }
    return result;
    }
}

string[] ar =   NewArray(array);
PrintArray(ar);




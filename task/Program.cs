//Написать программу, которая из имеющегося массива строк
// формирует массив из строк, длина которых меньше или равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями.


// Метод читает данные от пользователя
string ReadData(string msg)
{
    Console.WriteLine(msg);
    string? data = Console.ReadLine();
    if (data == null) {
        data = "";
    }
    return data;
}

//заполняем массив
string[] GenArray(string data, string separator)
{
    
   string[] outArray = data.Split(separator);
   return outArray;
}
//метод считает количество элементов массива, длина которых <=3
int GetFinishArrayLength(string[] inputArray, int lineLenght, int size)
{
    int count = 0;
    int i=0;
    while(i<size)
{
    if (inputArray[i].Length<=lineLenght)
    {
       count++;
    }
    i++;
}
return count;
}

// заполняет массив текстом <=3
void FillFinishArray(string[] inputArray, int lineLenght, int size, string[] finishArray)
{
    int indexFinish = 0;
    int i=0;
    while(i<size)
{
    if (inputArray[i].Length<=lineLenght)
    {
      finishArray[indexFinish]=inputArray[i];  
      indexFinish++;
    }
    i++;
}
}
//метод печатает массив
void PrintArray(string[] arr) 
{

    if (arr.Length ==0)
    {
        Console.WriteLine("Массив пустой []");
        return;
    }
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.Write(arr[arr.Length - 1] + "]");
    Console.WriteLine();
}



// задаем стартовые параметры
string data = ReadData("Введите текст, где разделителем будет ',':");
string[] inputArray = GenArray(data,",");
int lineLenght = 3;
int size = inputArray.Length;  
string[] finishArray = new string[GetFinishArrayLength(inputArray, lineLenght, size)];
FillFinishArray(inputArray,lineLenght,size,finishArray);
PrintArray(inputArray);
PrintArray(finishArray);
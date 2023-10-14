// // // Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// //  длина которых меньше, либо равна 3 символам. 
// //  Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// //  При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// // Примеры:
// // [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// // [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// // [“Russia”, “Denmark”, “Kazan”] → []

Console.Clear();
string[] InitialArrayOfStrings()
{
    Console.WriteLine("Введите количество элементов");
    int size = int.Parse(Console.ReadLine());
    string[] stringArray = new string[size];
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.WriteLine($"Введите элементы которые будут в массиве {i + 1}: ");
        stringArray[i] = Console.ReadLine();
    }
    return stringArray;
}


string[] FilterArrayOfStrings(string[] stringArray)
{
    int newSize = 0; 
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
        {
            newSize++; 
        }
    }

    string[] resultArray = new string[newSize]; 

    int resultIndex = 0; 
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
        {
            resultArray[resultIndex] = stringArray[i]; 
            resultIndex++;
        }
    }
    return resultArray;
}





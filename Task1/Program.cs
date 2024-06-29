// Задача: 
// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] arrCount1 = new string[5] {"one", "two", "three", "four", "five"};
string[] arrCount2 = new string[arrCount1.Length];



void ArrThreeChar(string[] array1, string[] array2)
{
    int i2 = 0;
    for(int i = 0; i < array1.Length; i++)
    {
        if(array1[i].Length <= 3)
        {
            array2[i2] = array1[i];
            i2++;
        }
    }
}

void PrintResult (string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

ArrThreeChar(arrCount1, arrCount2);
PrintResult(arrCount2);
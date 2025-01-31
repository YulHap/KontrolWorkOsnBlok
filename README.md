# Условие задачи:

Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

# Решение: 
1. Задаю массив строк вручную. Массив называется *arrCount1* и содержит первые пять цифр (на английском языке). 
```sh
string[] arrCount1 = new string[5] {"one", "two", "three", "four", "five"};
```
2. Создаю второй массив строк с названием *arrCount2* с количеством элементов, равным длине первого массива. 

```sh
string[] arrCount2 = new string[arrCount1.Length];
```
3. Создаю функцию *ArrThreeChar*, которая запишет во второй массив строк *arrCount2* только те элементы первого массива, длина которых не превышает 3 символа. В качестве параметров функции передаю два массива с типом данных *string*.

```sh
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
```
4. Создаю новую функцию *PrintResult* для вывода получившегося второго массива. В качестве параметра функции передаю массив с типом данных *string*. 

```sh
void PrintResult (string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}
```

5. Передаю в функцию *ArrThreeChar* (описанную в пункте 3) два массива, описанных в пунктах 1 и 2:
* *arrCount1*
* *arrCount2*
```sh
ArrThreeChar(arrCount1, arrCount2);
```

6. Передаю в фукцию *PrintResult* заполненный второй массив *arrCount2*
```sh
PrintResult(arrCount2);
```
Таким образомб в резултате мы получаем ответ:

*one two*

Программа работает верно, задача решена.
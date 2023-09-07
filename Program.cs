// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
// коллекциями, лучше обойтись исключительно массивами.

void ArrayToFill (string [] array1, string [] array2)
 {
 int count = 0;

 for (int i = 0; i < array1.Length; i++)
    {
    if (array1 [i].Length <= 3)
        {
            array2 [count] = array1 [i];
            count ++;
        }
    }
 }

 void PrintArray (string [] array)
 {
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
 }

string [] array1 = new string [10] {"1230", "Gr", "7890", "ee", "98746", "tin", "gjhrheh", "qwerty", "gs!", "loll"};
string [] array2 = new string [array1.Length];
 
 ArrayToFill(array1, array2);
 PrintArray(array2);
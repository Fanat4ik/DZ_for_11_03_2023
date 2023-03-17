// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

//заполнение массива случайными цифрами (от 100 до 999)
void FillArrayRandomNumbers(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
}
//печать массива в консоль
void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        System.Console.Write(array[i]);
        else
        System.Console.Write(array[i] + ", ");
    }
    System.Console.WriteLine("]");
}

void FindingEvenNumbers(int[] array)
{
    int numberOfEvenNumbers = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] %2 ==0 ) numberOfEvenNumbers +=1;
    }
    System.Console.WriteLine("число чётных чисел в массиве: " + numberOfEvenNumbers);
}

int[] arrey = new int[8];
FillArrayRandomNumbers(arrey);
PrintArray(arrey);
FindingEvenNumbers(arrey);

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

//заполнение массива случайными цифрами [от -20 до 20]
void FillArrayRandomNumbers(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-20, 21);
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

void SumOfOddArrayPositions(int[] array)
{
    int summ = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        summ = summ + array[i];
    }
    System.Console.WriteLine("сумма элементов, стоящих на нечётных позициях: " + summ);
}

int[] arrey = new int[8];
FillArrayRandomNumbers(arrey);
PrintArray(arrey);
SumOfOddArrayPositions(arrey);
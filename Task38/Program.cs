// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

//заполнение массива случайными цифрами [от -99,9 до 99,9]
void FillArrayRandomRealNumbers(double[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = ((double) rnd.Next(-999, 1000))/10;
    }
}

//печать массива в консоль
void PrintDoubleArray(double[] array)
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

void SumOfOddArrayPositions(double[] array)
{
    double maxNumber = 0;
    double minNumber = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (maxNumber < array[i]) maxNumber = array[i];
        if (minNumber > array[i]) minNumber = array[i];
    }
    System.Console.WriteLine("Разница между максимальным и минимальным элементов массива: " + (maxNumber-minNumber));
}

double[] arrayDouble = new double[8];
FillArrayRandomRealNumbers(arrayDouble);
PrintDoubleArray(arrayDouble);
SumOfOddArrayPositions(arrayDouble);
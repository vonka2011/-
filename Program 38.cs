int[] CreatArray(int size, int minValue,int maxValue)
{
    int [] newArray=new int[size];
    for(int i= 0;i < size; i++)
      newArray[i]= new Random().Next(minValue, maxValue +1);
    return newArray;
}
void ShowArray(int[] array)
{
    for(int i =0; i < array.Length;i++ )
    Console.Write(array[i] + " ");
    Console.WriteLine();
}

// задайте массив вещ.чисел.Найдите разницу м\у макс. и мин.элементов массива
int Max(int[] array)
{
    int max = 0;
    for(int i = 0 ;i < array.Length; i++)
    {
        if (array [i] > max)
        max = array [i];
    }
    return max;
}
int Min(int[] array)
{
    int min = array[0];
    for(int i = 0 ;i < array.Length; i++)
    {
        if (array [i] < min)
        min = array [i];
    }
    return min;
}
Console.Write("Введите размер желаемого массива: ");
int size=Convert.ToInt32(Console.ReadLine());
Console.Write("Напишите минимальное число диапазона цифр в массиве: ");
int minValue=Convert.ToInt32(Console.ReadLine());
Console.Write("Напишите максимальное число диапазона цифр в массиве: ");
int maxValue=Convert.ToInt32(Console.ReadLine());
int[] array = CreatArray(size,minValue, maxValue);
 int max = Max(array);
int min = Min(array);
int result= max -min;
ShowArray(array);
Console.Write($"Сумма элементовстоящих на нечетных местах в массиве= {result}");



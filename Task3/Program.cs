//Задача 3: 
//Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

int[] charArray = {1,2,5,0,10,34};
ReversArray(charArray, 0);

void ReversArray(int[] array, int index)
{
    if (index>=array.Length) return;
    {
        ReversArray(array, index+1);
        Console.Write(array[index] + " ");
    }
}

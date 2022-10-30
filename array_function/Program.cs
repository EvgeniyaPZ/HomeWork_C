void FullArray (int[] collection)
{
    int lenth = collection.Length;
    int index =0;

    while (index<lenth)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray (int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position<count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int[13];
int[] array2 = new int[5];

FullArray(array);
PrintArray(array2);
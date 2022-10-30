void FullArray1 (int[] array)
{
    int count = array.Length;
    int index= 0;
    while (index<count);
    {
        array[index]= new Random().Next(10,100);
        index++;
    }
}

void PrintArray1 (int[] arr)
{
    int count =arr.Length;
    int position = 0;
    while (position<count)
    {
        Console.WriteLine(arr[position]);
        position++;
    }
}

int MaxFigure(int max)
{
    
}
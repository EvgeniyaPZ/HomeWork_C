int[] arr = {58,5,8,6,7,1,2,5,4,8,2,44,1,1,1,5};

void PrintArray (int[] array)
{
    int length=array.Length;
    for(int i=0; i<length;i++ )
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
PrintArray(arr);

void ArraySort(int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        int minposition = i;
        //int j=i+1;
        for(int j=i+1; j<array.Length;j++)
        {
            
            if (array[j]<array[minposition]) 
            
                minposition=j;
            
        }   
        int maxposition = array[i];
                array[i]=array[minposition];
                array[minposition]=maxposition;

            

        
    
    }
    
}
ArraySort(arr);

PrintArray(arr);

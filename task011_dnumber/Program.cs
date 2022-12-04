int CommonArray (int minValue, int maxValue)
{
        Random random=new Random();
        int array=random.Next(minValue,maxValue);
    return array;
}
int arr = CommonArray(100,1000);

//Console.WriteLine(arr[5]);
string arr1= arr.ToString();
//string arr2= substing(1,3);
//int arr2= arr%100;
Console.WriteLine(arr1[0]);
Console.WriteLine(arr1[2]);
Console.WriteLine(arr);


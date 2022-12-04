Console.WriteLine("Enter number: ");
bool inParseA= int.TryParse(Console.ReadLine(), out int N);
/*Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28 4 -> 10 8 -> 36*/
if (N==24)
{
    bool task024= int.TryParse(Console.ReadLine(), out int number);
    int SummaNumber (int summa)
    {
        int result=0;
        for (int i=0;i<=summa;i++)
        result=result+i;
    return result;
    }
    Console.WriteLine(SummaNumber(number));
}
/*Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3 78 -> 2 89126 -> 5*/
if (N==26)
{
    bool task026= int.TryParse(Console.ReadLine(), out int number);
    if (!task026)
    {
        Console.WriteLine("error");
    }
    double count = Math.Round(Math.Log10(number)+1);
    Console.WriteLine(count);
}

/*Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4->24 5->120*/

if (N==28)
{
    bool task028= int.TryParse(Console.ReadLine(), out int number);
    int SummaNumber (int summa)
    {
        int result=1;
        for (int i=1;i<=summa;i++)
        result=result*i;
    return result;
    }
    Console.WriteLine(SummaNumber(number));
}

/*Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]*/

if (N==30)
{
      void PrintArray (int [] array)
    {
        Console.Write ("[");
        Console.Write (array[0]);
        for (int i=1;i<array.Length;i++)
        {Console.Write ($", {array[i]}");}
        Console.Write ("]");
    }

    void ArrayMain(int[] array)
    {
        for (int i=0;i<array.Length;i++)
        array[i]=new Random().Next(0,2);
    }
    int[] arr= new int[8];
    ArrayMain(arr);
    PrintArray(arr);
}
  
/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль.

3, 5 -> 243 (3⁵)

2, 4 -> 16*/

if (N==25)
{
    Console.WriteLine("First Number: ");
    bool NumberA = int.TryParse(Console.ReadLine(), out int A);
    Console.WriteLine("Second Number: ");
    bool NumberB = int.TryParse(Console.ReadLine(), out int B);

    int PowNumber (int fn, int sn)
    {
        int result = fn;
        for(int i=1;i<sn;i++)
        {result=result*fn;}
        return result;
    }
    Console.WriteLine(PowNumber(A,B));
}

/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль.

452 -> 11

82 -> 10

9012 -> 12*/

if (N==27)
{
    Console.WriteLine("Enter number: ");
    bool SummNumber= int.TryParse(Console.ReadLine(), out int C);
    
    int NumberSumma (int num)
    {
        int result=0;
        while (num>0)
        {
            result=result+num%10;
            num=num/10;
            
        }
        return result;
    }
    Console.WriteLine(NumberSumma(C));
}
/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
Задание должно быть выполнено в методах.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]*/

if(N==29)
 Console.WriteLine("Enter number: ");
    bool SummNumberN= int.TryParse(Console.ReadLine(), out int n);

{

    int[] EnterNumber(int count)
    {
        int[] array= new int[count];
        for(int i=0; i<array.Length;i++)
        {
            array[i] = int.Parse(Console.ReadLine());
            
        }
        return array;
    }
  void PrintArray (int[] array)
    {
        Console.Write ("[");
        Console.Write (array[0]);
        for (int i=1;i<array.Length;i++)
        {Console.Write ($", {array[i]}");}
        Console.Write ("]");
    }  
    int[] arrayR = new int [n];
    //EnterNumber(n);
    PrintArray(EnterNumber(n));
}

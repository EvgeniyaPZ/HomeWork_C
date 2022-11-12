Console.WriteLine("Enter number: ");

// https://learn.microsoft.com/ru-ru/dotnet/api/system.int32.tryparse?view=net-6.0#system-int32-tryparse(system-string-system-int32@)
//Преобразует строковое представление числа в эквивалентное ему 32-битовое целое число со знаком.
// Возвращает значение, указывающее, успешно ли выполнено преобразование.
bool inParseA= int.TryParse(Console.ReadLine(), out int N);

if (N==11)
{
//S1.1. Вывести на экран число  с точностью до сотых.

bool inParseB= double.TryParse(Console.ReadLine(), out double B);
Console.WriteLine(Math.Round(B,2));
}



//S1.2. Вывести на экран число e (основание натурального логарифма) с точностью до десятых.
if (N==12)
{
Console.WriteLine(Math.Round(Math.Exp(1),1));

}


//S1.3. Составить программу вывода на экран числа, вводимого с клавиатуры.
// Выводимому числу должно предшествовать сообщение «Вы ввели число».
if (N==13)
{
    Console.WriteLine("Вы ввели число");
    bool inParseC= int.TryParse(Console.ReadLine(), out int С);
}

//S1.4. Составить программу вывода на экран числа, вводимого с клавиатуры. 
//После выводимого числа должно следовать сообщение » — вот какое число Вы  ввели».
if (N==14)
{
      bool inParseD= int.TryParse(Console.ReadLine(), out int D);
        Console.WriteLine("— вот какое число Вы  ввели");
   
}

//S1.5. Вывести на одной строке числа 1, 13 и 49 с одним пробелом между ними.
if (N==15)
{
    int A =1;
    int B = 13;
    int C= 49;
    Console.WriteLine($"{A} {B} {C}");
}

//S1.6. Вывести на одной строке числа 7, 15 и 100 с двумя пробелами между ними.
if (N==16)
{
      int A =7;
    int B = 15;
    int C= 100;
    Console.WriteLine($"{A}  {B}  {C}");
}

//S1.7. Составить программу вывода на экран в одну строку трех любых чисел с двумя пробелами между ними.
if (N==17)
{
    Console.WriteLine($"Enter tree digit");
    bool inParseZ= int.TryParse(Console.ReadLine(), out int Z);
    bool inParseV= int.TryParse(Console.ReadLine(), out int V);
    bool inParseT= int.TryParse(Console.ReadLine(), out int T);
      Console.Write($"{Z} ");
      Console.Write($"{V} ");
      Console.Write($"{T}");
}

//S1.8. Составить программу вывода на экран в одну строку четырех любых чисел  с одним пробелом между ними.
if (N==18)
{
       Console.WriteLine($"Enter tree digit");
    bool inParseZ1= int.TryParse(Console.ReadLine(), out int Z1);
    bool inParseV1= int.TryParse(Console.ReadLine(), out int V1);
    bool inParseT1= int.TryParse(Console.ReadLine(), out int T1);
    bool inParseH1= int.TryParse(Console.ReadLine(), out int H1);
      Console.Write($"{Z1} ");
      Console.Write($"{V1} ");
      Console.Write($"{T1} "); 
      Console.Write($"{H1}");
}

//S1.9. Вывести на экран числа 50 и 10 одно под другим.
if (N==19)
{
    int B1 = 50;
    int C1= 10;
    Console.WriteLine(B1);
    Console.WriteLine(C1);

}

// S1.10. Вывести на экран числа 5, 10 и 21 одно под другим.
if (N==110)
{
    int B2 = 5;
    int C2= 10;
    int A1= 21;
    Console.WriteLine(B2);
    Console.WriteLine(C2);
    Console.WriteLine(A1);

}

//S1.11. Составить программу вывода на экран «столбиком» четырех любых чисел
if (N==111)
{
       Console.WriteLine($"Enter tree digit");
    bool inParseZ2= int.TryParse(Console.ReadLine(), out int Z2);
    bool inParseV2= int.TryParse(Console.ReadLine(), out int V2);
    bool inParseT2= int.TryParse(Console.ReadLine(), out int T2);
    bool inParseH2= int.TryParse(Console.ReadLine(), out int H2);
      Console.WriteLine(Z2);
      Console.WriteLine(V2);
      Console.WriteLine(T2); 
      Console.WriteLine(H2);
}

//S1.12. Составить программу вывода на экран следующей информации:
//5 10
//7 см
if (N==112)
{
       Console.WriteLine($"Enter tree digit");
    bool inParseZ3= int.TryParse(Console.ReadLine(), out int Z3);
    bool inParseV3= int.TryParse(Console.ReadLine(), out int V3);
    bool inParseT3= int.TryParse(Console.ReadLine(), out int T3);
    //string inParseY3= string.TryParse(Console.ReadLine(), out string H3);
    string inParseH3 = Console.ReadLine();
      Console.Write($"{Z3} ");
      Console.WriteLine(V3);
      Console.Write($"{T3} "); 
      Console.WriteLine(inParseH3);
}

//S1.13. Составить программу вывода на экран следующей информации:
//2 кг
//13 17
if (N==113)
{
       Console.WriteLine($"Enter tree digit");
    bool inParseZ4= int.TryParse(Console.ReadLine(), out int Z4);
    bool inParseV4= int.TryParse(Console.ReadLine(), out int V4);
    bool inParseT4= int.TryParse(Console.ReadLine(), out int T4);
    //string inParseY3= string.TryParse(Console.ReadLine(), out string H3);
    string inParseH4 = Console.ReadLine();
      Console.Write($"{Z4} ");
    Console.WriteLine(inParseH4);
      Console.Write($"{V4} ");
      Console.WriteLine(T4); 
  
}


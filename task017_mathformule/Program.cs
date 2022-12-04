Console.WriteLine("Enter number: ");

// https://learn.microsoft.com/ru-ru/dotnet/api/system.int32.tryparse?view=net-6.0#system-int32-tryparse(system-string-system-int32@)
//Преобразует строковое представление числа в эквивалентное ему 32-битовое целое число со знаком.
// Возвращает значение, указывающее, успешно ли выполнено преобразование.
bool inParseA= int.TryParse(Console.ReadLine(), out int N);


// S2.1. Составить программу:
//а) вычисления значения функции y=7x2+3x+6 при любом значении x;
//б) вычисления значения функции x=12a2+7a+12 при любом значении а.
if (N==21)
{
    double Summabd1 (int x)
    {
        double result1= 7*Math.Pow(x,2);
        return result1;
    }
     int Summabd2 (int x)
    {
        int result2= 3*x;
        return result2;
    }
    bool inParseX= int.TryParse(Console.ReadLine(), out int x1);
    Console.WriteLine(Summabd1(x1));
    Console.WriteLine(Summabd2(x1));
    Console.WriteLine(Summabd1(x1)+Summabd2(x1)+6);
}

//S2.2. Дана сторона квадрата. Найти его периметр.
if (N==22)
{
    int Cube(int x)
    {
        int result = x*4;
        return result;
    }
    bool inParseX2= int.TryParse(Console.ReadLine(), out int x2);
    Console.WriteLine(Cube(x2));
}

//S2.3. Дан радиус окружности. Найти ее диаметр.
if (N==23)
{
    int Diametr(int x)
    {
        int result = x*2;
        return result;
    }
    bool inParseX3= int.TryParse(Console.ReadLine(), out int x3);
    Console.WriteLine(Diametr(x3));
}

//S2.4. Считая, что Земля — идеальная сфера с радиусом R=6350 км,
// определить расстояние до линии горизонта от точки В с заданной высотой h=AB над Землей.
if (N==24)
{
    double Quadro (int x)
    {
        double result= Math.Pow(x,2);
        return result;
    }
   bool inParseX4= double.TryParse(Console.ReadLine(), out double x4);
   double RTerra=6350;
   Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow((x4+RTerra),2)-Math.Pow(RTerra,2)),3));

}

//S2.5. Дана длина ребра куба. Найти объем куба и площадь его боковой поверхности. 
if (N==25)
{
    double Formule(int x,int y1)
    {
        double result = Math.Pow(x,y1);
        return result;
    }
    bool inParseX5= double.TryParse(Console.ReadLine(), out double x5); 
    int y2= 2;
    int y3=3;
    Console.WriteLine($"Объем куба: {Math.Pow(x5,y3)}. Площадь боковой поверхности: {Math.Pow(x5,y2)}.");
}

// S2.6. Дан радиус окружности. Найти длину окружности и площадь круга.
if (N==26)
{
    double FormuleSurface(int x)
    {
       // double result = Math.Round(Math.PI*Math.Pow(x,2), 3);
        return Math.Round(Math.PI*Math.Pow(x,2), 3);
    }

        double FormuleCircumferenceLength(int x)
    {
        //double result = Math.Round(Math.PI*Math.Pow(x,2), 3);
        return Math.Round(2*Math.PI*x, 3);
    }
    bool inParseX6= int.TryParse(Console.ReadLine(), out int x6); 
    Console.WriteLine($"Длинна окружности: {FormuleCircumferenceLength(x6)}. Площадь круга: {FormuleSurface(x6)}.");
}

//  S2.7. Даны два целых числа. Найти: а) их среднее арифметическое; б) их среднее геометрическое.
if (N==27)
{
    
    Console.WriteLine("Ввести два числа");
    bool inParseX7= int.TryParse(Console.ReadLine(), out int x7); 
    bool inParseX8= int.TryParse(Console.ReadLine(), out int x8); 
    Console.WriteLine($"Среднее арифметическое: {(x7+x8)/2}. Среднее геометрическое: {Math.Round(Math.Sqrt(x7+x8),3)}.");

}

//S2.8. Известны объем и масса тела. Определить плотность материала этого тела.
if (N==28)
{
    
    Console.WriteLine("Ввести массу и объем");
    bool inParseX9= int.TryParse(Console.ReadLine(), out int x9); 
    bool inParseX10= int.TryParse(Console.ReadLine(), out int x10); 
    Console.WriteLine($"Формула плотность = масса/объем. Плотность =  {x9/x10} КГ/М3.");

}

// S2.9. Известны количество жителей в государстве и площадь его территории. 
//Определить плотность населения в этом государстве.
if (N==29)
{
        Console.WriteLine("Ввести количество жителей в государстве и площадь его территории");
    bool inParseX11= int.TryParse(Console.ReadLine(), out int x11); 
    bool inParseX12= int.TryParse(Console.ReadLine(), out int x12); 
    Console.WriteLine($"плотность = площадь/колво. Плотность населения =  {x11/x12}.");
}

//S2.10. Составить программу решения линейного уравнения ax+b=0 (a ≠ 0).
if (N==210)
{
    double LinearEquation (int a, int x, int b)
    {
    return a*x+b;
    }
Console.WriteLine("Ввести х:"); 
bool inParseX13= int.TryParse(Console.ReadLine(), out int x13); 
Console.WriteLine("Ввести a:"); 
bool inParseA3= int.TryParse(Console.ReadLine(), out int a3); 
Console.WriteLine("Ввести b:"); 
bool inParseB2= int.TryParse(Console.ReadLine(), out int b2); 

if (a3!=0)
{
Console.WriteLine($"Решение: {LinearEquation(a3,x13, b2)}");
}
else {Console.WriteLine("а должно быть больше нуля");}

}

//S2.12. Найти площадь кольца по заданным внешнему и внутреннему радиусам.
if (N==212)
{
    Console.WriteLine("Ввести катета 1:"); 
bool inParseA4= int.TryParse(Console.ReadLine(), out int a4); 
Console.WriteLine("Ввести катета 2:"); 
bool inParseB4= int.TryParse(Console.ReadLine(), out int b4); 
Console.WriteLine($"Формула площади кольца площадь = Пи(R2-r2). S = {Math.PI*(Math.Pow(a4,2)-Math.Pow(b4,2))}");
}

//






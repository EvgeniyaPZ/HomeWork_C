int pro(int fn)
{
    int fn2=fn*fn;
    return fn2;
}
Console.WriteLine("First number: ");
int feN= Convert.ToInt32(Console.ReadLine());
Console.WriteLine(pro(feN));

Console.WriteLine("Second number: ");
int seN= Convert.ToInt32(Console.ReadLine());
Console.WriteLine(seN);
//int num=pro(feN);

if (pro(feN)==seN)
{
   Console.WriteLine("Yes");
}
else
{
   Console.WriteLine("No");
}

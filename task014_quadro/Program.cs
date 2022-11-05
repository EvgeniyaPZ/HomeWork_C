bool pro(int fn, int sn)
{
    int fn2=fn*fn;
      int sn2=sn*sn;
    return fn2==sn| sn2==fn;
}
Console.WriteLine("First number: ");
int feN= Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(pro(feN));

Console.WriteLine("Second number: ");
int seN= Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(seN);
bool num=pro(feN,seN);

if (num)
 {
   Console.WriteLine("Yes");
}
else
{
       Console.WriteLine("No");
}

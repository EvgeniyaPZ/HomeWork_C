int seven(int sev)
{
    int s = sev%7+sev%23;
    //int t = sev%23;
    //int r=
    return s;
}


//int number =Convert.ToInt32(Console.WriteRead());
int number=Convert.ToInt32(Console.ReadLine());
//int lastNumber= seven(number)+eleven(number);
if (seven(number)==0)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
int gg=Convert.ToInt32
int Multiple (int firstNumber, int secondNumber)
{
    
        int result =firstNumber%secondNumber;
 
    return result;
}
int fn=Convert.ToInt32(Console.ReadLine());
int sn=Convert.ToInt32(Console.ReadLine());
int res=Multiple(fn,sn);
if (res==0)
{
    string res1= "кратно";
    Console.WriteLine(res1);
}
else
{
    string res1= "некратно";
    Console.Write(res1);
    Console.Write(res);
}





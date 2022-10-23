Console.WriteLine("Enter figures: ");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
if (x>y)
{
   Console.WriteLine("MAX= "+x);
   Console.WriteLine("MIN= "+y);  
}
else if (x==y)
{
      Console.WriteLine("Figure equil");
}
else
{
   Console.WriteLine("MAX= "+y);
  
   Console.WriteLine("MIN= "+x);  

}
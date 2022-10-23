Console.WriteLine("Enter figures: ");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int z = Convert.ToInt32(Console.ReadLine());
int max = 0;

if (x>y)
{
max=x;
}
else
{
    max=y;
}
if (max>z)
{
    Console.WriteLine("max figure: " +max);
}
else Console.WriteLine("max figure: " +z);

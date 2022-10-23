Console.WriteLine("Enter number: ");
string num = Console.ReadLine();
int count = num.Length;
if (count !=3)
{
    Console.WriteLine("Error! Number not 3 sImbol!");
}
else
{
    Console.WriteLine(num.Substring(2,1));
}
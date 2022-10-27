Console.WriteLine("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num <2)
{
    Console.WriteLine("error! Number must be more 1");
}

int count = 2;
//int num1=num % 2;
// Console.Write(num1);
while (count <=num)
    {
        Console.Write(count);
        Console.Write(", ");
        count=count+2;

    }

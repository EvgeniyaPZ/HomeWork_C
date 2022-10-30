Console.WriteLine("Dog's task!");
Console.WriteLine("Speed first friend: ");
int speedF1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Speed second friend: ");
int speedF2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Dog's speed: ");
int speedDog = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Max distance: ");
int maxD = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Min distance: ");
int minD = Convert.ToInt32(Console.ReadLine());
int count =0;
//int ffriend = 1;
//int sfriend = 2;
int who =1;
int t = 0;


while (maxD>minD)
{
    if (who==1)
    {
        t=maxD/(speedF2+speedDog);
        count++;
        maxD=t*(speedF1+speedF2);
        who=2;
    }
    if (who==2)
    {
      t=maxD/(speedF1+speedDog);
        count++;
        maxD=t*(speedF1+speedF2);
        who=2;  
    }

}
Console.WriteLine(count);

Console.WriteLine("Введите первое число");
int n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int m=Convert.ToInt32(Console.ReadLine());
int sum=0;
Console.WriteLine(FillNumber(m,sum, n));
int FillNumber(int m, int sum, int a=1)
{
    sum=sum+a;
    a++;
    if (a>m)
    {
        return sum;
    }
    return FillNumber(m, sum, a);
  

}
   

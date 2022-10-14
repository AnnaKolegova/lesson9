Console.WriteLine("Введите первое число");
int n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int m=Convert.ToInt32(Console.ReadLine());
FillNumber(m,n);
void FillNumber(int m, int a=0)
{
    if (a%3==0)
    {
        Console.WriteLine(a);      
    }
    a++;
    if (a>m)
    {
        return;
    }
    FillNumber(m, a);
  

}

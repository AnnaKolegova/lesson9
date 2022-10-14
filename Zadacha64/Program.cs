Console.WriteLine("Введите первое число");
int n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int m=Convert.ToInt32(Console.ReadLine());
FillNumber(n,m);
void FillNumber(int n, int m)
{
    if (n%3==0)&& (n>=m);
    {
        return;
    }
    FillNumber(n, m);
  

}

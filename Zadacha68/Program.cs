﻿Console.WriteLine("Введите первое число");
int n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int m=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(A(n,m));
int A(int n, int m)
{
    if (n==0)
    {
        return m+1;
    }   
    if ((n>0)&&(m==0))
    {
        return A(n-1,1);
    }
    return A(n-1, A(n,m-1));
}  

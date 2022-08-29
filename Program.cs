Console.WriteLine("Введите пятизначное число: ");
int n = int.Parse(Console.ReadLine());
int a1 = n/10000;
int a2 = n%10;
int n1 = (n/10)%1000;
int b1 = n1/100;
int b2 = n1%10;
if(a1 == a2 && b1 == b2)
{
    Console.WriteLine("Yes");
}
else 
{
    Console.WriteLine("NO");
}


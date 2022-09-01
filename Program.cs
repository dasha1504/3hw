/* Console.WriteLine("Введите пятизначное число: ");
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
} */
/*  Console.WriteLine("Vvedite xA");
double xA = double.Parse(Console.ReadLine());
Console.WriteLine("Vvedite xB");
double xB = double.Parse(Console.ReadLine());
Console.WriteLine("Vvedite yA");
double yA = double.Parse(Console.ReadLine());
Console.WriteLine("Vvedite yB");
double yB = double.Parse(Console.ReadLine());
Console.WriteLine("Vvedite zA");
double zA = double.Parse(Console.ReadLine());
Console.WriteLine("Vvedite zB");
double zB = double.Parse(Console.ReadLine());
double pr = ((xA - xB) * (xA - xB)) + ((yA - yB) * (yA - yB)) + ((zA-zB) * (zA - zB));
double result = Math.Sqrt(pr);
Console.WriteLine(result);  */
Console.WriteLine("Vvedite N ");
int N = int.Parse(Console.ReadLine());
int i = 1;
while(i <= N)
{
    Console.Write(Math.Pow(i,3) + " ");
    i++;
}
int n = Convert.ToInt32(Console.ReadLine());
double sum = 0;
for(int i=0; i<=n; i++)
{
    if(n <= 30)
    sum += Math.Pow(2, i);
}
System.Console.WriteLine(sum);
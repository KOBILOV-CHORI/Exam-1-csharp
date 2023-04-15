int n = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[n];
int cnt = 0;
for(int i=0; i<n; i++)
{
    Array[i] = Convert.ToInt32(Console.ReadLine());
}
for(int i=1; i<n; i++ )
{
    if(Array[i] != Array[i-1]) cnt++;
}
System.Console.WriteLine(cnt);



int FindMinimum(int a, int b, int c, int d){
    int minn = 9999999;
    if(a < minn) minn = a;
    if(b < minn) minn = b;
    if(c < minn) minn = c;
    if(d < minn) minn = d;
    return minn;
}
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int d = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(FindMinimum(a,b,c,d));
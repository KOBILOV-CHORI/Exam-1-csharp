int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
int maxx = -99999999;
int minn = 999999999;
int max = 0;
int min = 0;
for(int i=0; i<n; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
    if(arr[i] > maxx) {maxx = arr[i]; max = i;}
    if(arr[i] < minn) {minn = arr[i]; min = i;}
}
for(int i= min; i<=max; i++)
{
    System.Console.Write(arr[i] + " ");
}
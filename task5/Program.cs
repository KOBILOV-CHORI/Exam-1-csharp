Calculator cl = new Calculator();
cl.n = Convert.ToInt64(Console.ReadLine());
cl.a = Convert.ToDouble(Console.ReadLine());
cl.b = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Factorial of n: " + cl.Factorial(cl.n));
System.Console.WriteLine("Multiple of a and b: " + cl.Multiple(cl.a, cl.b));
System.Console.WriteLine("Division of a and b: " + cl.Division(cl.a, cl.b));

public class Calculator
{
    public long n;
    public double a;
    public double b;

    public long Factorial(long n)
    {
        long sum = 1;
        for(int i=1; i<=n; i++){
            sum *= i;
        }
        return sum;
    }
    public double Multiple(double a, double b)
    {
        return a*b;
    }
    public double Division(double a, double b)
    {
        return a / b;
    }
}
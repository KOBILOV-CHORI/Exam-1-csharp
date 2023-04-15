
Circle cr = new Circle();
System.Console.Write("Enter radius of Circle: ");
cr.radius = Convert.ToDouble(Console.ReadLine());
cr.pi = 3.14;
System.Console.WriteLine("Area of Circle: " + cr.GetArea(cr.radius, cr.pi));
System.Console.WriteLine("Diameter of Circle: " + cr.GetDiameter(cr.radius, cr.pi));
System.Console.WriteLine("Circumference of Circle: " + cr.GetCircumference(cr.radius, cr.pi));
System.Console.WriteLine("Radius of Circle: " + cr.GetRadius(cr.radius));

public class Circle
{
    public double radius;
    public double pi;

    public double GetArea(double r, double p){
        return p * r * r;
    }
    public double GetDiameter(double r, double p){
        return 2 * r;
    } 
    public double GetCircumference(double r, double p){
        return 2 * r * p;
    }
    public double GetRadius(double r){
        return r;
    } 
}
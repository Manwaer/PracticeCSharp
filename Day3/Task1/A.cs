namespace Task1;
public class A
{
    public int a;
    public int b;
    
    public A(int _a, int _b)
    {
        a = _a;
        b = _b;
        Console.Write($"{(-b+1/a)/3}");
    }
}
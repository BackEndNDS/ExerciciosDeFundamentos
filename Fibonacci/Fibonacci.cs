namespace Fibonacci;

public class Fibonacci
{
    public static void Main(string[] args)
    {
        Fibo(1, 0, 0);
    }
    public static int Fibo(int num1, int quantidade, int aux)
    {
        Console.WriteLine(num1);
        if (quantidade > 10)
        {
            return num1;
        }
        
        var result = num1 + aux;
        aux = num1;
        num1 = result;
        return Fibo(result, ++quantidade, aux);
    }
}
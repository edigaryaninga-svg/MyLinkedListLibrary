namespace MyCalculatorProj;

public class MyCalculator 
{
    public double Calculate(double n1, double n2, string op)
    {
        if (op == "+") return n1 + n2;
        if (op == "-") return n1 - n2;
        if (op == "*") return n1 * n2;
        if (op == "/") return n2 != 0 ? n1 / n2 : 0;
        return 0;
    }
}
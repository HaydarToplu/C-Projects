namespace D4_PolymorphicCalculator;

public class Addition : ICalculator
{

    public double Operate(double num1, double num2)
    {
        double sonuc = num1 + num2;
        return sonuc;
    }
    
}
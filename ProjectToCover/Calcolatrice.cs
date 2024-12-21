public static class Calcolatrice
{
    public static double Addizione(double a, double b) => a + b;

    public static double Sottrazione(double a, double b) => a - b;

    public static double Moltiplicazione(double a, double b) => a * b;

    public static double Divisione(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Divisione per zero non consentita.");
        }
        return a / b;
    }

    public static double Potenza(double a, double b) => Math.Pow(a, b);

    public static double RadiceQuadrata(double a)
    {
        if (a < 0)
        {
            throw new ArgumentException("Radice quadrata di un numero negativo non consentita.");
        }
        return Math.Sqrt(a);
    }

    public static double Logaritmo(double a)
    {
        if (a <= 0)
        {
            throw new ArgumentException("Logaritmo di un numero non positivo non consentito.");
        }
        return Math.Log(a);
    }

    public static double LogaritmoBase(double a, double b)
    {
        if (a <= 0 || b <= 0 || b == 1)
        {
            throw new ArgumentException("Base o argomento del logaritmo non validi.");
        }
        return Math.Log(a, b);
    }

    public static double ValoreAssoluto(double a) => Math.Abs(a);

    public static double Resto(double a, double b) => a % b;
}
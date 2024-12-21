
if (args.Length >= 3)
{
    try
    {
        double operando1 = double.Parse(args[1]);
        double operando2 = double.Parse(args[2]);
        string operazione = args[0].ToLower();

        double risultato = operazione switch
        {
            "+" => Calcolatrice.Addizione(operando1, operando2),
            "-" => Calcolatrice.Sottrazione(operando1, operando2),
            "*" => Calcolatrice.Moltiplicazione(operando1, operando2),
            "/" => Calcolatrice.Divisione(operando1, operando2),
            "^" => Calcolatrice.Potenza(operando1, operando2),
            "radq" => Calcolatrice.RadiceQuadrata(operando1), //radice quadrata solo su un numero
            "log" => Calcolatrice.Logaritmo(operando1), //logaritmo naturale solo su un numero
            "logb" => Calcolatrice.LogaritmoBase(operando1, operando2), //logaritmo in base b
            "abs" => Calcolatrice.ValoreAssoluto(operando1), //valore assoluto solo su un numero
            "%" => Calcolatrice.Resto(operando1, operando2),
            _ => throw new ArgumentException("Operazione non valida.")
        };

        Console.WriteLine($"Risultato: {risultato}");
    }
    catch (FormatException)
    {
        Console.WriteLine("Input non valido. Inserire numeri validi.");
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
    }

}
else
{
    Console.WriteLine("Utilizzo: dotnet run <operazione> <operando1> <operando2>");
    Console.WriteLine("Operazioni disponibili: +, -, *, /, ^ (potenza), radq (radice quadrata), log (logaritmo naturale), logb (logaritmo in base b), abs (valore assoluto), % (resto)");
    Console.WriteLine("Esempio radice quadrata: dotnet run radq 25");
    Console.WriteLine("Esempio logaritmo in base 2 di 8: dotnet run logb 8 2");
}

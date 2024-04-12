using System;

public class CuentaCorriente
{
    private string titular;
    private decimal saldo;
    private readonly ITasaInteres tasaInteres;

    public CuentaCorriente(string titular, decimal saldoInicial, ITasaInteres tasaInteres)
    {
        this.titular = titular;
        this.saldo = saldoInicial;
        this.tasaInteres = tasaInteres;
    }

    public void Depositar(decimal monto)
    {
        saldo += monto;
        Console.WriteLine($"Se depositaron {monto:C}. Nuevo saldo: {saldo:C}");
    }

    public void Retirar(decimal monto)
    {
        if (monto > saldo)
        {
            Console.WriteLine("Saldo insuficiente.");
            return;
        }

        saldo -= monto;
        Console.WriteLine($"Se retiraron {monto:C}. Nuevo saldo: {saldo:C}");
    }

    public void AplicarInteres()
    {
        decimal interes = tasaInteres.CalcularInteres(saldo);
        saldo += interes;
        Console.WriteLine($"Se aplicó un interés de {interes:C}. Nuevo saldo: {saldo:C}");
    }
}

public interface ITasaInteres
{
    decimal CalcularInteres(decimal saldo);
}

public class TasaInteresSimple : ITasaInteres
{
    private decimal tasa;

    public TasaInteresSimple(decimal tasa)
    {
        this.tasa = tasa;
    }

    public decimal CalcularInteres(decimal saldo)
    {
        return saldo * tasa;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Crear una cuenta corriente con una tasa de interés simple del 1%.
        ITasaInteres tasaInteres = new TasaInteresSimple(0.01m);
        CuentaCorriente cuenta = new CuentaCorriente("Juan Perez", 1000m, tasaInteres);

        // Realizar algunas operaciones.
        cuenta.Depositar(500m);
        cuenta.Retirar(200m);
        cuenta.AplicarInteres();
    }
}

using NUnit.Framework;

[TestFixture]
public class CuentaCorrienteTests
{
    [Test]
    public void Depositar_AumentaSaldoCorrectamente()
    {
        // Arrange
        CuentaCorriente cuenta = new CuentaCorriente("Juan Perez", 1000m, new TasaInteresSimple(0.01m));

        // Act
        cuenta.Depositar(500m);

        // Assert
        Assert.AreEqual(1500m, cuenta.Saldo);
    }

    [Test]
    public void Retirar_DisminuyeSaldoCorrectamente()
    {
        // Arrange
        CuentaCorriente cuenta = new CuentaCorriente("Juan Perez", 1000m, new TasaInteresSimple(0.01m));

        // Act
        cuenta.Retirar(200m);

        // Assert
        Assert.AreEqual(800m, cuenta.Saldo);
    }

    [Test]
    public void Retirar_SaldoInsuficiente_NoCambiaSaldo()
    {
        // Arrange
        CuentaCorriente cuenta = new CuentaCorriente("Juan Perez", 1000m, new TasaInteresSimple(0.01m));

        // Act
        cuenta.Retirar(1200m);

        // Assert
        Assert.AreEqual(1000m, cuenta.Saldo);
    }

    [Test]
    public void AplicarInteres_AumentaSaldoCorrectamente()
    {
        // Arrange
        CuentaCorriente cuenta = new CuentaCorriente("Juan Perez", 1000m, new TasaInteresSimple(0.01m));

        // Act
        cuenta.AplicarInteres();

        // Assert
        Assert.AreEqual(1010m, cuenta.Saldo);
    }
}

using NUnit.Framework;
using Moq;

public interface IPaymentGateway
{
    bool ProcessPayment(decimal amount);
}

public class PaymentService
{
    private IPaymentGateway _paymentGateway;
    
    public PaymentService(IPaymentGateway paymentGateway)
    {
        _paymentGateway = paymentGateway;
    }

    public bool ProcessPayment(decimal amount)
    {
        // Logica de validacion

        // Cualquir otro tipo de logica de la unicad de codidgo.

        // Lógica de negocio para procesar el pago
        return _paymentGateway.ProcessPayment(amount);
    }

}

[TestFixture]
public class PaymentServiceTests
{
    [Test]
    public void ProcessPayment_Should_Return_True_If_Payment_Is_Successful()
    {
        // Arrange
        var amount = 100m;

        var paymentGatewayMock = new Mock<IPaymentGateway>();
        paymentGatewayMock.Setup(gateway => gateway.ProcessPayment(amount)).Returns(true);

        var paymentService = new PaymentService(paymentGatewayMock.Object);

        // Act
        var result = paymentService.ProcessPayment(amount);

        // Assert
        Assert.IsTrue(result);
    }
}

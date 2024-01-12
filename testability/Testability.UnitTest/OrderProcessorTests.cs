namespace Testability.UnitTest;


[TestClass]
public class OrderProcessorTests
{
    [TestMethod]
    [ExpectedException(typeof(InvalidOperationException))]

    //METHODNAME_CONDITION_EXPECTATION
    public void Process_OrderIsAlreadyShipped_ThrowsAnException()
    {
        var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
        var order = new Order
        {
            Shipment = new Shipment()
        };

        orderProcessor.Process(order);

        Assert.Fail("Expected an exception to be thrown");
    }
}

public class FakeShippingCalculator : IShippingCalculator
{
    public float CalculateShipping(Order order)
    {
        return 1;
        //throw new NotImplementedException();
    }
}
// See https://aka.ms/new-console-template for more information


using Testability;

var orderProcessor = new OrderProcessor(new ShippingCalculator());
var order = new OrderedParallelQuery { DatePlaced = DateTime.Now, TotalPrice = 100f };
orderProcessor.Process(order);



using AbstractFactory.Example2.Factories;
using AbstractFactory.Example2;

IPaymentGatewayFactory paymentGatewayFactory = new PayPalGatewayFactory();

PaymentService paymentService = new PaymentService(paymentGatewayFactory);
decimal amount = 100.00m;
paymentService.ProcessPaymen(amount);


IPaymentGatewayFactory anotherpaymentGatewayFactory = new StripeGatewayFactory();
PaymentService anotherPaymentService = new PaymentService(anotherpaymentGatewayFactory);
anotherPaymentService.ProcessPaymen(amount);



using OCP2.Good.Modals;

CardPayment payment = new CardPayment(100);
Console.WriteLine(payment.Pay());

GooglePayment payment2 = new GooglePayment(100);
Console.WriteLine(payment2.Pay());

Console.ReadKey();
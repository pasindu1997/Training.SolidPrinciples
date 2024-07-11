using OCP2.Bad.Modals;

Payment payment = new Payment("Card", 100);
Console.WriteLine(payment.Pay());

Payment payment2 = new Payment("GooglePay", 100);
Console.WriteLine(payment.Pay());

Console.ReadKey();
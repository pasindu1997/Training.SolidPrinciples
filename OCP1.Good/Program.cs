using OCP1.Good.Modals;

SavingAccount savingAccount = new SavingAccount("John", 1000, "123 Street");
Console.WriteLine(savingAccount.CalculateInterest());

KidsAccount kidsAccount = new KidsAccount("John's kid", 1000, "123 Street");
Console.WriteLine(kidsAccount.CalculateInterest());

Console.ReadKey();
using OCP1.Bad.Modal;

Account savingAccount = new Account("Savings", "John", 1000, "123 Street");
Console.WriteLine(savingAccount.CalculateInterest());

Account kidsAccount = new Account("KidsSaving", "John's kid", 1000, "123 Street");
Console.WriteLine(kidsAccount.CalculateInterest());

Console.ReadKey();
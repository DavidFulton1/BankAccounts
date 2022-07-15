using Bank_Encapsulation;


var account1 = new BankAccount();
Console.WriteLine("what is your deposit ammount?");
var ammount = double.Parse(Console.ReadLine());

BankAccount.Deposit(ammount);


using System;
using System.Collections.Generic;

public class FinanceApp
{
    private List<Transaction> _transactions = new();

    public void Run()
    {
        Console.Clear();
        Console.WriteLine("=== Finance Management System ===");

        // Create a SavingsAccount
        var account = new SavingsAccount("ACC-001", 1000m);

        // Sample transactions
        var t1 = new Transaction(1, DateTime.Now, 120m, "Groceries");
        var t2 = new Transaction(2, DateTime.Now, 300m, "Utilities");
        var t3 = new Transaction(3, DateTime.Now, 200m, "Entertainment");

        // Processors
        ITransactionProcessor mobileMoneyProcessor = new MobileMoneyProcessor();
        ITransactionProcessor bankTransferProcessor = new BankTransferProcessor();
        ITransactionProcessor cryptoWalletProcessor = new CryptoWalletProcessor();

        // Process and apply each transaction
        mobileMoneyProcessor.Process(t1);
        account.ApplyTransaction(t1);
        _transactions.Add(t1);

        bankTransferProcessor.Process(t2);
        account.ApplyTransaction(t2);
        _transactions.Add(t2);

        cryptoWalletProcessor.Process(t3);
        account.ApplyTransaction(t3);
        _transactions.Add(t3);

        Console.WriteLine("\n=== All Transactions Recorded ===");
        foreach (var tr in _transactions)
        {
            Console.WriteLine($"ID: {tr.Id}, Date: {tr.Date}, Amount: {tr.Amount}, Category: {tr.Category}");
        }

        PromptContinue();
    }

    private void PromptContinue()
    {
        Console.WriteLine("\nPress Enter to return to menu...");
        Console.ReadLine();
    }
}

// Record for transactions
public record Transaction(int Id, DateTime Date, decimal Amount, string Category);

// Interface for transaction processors
public interface ITransactionProcessor
{
    void Process(Transaction transaction);
}

// Different transaction processors
public class BankTransferProcessor : ITransactionProcessor
{
    public void Process(Transaction transaction)
    {
        Console.WriteLine($"[Bank Transfer] Processed {transaction.Amount:C} for {transaction.Category}");
    }
}

public class MobileMoneyProcessor : ITransactionProcessor
{
    public void Process(Transaction transaction)
    {
        Console.WriteLine($"[Mobile Money] Processed {transaction.Amount:C} for {transaction.Category}");
    }
}

public class CryptoWalletProcessor : ITransactionProcessor
{
    public void Process(Transaction transaction)
    {
        Console.WriteLine($"[Crypto Wallet] Processed {transaction.Amount:C} for {transaction.Category}");
    }
}

// Account classes
public class Account
{
    public string AccountNumber { get; }
    public decimal Balance { get; protected set; }

    public Account(string accountNumber, decimal initialBalance)
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
    }

    public virtual void ApplyTransaction(Transaction transaction)
    {
        Balance -= transaction.Amount;
        Console.WriteLine($"Transaction applied. New balance: {Balance:C}");
    }
}

public sealed class SavingsAccount : Account
{
    public SavingsAccount(string accountNumber, decimal initialBalance)
        : base(accountNumber, initialBalance) { }

    public override void ApplyTransaction(Transaction transaction)
    {
        if (transaction.Amount > Balance)
        {
            Console.WriteLine("Insufficient funds");
        }
        else
        {
            Balance -= transaction.Amount;
            Console.WriteLine($"Transaction applied. New balance: {Balance:C}");
        }
    }
}

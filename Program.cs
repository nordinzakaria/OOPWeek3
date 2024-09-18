// See https://aka.ms/new-console-template for more information


class Program
{
    static void Main(string[] args)
    {
        // creating an object (variable of a certain class type)
        Transaction transaction = new Transaction();

        transaction.month = 1;
        transaction.val = 10.5f;

        Console.WriteLine("transaction value is " + transaction.val);
    }

}

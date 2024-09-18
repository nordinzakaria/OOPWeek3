// See https://aka.ms/new-console-template for more information


using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main(string[] args)
    {
        // creating an object (variable of a certain class type)
        Transaction transaction = new Transaction();

        transaction.date = new DateTime(2008, 6, 1);
        transaction.val = 10.5f;

        Console.WriteLine("transaction value is " + transaction.val + " at time "+ transaction.date.ToString());
    }

}

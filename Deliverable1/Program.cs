// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main()
    {
        //In stock variablesP
        int Sodas = 100;
        int Chips = 40;
        int Candy = 60;

        //Restock variables 
        int SoReSt = 40;
        int ChReSt = 20;
        int CaReSt = 40;

        //Input variables 
        int Deduction;
        string Bought;

        //Soda algorithm 
        Console.WriteLine("How many Sodas have been soled to day? There is " + Sodas + " in stock right now. ");
            Bought = Console.ReadLine();
            Deduction  = int.Parse(Bought);
        if (Deduction > Sodas)
        {Console.WriteLine("The value is too high! Stock is not adjusted. ");
                }
        else {Sodas -= Deduction;
            Console.WriteLine(Sodas + " are now left.");}
        Console.WriteLine("                 ");

        //Chips algorithm 
        Console.WriteLine("How many Chips have been soled to day? There is " + Chips + " in stock right now. ");
            Bought = Console.ReadLine();
            Deduction = int.Parse(Bought);
        if (Deduction > Chips)
        {Console.WriteLine("The value is too high! Stock is not adjusted. ");}
        else
        {Chips -= Deduction;
            Console.WriteLine(Chips + " are now left.");}
        Console.WriteLine("                 ");

        //Candy algorithm 
        Console.WriteLine("How much Candy has been soled to day? There is " + Candy + " in stock right now. ");
            Bought = Console.ReadLine();
            Deduction = int.Parse(Bought);
        if (Deduction > Candy)
        {Console.WriteLine("The value is too high! Stock is not adjusted. ");}
        else
        {Candy -= Deduction;
            Console.WriteLine(Candy + " are now left.");}
        Console.WriteLine("                 ");
        
        //Determine what need s to be bought algorithm 
        Console.WriteLine("Thank you for filling out the values. Here's what needs to be restocked.");
        Console.WriteLine("                 ");
        if (Sodas <= SoReSt) { Console.WriteLine("You need to buy more Soda "); }
        if (Chips <= ChReSt) { Console.WriteLine("You need to buy more Chips "); }
        if (Candy <= CaReSt) { Console.WriteLine("You need to buy more Candy "); }
            Console.WriteLine("                 ");

        Console.WriteLine("HAVE A NICE DAY!! ");
    }
}
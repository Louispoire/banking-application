using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using bankingApplication.addOn;

namespace bankingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endProg = false;
            Console.WriteLine("Welcome to Atlas Banking System V4.79");

            Console.Write("Loading.");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            while (endProg != true)
            {
                Console.WriteLine("Bank Menu:");
                Console.WriteLine("A. Savings");
                Console.WriteLine("B. Checkings");
                Console.WriteLine("C: Global Savings");
                Console.WriteLine("Q: Exit");
                Console.WriteLine("Choose an option from above:");
                string option = Console.ReadLine();
                //--------------------------------
                if (option.ToLower() == "q" || option.ToLower() == "exit")
                {
                    Console.WriteLine("Goodbye!");
                    endProg = true;
                }
                //-------------------------------
                if (option.ToLower() == "a" || option.ToLower() == "savings")
                {
                    SavingAccount s1 = new SavingAccount(5.00, 10);
                    bool returnMenu = false;
                    Console.WriteLine("Current Balance in saving account: $" + s1.startingBalance);
                    while (returnMenu != true)
                    {
                        Console.WriteLine("Saving Account Menu:");
                        Console.WriteLine("A: Deposit");
                        Console.WriteLine("B. Withdrawal");
                        Console.WriteLine("C: Close and Report");
                        Console.WriteLine("R: Return to Menu");
                        Console.WriteLine("Choose an option from above:");
                        string option2 = Console.ReadLine();
                        if (option2.ToLower() == "a" || option2.ToLower() == "deposit")
                        {
                            Console.WriteLine("Enter amount for deposit: ");
                            double depo = Convert.ToDouble(Console.ReadLine());
                            s1.MakeADeposit(depo);
                            Console.WriteLine("$" + depo + " has been added to your account");
                                    
                        }
                        if (option2.ToLower() == "b" || option2.ToLower() == "withdrawal")
                        {
                            Console.WriteLine("Enter amount for withdraw: ");
                            double wit = Convert.ToDouble(Console.ReadLine());
                            s1.MakeWithdraw(wit);
                            Console.WriteLine(wit + " has been added to your account");
                        }
                        if (option2.ToLower() == "c" || option2.ToLower() == "closereport")
                        {
                            Console.WriteLine("Here is the report.");
                            s1.closeAndReportSaving();

                        }
                        if (option2.ToLower() == "r" || option2.ToLower() == "return" || option.ToLower() == "return menu")
                        {
                            returnMenu = true;
                        }
                        if (option2.ToLower() != "a" || option2.ToLower() != "deposit" || option2.ToLower() != "b" || option2.ToLower() != "withdrawal" || option2.ToLower() != "c" || option2.ToLower() != "closereport" || option2.ToLower() != "r" || option2.ToLower() != "return" || option.ToLower() != "return menu")
                        {
                            Console.WriteLine("Please enter a valid option");
                            continue;
                        }
                    }
                }
                if (option.ToLower() == "b" || option.ToLower() == "checking")
                {
                    ChequingAccount c1 = new ChequingAccount(5.00, 10);
                    bool returnMenu = false;
                    Console.WriteLine("Current Balance in saving account: $" + c1.startingBalance);
                    while (returnMenu != true)
                    {
                        Console.WriteLine("Saving Account Menu:");
                        Console.WriteLine("A: Deposit");
                        Console.WriteLine("B. Withdrawal");
                        Console.WriteLine("C: Close and Report");
                        Console.WriteLine("R: Return to Menu");
                        Console.WriteLine("Choose an option from above:");
                        string option2 = Console.ReadLine();
                        if (option2.ToLower() == "a" || option2.ToLower() == "deposit")
                        {
                            Console.WriteLine("Enter amount for deposit: ");
                            double depo = Convert.ToDouble(Console.ReadLine());
                            c1.MakeADeposit(depo);
                            Console.WriteLine("$" + depo + " has been added to your account");

                        }
                        if (option2.ToLower() == "b" || option2.ToLower() == "withdrawal")
                        {
                            Console.WriteLine("Enter amount for withdraw: ");
                            double wit = Convert.ToDouble(Console.ReadLine());
                            c1.MakeWithdraw(wit);
                            Console.WriteLine(wit + " has been added to your account");
                        }
                        if (option2.ToLower() == "c" || option2.ToLower() == "closereport")
                        {
                            Console.WriteLine("Here is the report.");
                            c1.closeAndReportSaving();

                        }
                        if (option2.ToLower() == "r" || option2.ToLower() == "return" || option.ToLower() == "return menu")
                        {
                            returnMenu = true;
                        }
                        if (option2.ToLower() != "a" || option2.ToLower() != "deposit" || option2.ToLower() != "b" || option2.ToLower() != "withdrawal" || option2.ToLower() != "c" || option2.ToLower() != "closereport" || option2.ToLower() != "r" || option2.ToLower() != "return" || option.ToLower() != "return menu")
                        {
                            Console.WriteLine("Please enter a valid option");
                            continue;
                        }
                    }

                }
                if (option.ToLower() == "c" || option.ToLower() == "global savings" || option.ToLower() == "globalsavings")
                {
                    Console.WriteLine("Bank Menu:");
                    Console.WriteLine("A: Deposit");
                    Console.WriteLine("B. Withdrawal");
                    Console.WriteLine("C: Close and Report");
                    Console.WriteLine("D: Report Balance in USD");
                    Console.WriteLine("R: Return to Menu");
                    Console.WriteLine("Choose an option from above:");
                    string option2 = Console.ReadLine();
                }
                else
                {
                    continue;
                }
            }
          



        }
    }
}

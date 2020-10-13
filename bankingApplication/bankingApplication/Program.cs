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
            double annualInterest = 10.00;
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
            SavingAccount s1 = new SavingAccount(5.00, annualInterest);
            ChequingAccount c1 = new ChequingAccount(5.00, annualInterest);
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
                    bool returnMenu = false;
                    if (s1.startingBalance == 5)
                    {
                        Console.WriteLine("Current Balance in saving account: $" + s1.startingBalance);
                        Console.WriteLine("-------------------------------------------");
                    }
                    if (s1.startingBalance != 5)
                    {
                        Console.WriteLine("Current Balance in saving account: $" + s1.currentBalance);
                        Console.WriteLine("-------------------------------------------");
                    }
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
                            Console.WriteLine("Enter amount to deposit: ");
                            double depo = Convert.ToDouble(Console.ReadLine());
                            s1.MakeADeposit(depo);
                            Console.WriteLine("Number of deposit made: " + s1.amountOfDeposit);
                            continue;
                                    
                        }
                        if (option2.ToLower() == "b" || option2.ToLower() == "withdrawal")
                        {
                            Console.WriteLine("Enter amount to withdraw: ");
                            double wit = Convert.ToDouble(Console.ReadLine());
                            s1.MakeWithdraw(wit);
                            Console.WriteLine("Number of withdrawal made: " + s1.amountOfWithdrawal);
                            continue;
                        }
                        if (option2.ToLower() == "c" || option2.ToLower() == "closereport")
                        {
                            Console.WriteLine("Here is the report.");
                            s1.closeAndReportSaving();
                            continue;

                        }
                        if (option2.ToLower() == "r" || option2.ToLower() == "return" || option.ToLower() == "return menu")
                        {
                            returnMenu = true;
                            continue;
                        }
                        if (option2.ToLower() != "a" || option2.ToLower() != "deposit" || option2.ToLower() != "b" || option2.ToLower() != "withdrawal" || option2.ToLower() != "c" || option2.ToLower() != "closereport" || option2.ToLower() != "r" || option2.ToLower() != "return" || option.ToLower() != "return menu")
                        {
                            Console.WriteLine("Please enter a valid option");
                            Console.WriteLine("---------------------------");
                            continue;
                        }
                    }
                }
                if (option.ToLower() == "b" || option.ToLower() == "checking")
                {
                    bool returnMenu = false;
                    if (c1.startingBalance == 5.00)
                    {
                        Console.WriteLine("Current Balance in saving account: $" + c1.startingBalance);
                        Console.WriteLine("-------------------------------------------");
                    }
                    if (c1.startingBalance != 5.00)
                    {
                        Console.WriteLine("Current Balance in saving account: $" + c1.currentBalance);
                        Console.WriteLine("-------------------------------------------");
                    }
                    while (returnMenu != true)
                    {
                        Console.WriteLine("Checking Account Menu:");
                        Console.WriteLine("A: Deposit");
                        Console.WriteLine("B. Withdrawal");
                        Console.WriteLine("C: Close and Report");
                        Console.WriteLine("R: Return to Menu");
                        Console.WriteLine("Choose an option from above:");
                        string option2 = Console.ReadLine();
                        if (option2.ToLower() == "a" || option2.ToLower() == "deposit")
                        {
                            Console.WriteLine("Enter amount to deposit: ");
                            double depo = Convert.ToDouble(Console.ReadLine());
                            c1.MakeADeposit(depo);
                            Console.WriteLine("Number of deposit made: " + s1.amountOfDeposit);
                            continue;

                        }
                        if (option2.ToLower() == "b" || option2.ToLower() == "withdrawal")
                        {
                            Console.WriteLine("Enter amount to withdraw: ");
                            double wit = Convert.ToDouble(Console.ReadLine());
                            c1.MakeWithdraw(wit);
                            Console.WriteLine("Number of withdrawal made: " + c1.amountOfWithdrawal);
                            continue;
                            
                           
                        }
                        if (option2.ToLower() == "c" || option2.ToLower() == "closereport")
                        {
                            Console.WriteLine("Here is the report.");
                            c1.closeAndReportChequing();
                            continue;

                        }
                        if (option2.ToLower() == "r" || option2.ToLower() == "return" || option.ToLower() == "return menu")
                        {
                            returnMenu = true;
                            continue;
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
                    bool returnMenu = false;
                    while (returnMenu != true)
                    {
                        Console.WriteLine("Bank Menu:");
                        Console.WriteLine("A: Report Balance in USD");
                        Console.WriteLine("R: Return to Menu");
                        Console.WriteLine("Choose an option from above:");
                        string option2 = Console.ReadLine();
                        if (option2.ToLower() == "a" || option2.ToLower() == "deposit")
                        {
                            GlobalSavingAccount g1 = new GlobalSavingAccount(s1.currentBalance, annualInterest);
                            Console.WriteLine(s1.currentBalance);
                            Console.WriteLine("Here are the balance in USD:");
                            Console.WriteLine(g1.USValue(1.33));
                            continue;
                        }
                        if (option2.ToLower() == "r" || option2.ToLower() == "return" || option.ToLower() == "return menu")
                        {
                            returnMenu = true;
                            continue;
                        }
                        if (option2.ToLower() != "r" || option2.ToLower() != "return" || option.ToLower() != "return menu" || option2.ToLower() != "a" || option2.ToLower() != "deposit")
                        {
                            Console.WriteLine("Enter valid value");
                            continue;
                        }
                    }
                }
                else
                {
                    continue;
                }
            }
          



        }
    }
}

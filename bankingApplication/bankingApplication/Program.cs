using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using bankingApplication.addOn;
using System.Collections.Concurrent;

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
            GlobalSavingAccount g1 = new GlobalSavingAccount(5.00, annualInterest);
            while (endProg != true)
            {
                Console.WriteLine("\n\nBank Menu:");
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

                    Math.Round(s1.currentBalance);
                    Console.WriteLine("\nCurrent Balance in savings account: " + s1.currentBalance.ToString("0.00"));
                    Console.WriteLine("-------------------------------------------");
     
                    while (returnMenu != true)
                    {
                        Console.WriteLine("\n\nSaving Account Menu:");
                        Console.WriteLine("A: Deposit");
                        Console.WriteLine("B. Withdrawal");
                        Console.WriteLine("C: Close and Report");
                        Console.WriteLine("R: Return to Menu");
                        Console.WriteLine("Choose an option from above:");
                        string option2 = Console.ReadLine();
                        if (option2.ToLower() == "a" || option2.ToLower() == "deposit")
                        {
                            Console.WriteLine("\nEnter amount to deposit: ");
                            double depo = Convert.ToDouble(Console.ReadLine());
                            s1.MakeADeposit(depo);
                            Console.WriteLine("\nNumber of deposit made: " + s1.amountOfDeposit);
                            continue;
                                    
                        }
                        if (option2.ToLower() == "b" || option2.ToLower() == "withdrawal")
                        {
                            Console.WriteLine("\nEnter amount to withdraw: ");
                            double wit = Convert.ToDouble(Console.ReadLine());
                            s1.MakeWithdraw(wit);
                            Console.WriteLine("\nNumber of withdrawal made: " + s1.amountOfWithdrawal);
                            continue;
                        }
                        if (option2.ToLower() == "c" || option2.ToLower() == "closereport")
                        {
                            Console.WriteLine("\n\nHere is the report.\n");
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
                            Console.WriteLine("\nPlease enter a valid option");
                            Console.WriteLine("---------------------------");
                            continue;
                        }
                    }
                }
                if (option.ToLower() == "b" || option.ToLower() == "checking")
                {
                    bool returnMenu = false;

                    Math.Round(c1.currentBalance);
                    Console.WriteLine("\nCurrent Balance in chequing account: $" + c1.currentBalance.ToString("0.00"));
                    Console.WriteLine("-------------------------------------------");
                   
                    while (returnMenu != true)
                    {
                        Console.WriteLine("\n\nChecking Account Menu:");
                        Console.WriteLine("A: Deposit");
                        Console.WriteLine("B. Withdrawal");
                        Console.WriteLine("C: Close and Report");
                        Console.WriteLine("R: Return to Menu");
                        Console.WriteLine("Choose an option from above:");
                        string option2 = Console.ReadLine();
                        if (option2.ToLower() == "a" || option2.ToLower() == "deposit")
                        {
                            Console.WriteLine("\nEnter amount to deposit: ");
                            double depo = Convert.ToDouble(Console.ReadLine());
                            c1.MakeADeposit(depo);
                            Console.WriteLine("\nNumber of deposit made: " + c1.amountOfDeposit);
                            continue;

                        }
                        if (option2.ToLower() == "b" || option2.ToLower() == "withdrawal")
                        {
                            Console.WriteLine("\nEnter amount to withdraw: ");
                            double wit = Convert.ToDouble(Console.ReadLine());
                            c1.MakeWithdraw(wit);
                            Console.WriteLine("\nNumber of withdrawal made: " + c1.amountOfWithdrawal);
                            continue;
                            
                           
                        }
                        if (option2.ToLower() == "c" || option2.ToLower() == "closereport")
                        {
                            Console.WriteLine("\n\nHere is the report.\n");
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
                            Console.WriteLine("\nPlease enter a valid option");
                            continue;
                        }
                    }

                }
                if (option.ToLower() == "c" || option.ToLower() == "global savings" || option.ToLower() == "globalsavings")
                {
                    bool returnMenu = false;

                    Math.Round(g1.currentBalance);
                    Console.WriteLine("\nCurrent Balance in global savings account: $" + g1.currentBalance.ToString("0.00"));
                    Console.WriteLine("-------------------------------------------");

                    while (returnMenu != true)
                    {
                        Console.WriteLine("\n\nBank Menu:");
                        Console.WriteLine("A: Deposit");
                        Console.WriteLine("B. Withdrawal");
                        Console.WriteLine("C: Close and Report");
                        Console.WriteLine("D: Report Balance in USD");
                        Console.WriteLine("R: Return to Menu");
                        Console.WriteLine("Choose an option from above:");
                        string option2 = Console.ReadLine();
                        if (option2.ToLower() == "a" || option2.ToLower() == "deposit")
                        {
                            Console.WriteLine("\nEnter amount to deposit: ");
                            double depo = Convert.ToDouble(Console.ReadLine());
                            g1.MakeADeposit(depo);
                            Console.WriteLine("\nNumber of deposit made: " + g1.amountOfDeposit);
                            continue;

                        }
                        if (option2.ToLower() == "b" || option2.ToLower() == "withdrawal")
                        {
                            Console.WriteLine("\nEnter amount to withdraw: ");
                            double wit = Convert.ToDouble(Console.ReadLine());
                            g1.MakeWithdraw(wit);
                            Console.WriteLine("\nNumber of withdrawal made: " + g1.amountOfWithdrawal);
                            continue;


                        }
                        if (option2.ToLower() == "c" || option2.ToLower() == "closereport")
                        {
                            Console.WriteLine("\n\nHere is the report.\n");
                            g1.closeAndReportSaving();
                            continue;

                        }
                        if (option2.ToLower() == "d" || option2.ToLower() == "balanceUS")
                        {
                            Console.WriteLine("\nHere are the balance in USD:");
                            Console.WriteLine("$ " + Math.Round(g1.USValue(1.33), 2));
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

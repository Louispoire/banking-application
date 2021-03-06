﻿using System;
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
            Thread.Sleep(3000);
            Console.WriteLine("Created by Cristian and Louis-Philippe");
            Console.WriteLine("");
            Thread.Sleep(2000);
            Console.Write("Loading.");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.WriteLine(" Done!");
            SavingAccount s1 = new SavingAccount(5.00, annualInterest);
            ChequingAccount c1 = new ChequingAccount(5.00, annualInterest);
            GlobalSavingAccount g1 = new GlobalSavingAccount(5.00, annualInterest);
            while (endProg != true)
            {
                Console.WriteLine("\nBANK MENU:");
                Console.WriteLine("A: Savings");
                Console.WriteLine("B: Checkings");
                Console.WriteLine("C: Global Savings");
                Console.WriteLine("Q: Exit");
                Console.WriteLine("\nChoose an option from above:");
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
                    
     
                    while (returnMenu != true)
                    {
                        Console.WriteLine("\nSAVINGS ACCOUNT MENU:");
                        Console.WriteLine("Current Balance in savings account: $" + s1.currentBalance.ToString("0.00"));
                        Console.WriteLine("-------------------------------------------");
                        Console.WriteLine("A: Deposit");
                        Console.WriteLine("B: Withdrawal");
                        Console.WriteLine("C: Close and Report");
                        Console.WriteLine("R: Return to Menu");
                        Console.WriteLine("\nChoose an option from above:");
                        string option2 = Console.ReadLine();
                        if (option2.ToLower() == "a" || option2.ToLower() == "deposit")
                        {
                            Console.WriteLine("\nEnter amount to deposit: ");
                            try
                            {
                                double depo = Convert.ToDouble(Console.ReadLine());
                                s1.MakeADeposit(depo);
                                Console.WriteLine("\nNumber of deposit made: " + s1.amountOfDeposit);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("\nError: Value must be a number");
                            }
                            continue;
                                    
                        }
                        if (option2.ToLower() == "b" || option2.ToLower() == "withdrawal")
                        {
                            try
                            {
                                Console.WriteLine("\nEnter amount to withdraw: ");
                                double wit = Convert.ToDouble(Console.ReadLine());
                                s1.MakeWithdraw(wit);
                                Console.WriteLine("\nNumber of withdrawal made: " + s1.amountOfWithdrawal);
                            }
                            catch(Exception e)
                            {
                                Console.WriteLine("\nError: Value must be a number");
                            }
                            continue;
                        }
                        if (option2.ToLower() == "c" || option2.ToLower() == "closereport")
                        {
                            if (s1.reportLimit == false)
                            {
                                Console.WriteLine("\n\nHere is the report.\n");
                                s1.closeAndReportSaving();
                                continue;
                            }
                            if (s1.reportLimit == true)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Error: Please make another operation before requesting a report.");
                            }

                        }
                        if (option2.ToLower() == "r" || option2.ToLower() == "return" || option.ToLower() == "return menu")
                        {
                            returnMenu = true;
                            continue;
                        }
                        if (option2.ToLower() != "a" || option2.ToLower() != "deposit" || option2.ToLower() != "b" || option2.ToLower() != "withdrawal" || option2.ToLower() != "c" || option2.ToLower() != "closereport" || option2.ToLower() != "r" || option2.ToLower() != "return" || option.ToLower() != "return menu")
                        {
                            Console.WriteLine("\nError: Invalid option");
                            continue;
                        }
                    }
                }
                if (option.ToLower() == "b" || option.ToLower() == "checking")
                {
                    bool returnMenu = false;
                    Math.Round(c1.currentBalance);
                   
                    while (returnMenu != true)
                    {
                        Console.WriteLine("\nCHECKINGS ACCOUNT MENU");
                        Console.WriteLine("Current Balance in chequing account: $" + c1.currentBalance.ToString("0.00"));
                        Console.WriteLine("-------------------------------------------");
                        Console.WriteLine("A: Deposit");
                        Console.WriteLine("B: Withdrawal");
                        Console.WriteLine("C: Close and Report");
                        Console.WriteLine("R: Return to Menu");
                        Console.WriteLine("\nChoose an option from above:");
                        string option2 = Console.ReadLine();
                        if (option2.ToLower() == "a" || option2.ToLower() == "deposit")
                        {
                            try
                            {
                                Console.WriteLine("\nEnter amount to deposit: ");
                                double depo = Convert.ToDouble(Console.ReadLine());
                                c1.MakeADeposit(depo);
                                Console.WriteLine("\nNumber of deposit made: " + c1.amountOfDeposit);
                            }
                            catch(Exception e)
                            {
                                Console.WriteLine("\nError: Value must be a number");
                            }
                            continue;

                        }
                        if (option2.ToLower() == "b" || option2.ToLower() == "withdrawal")
                        {
                            try
                            {
                                Console.WriteLine("\nEnter amount to withdraw: ");
                                double wit = Convert.ToDouble(Console.ReadLine());
                                c1.MakeWithdraw(wit);
                                Console.WriteLine("\nNumber of withdrawal made: " + c1.amountOfWithdrawal);
                            }
                            catch(Exception e)
                            {
                                Console.WriteLine("\nError: Value must be a number");
                            }
                            continue;
                            
                           
                        }
                        if (option2.ToLower() == "c" || option2.ToLower() == "closereport")
                        {
                            if (c1.reportLimit == false)
                            {
                                Console.WriteLine("\n\nHere is the report.\n");
                                c1.closeAndReportChequing();
                                continue;
                            }
                            if (c1.reportLimit == true)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Error: Please make another operation before requesting a report.");
                            }

                        }
                        if (option2.ToLower() == "r" || option2.ToLower() == "return" || option.ToLower() == "return menu")
                        {
                            returnMenu = true;
                            continue;
                        }
                        if (option2.ToLower() != "a" || option2.ToLower() != "deposit" || option2.ToLower() != "b" || option2.ToLower() != "withdrawal" || option2.ToLower() != "c" || option2.ToLower() != "closereport" || option2.ToLower() != "r" || option2.ToLower() != "return" || option2.ToLower() != "return menu")
                        {
                            Console.WriteLine("\nError: Invalid option");
                            continue;
                        }
                    }

                }
                if (option.ToLower() == "c" || option.ToLower() == "global savings" || option.ToLower() == "globalsavings")
                {
                    bool returnMenu = false;
                    Math.Round(g1.currentBalance);

                    while (returnMenu != true)
                    {
                        Console.WriteLine("\nGLOBAL SAVINGS ACCOUNT MENU");
                        Console.WriteLine("Current Balance in global savings account: $" + g1.currentBalance.ToString("0.00"));
                        Console.WriteLine("-------------------------------------------");
                        Console.WriteLine("A: Deposit");
                        Console.WriteLine("B: Withdrawal");
                        Console.WriteLine("C: Close and Report");
                        Console.WriteLine("D: Report Balance in USD");
                        Console.WriteLine("R: Return to Menu");
                        Console.WriteLine("\nChoose an option from above:");
                        string option2 = Console.ReadLine();
                        if (option2.ToLower() == "a" || option2.ToLower() == "deposit")
                        {
                            try
                            {
                                Console.WriteLine("\nEnter amount to deposit: ");
                                double depo = Convert.ToDouble(Console.ReadLine());
                                g1.MakeADeposit(depo);
                                Console.WriteLine("\nNumber of deposit made: " + g1.amountOfDeposit);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Error: Value must be a number");
                            }
                            continue;

                        }
                        if (option2.ToLower() == "b" || option2.ToLower() == "withdrawal")
                        {
                            try
                            {
                                Console.WriteLine("\nEnter amount to withdraw: ");
                                double wit = Convert.ToDouble(Console.ReadLine());
                                g1.MakeWithdraw(wit);
                                Console.WriteLine("\nNumber of withdrawal made: " + g1.amountOfWithdrawal);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Error: Value must be a number");
                            }
                            continue;


                        }
                        if (option2.ToLower() == "c" || option2.ToLower() == "closereport")
                        {
                            if (g1.reportLimit == false)
                            {
                                Console.WriteLine("\n\nHere is the report.\n");
                                g1.closeAndReportSaving();
                                continue;
                            }
                            if (g1.reportLimit == true)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Error: Please make another operation before requesting a report.");
                            }

                        }
                        if (option2.ToLower() == "d" || option2.ToLower() == "balanceUS")
                        {
                            Console.WriteLine("\nHere are the balance in USD:");
                            Math.Round(g1.USValue(0.76), 2);
                            Console.WriteLine("$" + g1.USValue(0.76).ToString("0.00"));
                            continue;
                        }
                        if (option2.ToLower() == "r" || option2.ToLower() == "return" || option.ToLower() == "return menu")
                        {
                            returnMenu = true;
                            continue;
                        }
                        if (option2.ToLower() != "r" || option2.ToLower() != "return" || option.ToLower() != "return menu" || option2.ToLower() != "a" || option2.ToLower() != "deposit")
                        {
                            Console.WriteLine("\nError: Invalid option");
                            continue;
                        }
                    }
                }
                if (option.ToLower() != "a" || option.ToLower() != "savings" || option.ToLower() != "b" || option.ToLower() != "checkings" || option.ToLower() != "c" || option.ToLower() != "globalssavings" || option.ToLower() != "r" || option.ToLower() != "return" || option.ToLower() != "return menu")
                {
                    Console.WriteLine("\nError: Invalid option");
                    continue;
                }
            }
        }
    }
}

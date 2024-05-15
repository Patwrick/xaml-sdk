﻿using System;

namespace MailMerge
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Choose the type of data object:");
            Console.WriteLine("1 - Save mail-merged document with dynamic data object");
            Console.WriteLine("2 - Save mail-merged document with concrete data object");

            Console.Write("Your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    DocumentProcessor.MailMergeWithDynamicDataObject();
                    break;
                case "2":
                    DocumentProcessor.MailMergeWithConcreteDataObject();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

            Console.Read();
        }
    }
}

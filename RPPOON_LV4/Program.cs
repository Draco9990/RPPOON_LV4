using System;
using System.Collections.Generic;

namespace RPPOON_LV4
{
    class Program
    {
        static void Main(string[] args)
        {
            Zadatak2();
            Zadatak3();
            Zadatak4();
            Zadatak5();
            Zadatak6();
            Zadatak7();
        }

        public static void Zadatak2()
        {
            Console.WriteLine("Zadatak 2\n");
            Dataset csv = new Dataset(@"C:\csv.csv");
            Adapter adapter = new Adapter(new Analyzer3rdParty());
            double[][] matrix = adapter.ConvertData(csv);
            Debug(matrix);
            Console.WriteLine("\n***************************************\n");
        }

        public static void Zadatak3()
        {
            Console.WriteLine("Zadatak 3\n");
            List<IRentable> list = new List<IRentable>();
            list.Add(new Book("Zlocin i kazna"));
            list.Add(new Video("Sam u kuci"));
            RentingConsolePrinter printer = new RentingConsolePrinter();
            printer.DisplayItems(list);
            Console.WriteLine("\n***************************************\n");
        }

        public static void Zadatak4()
        {
            Console.WriteLine("Zadatak 4\n");
            List<IRentable> list = new List<IRentable>();
            list.Add(new Book("Zlocin i kazna"));
            list.Add(new Video("Sam u kuci"));
            list.Add(new HotItem(new Book("Zlocin i kazna 2")));
            list.Add(new HotItem(new Video("Sam u kuci 2")));
            RentingConsolePrinter printer = new RentingConsolePrinter();
            printer.DisplayItems(list);
            Console.WriteLine("\n***************************************\n");
            //Sada imamo Trending: Prije imena
        }

        public static void Zadatak5()
        {
            Console.WriteLine("Zadatak 5\n");
            List<IRentable> flashSale = new List<IRentable>();
            flashSale.Add(new DiscountedItem(new Book("Zlocin i kazna")));
            flashSale.Add(new DiscountedItem(new Video("Sam u kuci")));
            RentingConsolePrinter printer = new RentingConsolePrinter();
            printer.DisplayItems(flashSale);
            Console.WriteLine("\n***************************************\n");
        }

        public static void Zadatak6()
        {
            Console.WriteLine("Zadatak 6\n");
            EmailValidator emailValidator = new EmailValidator();
            string email = "msismanovic@etfos.hr";
            Console.WriteLine(email + " is" + (emailValidator.IsValidAddress(email) ? "" : " not") + " valid!");
            PasswordValidator passwordValidator = new PasswordValidator(5);
            string password = "Vm123!";
            Console.WriteLine(password + " is" + (passwordValidator.IsValidPassword(password)?"":" not") + " valid!");
            Console.WriteLine("\n***************************************\n");

        }

        public static void Zadatak7()
        {
            Console.WriteLine("Zadatak 7\n");

            UserEntry entry = UserEntry.ReadUserFromConsole();
            Fasade fasade = new Fasade(new EmailValidator(), new PasswordValidator(5));
            while (!fasade.IsUserEntryValid(entry))
            {
                entry = UserEntry.ReadUserFromConsole();
            }
            Console.WriteLine("\n***************************************\n");

        }


        static void Debug(double[][] f)
        {
            for (int i = 0; i < f.Length; i++)
            {
                for (int j = 0; j < f[i].Length; j++)
                {
                    Console.Write(f[i][j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}

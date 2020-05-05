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
            foreach(double d in adapter.CalculateAveragePerColumn(csv))
            {
                Console.WriteLine(d);
            }
            Debug(matrix);
            Console.WriteLine("\n***************************************\n");
        }

        public static void Zadatak3()
        {
            Console.WriteLine("Zadatak 3\n");
            List<IRentable> list = new List<IRentable>
            {
                new Book("Zlocin i kazna"),
                new Video("Sam u kuci")
            };
            RentingConsolePrinter printer = new RentingConsolePrinter();
            printer.DisplayItems(list);
            printer.PrintTotalPrice(list);
            Console.WriteLine("\n***************************************\n");
        }

        public static void Zadatak4()
        {
            Console.WriteLine("Zadatak 4\n");
            List<IRentable> list = new List<IRentable>
            {
                new Book("Zlocin i kazna"),
                new Video("Sam u kuci"),
                new HotItem(new Book("Zlocin i kazna 2")),
                new HotItem(new Video("Sam u kuci 2"))
            };
            RentingConsolePrinter printer = new RentingConsolePrinter();
            printer.DisplayItems(list);
            printer.PrintTotalPrice(list);
            Console.WriteLine("\n***************************************\n");
            //Sada imamo Trending: Prije imena
        }

        public static void Zadatak5()
        {
            Console.WriteLine("Zadatak 5\n");
            List<IRentable> flashSale = new List<IRentable>
            {
                new DiscountedItem(new Book("Zlocin i kazna")),
                new DiscountedItem(new Video("Sam u kuci")),
                new DiscountedItem(new HotItem(new Book("Zlocin i kazna 2"))),
                new DiscountedItem(new HotItem(new Video("Sam u kuci 2")))
            };
            RentingConsolePrinter printer = new RentingConsolePrinter();
            printer.DisplayItems(flashSale);
            printer.PrintTotalPrice(flashSale);
            Console.WriteLine("\n***************************************\n");
        }

        public static void Zadatak6()
        {
            Console.WriteLine("Zadatak 6\n");
            EmailValidator emailValidator = new EmailValidator();
            PasswordValidator passwordValidator = new PasswordValidator(5);
            string email = "msismanovic@etfos.hr";
            string password = "Vm123";
            Console.WriteLine(email + " is" + (emailValidator.IsValidAddress(email) ? "" : " not") + " valid!");
            Console.WriteLine(password + " is" + (passwordValidator.IsValidPassword(password) ? "" : " not") + " valid!");
            Console.WriteLine("\n***************************************\n");
        }

        public static void Zadatak7()
        {
            Console.WriteLine("Zadatak 7\n");

            UserEntry entry;
            Fasade fasade = new Fasade(5);
            do
            {
                entry = UserEntry.ReadUserFromConsole();
            }
            while (!fasade.IsUserEntryValid(entry));
            Console.WriteLine("\n***************************************\n");
        }

        public static void Debug(double[][] f)
        {
            for (int i = 0; i < f.Length; i++)
            {
                for (int j = 0; j < f[i].Length; j++)
                {
                    Console.Write(f[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}

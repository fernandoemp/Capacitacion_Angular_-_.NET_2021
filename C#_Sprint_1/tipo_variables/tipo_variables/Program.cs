using System;

namespace tipo_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 10;
            int yearString = Convert.ToInt16("13");
            float smallPrice = 12.432364f;
            double price = 14.0123343453445;
            decimal priceExactly = 2.45547476867345562342345463456m;
            string name = "Fernando";
            String nameTwo = "Emanuel";
            bool flag = false;
            char character = 'a';

            int year2 = 100;
            Console.WriteLine("Year 1 y 2: {0} {1}", year, yearString);
            Console.WriteLine("Price: {0}", price);
            Console.WriteLine("Name:" +  name);
            Console.WriteLine("Name2:" + nameTwo);
            Console.WriteLine("Small Price 2: {0}", smallPrice);
            Console.WriteLine("Price 2: {0}", priceExactly);
            Console.WriteLine("Flag: {0}", flag);
            Console.WriteLine("Character: {0}", character);


            dynamic valueDinamyc = 20;
            valueDinamyc = true;
            valueDinamyc = "valueDinamyc";
            Console.WriteLine("Dinamyc:"+ valueDinamyc);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2024_10_29_b_exceptions.models
{
    public static class StringFormatDriver
    {
        public static void Run()
        {
            // Console.WriteLine("StringFormatDriver");
            FixedWidthFormatting();
            FixedWidthWithHeaders();
        }

        public static void FixedWidthFormatting()
        {
            string name = "Alice";
            string city = "Seattle";
            string product = "Laptop";
            double price = 999.99;

            Console.WriteLine($"{name} {city}");
            Console.WriteLine($"{name.PadLeft(10)}");
            Console.WriteLine($"{city.PadLeft(10)}");

            // name.PadLeft(10,'*') - right align, and fill out spaces with an *
            Console.WriteLine($"{name.PadLeft(10,'*')}");
            Console.WriteLine($"{city.PadLeft(10,'*')}");

            Console.WriteLine($"|{product,15}|{price,-10}|");

        }

        public static void FixedWidthWithHeaders()
        {
            string[] headers = { "ID", "Name", "Occupation" };
            string[,] data = {
            { "1", "Alice", "Engineer" },
            { "2", "Bob", "Doctor" },
            { "3", "Cathy", "Designer" }
        };

            // Header with fixed width
            Console.WriteLine($"|{headers[0],-5}|{headers[1],-10}|{headers[2],-12}|");

            for (int i = 0; i < data.GetLength(0); i++)
            {
                Console.WriteLine($"|{data[i, 0],-5}|{data[i, 1],-10}|{data[i, 2],-12}|");
            }


        }
    }
}

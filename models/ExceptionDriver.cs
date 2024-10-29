using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2024_10_29_b_exceptions.models
{
    public static class ExceptionDriver
    {
        public static void Run()
        {

            //Console.WriteLine("ExceptionDriver");
            InvalidOperationExceptionDemo();
            ArgumentOutOfRangeExceptionDemo();
            FormatExceptionDemo();
            DivideByZeroExceptionDemo();
            IndexOutOfRangeExceptionDemo();
            NullReferenceExceptionDemo();
        }

        public static void InvalidOperationExceptionDemo()
        {
            Queue<int> numbersQueue = new Queue<int>();


            try
            {
                int number = numbersQueue.Dequeue();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"InvalidOperationException\t caught:\t [ {ex.Message} ]");
            }

        }



        public static void ArgumentOutOfRangeExceptionDemo()
        {

            List<int> numbers = new List<int> { 1, 2, 3 };
            try
            {
                Console.WriteLine(numbers[-1]);
            }
            catch (ArgumentOutOfRangeException ex)
            {

                Console.WriteLine($"ArgumentOutOfRangeException\t caught:\t [ {ex.Message} ]");
            }

        }


        public static void FormatExceptionDemo()
        {
            string invalidNumber = "ABC";

            try
            {
                int result = int.Parse(invalidNumber); // A way to convert numeric strings into integers
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"FormatException\t\t caught:\t [ {ex.Message} ]");
            }

        }

        public static void DivideByZeroExceptionDemo()
        {
            int dividend = 10;
            int divisor = 0;
            try
            {
                int result = dividend / divisor;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"DivideByZeroException\t caught:\t [ {ex.Message} ]");
            }

        }


        public static void IndexOutOfRangeExceptionDemo()
        {
            int[] numbers = { 1, 2, 3 }; // positions 0, 1, 2
            try
            {
                Console.WriteLine(numbers[5]); // position 5 does not exist, so exception is thrown
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"IndexOutRangeException\t caught:\t [ {ex.Message} ]");
            }
            finally
            {

            }

        }

        public static void NullReferenceExceptionDemo()
        {
            string message = null;

            try
            {
                Console.WriteLine(message.Length);
            }
            catch (NullReferenceException ex)
            {

                Console.WriteLine($"NullReferenceException\t caught:\t [ {ex.Message} ]");
            }
            finally
            {

                Console.WriteLine("Finally called on NullReferenceExceptionDemo()");
            }

        }


    }
}

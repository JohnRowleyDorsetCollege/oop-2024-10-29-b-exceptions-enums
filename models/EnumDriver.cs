using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2024_10_29_b_exceptions.models
{
    public static class EnumDriver
    {
        public static void Run()
        {
            Console.WriteLine("EnumDriver is running");
            DayOfWeekDemo();
            CustomStartingValueDemo();
            DemonstrateExplicitEnumValue();
            CallHandleLight();

        }
        public static void DayOfWeekDemo()
        {
            Console.WriteLine($"Today is {DayOfWeek.Tuesday} : {(int)DayOfWeek.Tuesday} ");
        }
        public static void CustomStartingValueDemo()
        {
            Console.WriteLine($"Severity Level is {SeverityLevel.Critical}: {(int)SeverityLevel.Critical}");
        }
        public static void DemonstrateExplicitEnumValue()
        {
            Console.WriteLine($"{StatusCode.Ok}: {(int)StatusCode.Ok}");
            Console.WriteLine($"{StatusCode.NotFound}: {(int)StatusCode.NotFound}");
            Console.WriteLine($"{StatusCode.InternalServerError}: {(int)StatusCode.InternalServerError}");
        }
         public static void CallHandleLight()
        {
            Console.WriteLine($"Traffic light indicates : { HandleLight(LightState.Green)}");
            Console.WriteLine($"Traffic light indicates : {HandleLight(LightState.Unknown)}");
        }

        public static string HandleLight(LightState state)
        {
            switch (state)
            {
                case LightState.Red: Console.WriteLine("Stop"); break;
                case LightState.Yellow: Console.WriteLine("Caution"); break;
                case LightState.Green: Console.WriteLine("Go"); break;
            }

            string message = state switch
            {
                LightState.Red => "Stop",
                LightState.Yellow => "Caution",
                LightState.Green => "Go",
                _ => "Traffic light is out of action, proceed with caution"

            };

            return message;
        }
    }
}

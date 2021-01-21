using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonditalProgram_H2
{
    class Program
    {
        static void Main()
        {
            //fields
            int restingPulse;
            int maxPulse;
            int weight;

            WriteToConsole("Hello and wellcome today we are gonna see what your physical condition is.\nBy continuing you are giving us permission to handle your data\nPress any key to continue...", 28);
            Console.ReadKey();
            Console.Clear();
            WriteToConsole("Great lets get started", 20);
            WriteToConsole("...", 500);
            Console.Clear();
            WriteToConsole("What is your weight in kg?\n", 28);
            //Calls ConvertFromConsole() and saves the return value in weight
            weight = ConvertFromConsole();
            WriteToConsole("What is your resting pulse in bpm(beats per minute)?\n", 28);
            //Calls ConvertFromConsole() and saves the return value in restingPulse
            restingPulse = ConvertFromConsole();
            WriteToConsole("What is your max pulse when you workout in bpm(beats per minute)?\n", 28);
            //Calls ConvertFromConsole() and saves the return value in maxPulse
            maxPulse = ConvertFromConsole();
            WriteToConsole($"Please validate the infomation below is it correct?\nResting pulse: {restingPulse}\nMax pulse: {maxPulse}\nWeight: {weight}\nY/N?", 28);
            string key = Console.ReadKey().KeyChar.ToString();
            switch (key)
            {
                case "y":
                    break;
                case "n":
                    break;
                default:
                    Console.Clear();
                    Main();
                    break;
            }
        }
        /// <summary>
        /// Takes user input and returns it as a UInt16 and clears console
        /// </summary>
        /// <returns></returns>
        private static int ConvertFromConsole()
        {
            int value;
            try
            {
                value = Convert.ToUInt16(Console.ReadLine());
                Console.Clear();
                return value;
            }
            catch (FormatException e)
            {
                Console.Clear();
                WriteToConsole($"An error occurred make sure your input was correct.\nErrorMessage: {e.Message}\n", 28);
                WriteToConsole("Press any key to try again...", 28);
                Console.ReadKey();
                Main();
                throw;
            }
        }
        /// <summary>
        /// Writes each char from input text with a little thread.sleep() in between each char
        /// </summary>
        /// <param name="text"></param>
        /// <param name="delay"></param>
        public static void WriteToConsole(string text, int delay)
        {
            foreach (char letter in text)
            {
                Console.Write(letter);
                System.Threading.Thread.Sleep(delay);
            }
        }
    }
}

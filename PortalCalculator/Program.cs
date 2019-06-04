using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Mathcraft: A Minecraft Portal Calculator";
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("\n  * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\n" +
                          "  *   __    __     ______     ______   __  __        ______     ______     ______     ______   ______   *\n" +
                          "  *  /\\ \"-./  \\   /\\  __ \\   /\\__  _\\ /\\ \\_\\ \\      /\\  ___\\   /\\  == \\   /\\  __ \\   /\\  ___\\ /\\__  _\\  *\n" +
                          "  *  \\ \\ \\-./\\ \\  \\ \\  __ \\  \\/_/\\ \\/ \\ \\  __ \\     \\ \\ \\____  \\ \\  __<   \\ \\  __ \\  \\ \\  __\\ \\/_/\\ \\/  *\n" +
                          "  *   \\ \\_\\ \\ \\_\\  \\ \\_\\ \\_\\    \\ \\_\\  \\ \\_\\ \\_\\     \\ \\_____\\  \\ \\_\\ \\_\\  \\ \\_\\ \\_\\  \\ \\_\\      \\ \\_\\  *\n" +
                          "  *    \\/_/  \\/_/   \\/_/\\/_/     \\/_/   \\/_/\\/_/      \\/_____/   \\/_/ /_/   \\/_/\\/_/   \\/_/       \\/_/  *\n" +
                          "  *                                                                                                     *\n" +
                          "  *                                     minecraft portal calculator                                     *\n" +
                          "  *                                         by tylastrog (v1.0)                                         *\n" +
                          "  *                                                                                                     *\n" +
                          "  * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\n\n");
            Console.ResetColor();
        Start:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" Enter your dimension:\n");
            Console.Write(" > ");

            string response = Console.ReadLine();
            string _response = response.ToLower();

            switch (_response)
            {
                case "overworld":

                    Console.WriteLine("\tEnter x:");
                    Console.Write(" \t  ");
                    int overworldX = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\tEnter z:");
                    Console.Write(" \t  ");
                    int overworldZ = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\n Nether Portal: x:" + (overworldX / 8) + ", z:" + (overworldZ / 8) + "\n");

                    goto Start;

                case "nether":

                    Console.WriteLine("\tEnter x:");
                    Console.Write(" \t  ");
                    int netherX = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\tEnter z:");
                    Console.Write(" \t  ");
                    int netherZ = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\n Overworld Portal: x:" + (netherX * 8) + ", z:" + (netherZ * 8) + "\n");

                    goto Start;

                case "stop":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;

                case "exit":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\nInvalid command. Type \"help\" for a list of commands.\n\n");
                    Console.ResetColor();
                    goto Start;
            }
        }
    }
}

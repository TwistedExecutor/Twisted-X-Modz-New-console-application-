using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// This is a Free and open source project please if you're going to use this source code
/// put me in the credit of your application and if you will leave this in the code thank you that will mean a lot if you do and if you have time
/// please go look at our license agreement on our website https://twistedxmodz.com/index.php?pages/license-agreement/ thank you have have a good day
/// </summary>

namespace Twisted_X_Modz_V1
{
    class Program
    {
 
            private static int index = 0;

            private static void Main(string[] args)
            {
                List<string> menuItems = new List<string>() {
                "Main Site",
                "Exit"
            };

                Console.CursorVisible = false;
                while (true)
                {
                    string selectedMenuItem = drawMenu(menuItems);
                    if (selectedMenuItem == "Main Site")
                {
                    Console.Clear();
                    Console.WriteLine("Main Site");
                    Process.Start("https://twistedxmodz.com");
                    ///////////////////////////////////////////////////////////////////////////////////////////////

                    
                }
                    else if (selectedMenuItem == "Exit")
                    {
                        Environment.Exit(0);
                    }
                }
            }

            private static string drawMenu(List<string> items)
            {
                for (int i = 0; i < items.Count; i++)
                {
                    if (i == index)
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine(items[i]);
                    }
                    else
                    {
                        Console.WriteLine(items[i]);
                    }
                    Console.ResetColor();
                }

                ConsoleKeyInfo ckey = Console.ReadKey();

                if (ckey.Key == ConsoleKey.DownArrow)
                {
                    if (index == items.Count - 5)
                    {
                        //index = 0; //Remove the comment to return to the topmost item in the list
                    }
                    else { index++; }
                }
                else if (ckey.Key == ConsoleKey.UpArrow)
                {
                    if (index <= 0)
                    {
                        //index = menuItem.Count - 1; //Remove the comment to return to the item in the bottom of the list
                    }
                    else { index--; }
                }
                else if (ckey.Key == ConsoleKey.Enter)
                {
                    return items[index];
                }
                else
                {
                    return "";
                }

                Console.Clear();
                return "";
            }
        }
    }


﻿using System;

namespace Menu
{
    /// <summary>
    /// Aplicación de consola.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Aplicación principal.
        /// </summary>
        static void Main()
        {
            #region titulo
            string title = @"
______     _                                                                     
| ___ \   | |                                                                    
| |_/ /_ _| |_ _ __ ___  _ __   ___  ___                                         
|  __/ _` | __| '__/ _ \| '_ \ / _ \/ __|                                        
| | | (_| | |_| | | (_) | | | |  __/\__ \                                        
\_|  \__,_|\__|_|  \___/|_| |_|\___||___/                                        
                                                                                 
                                                                                 
 _____                                  _                  _            _        
/  __ \                                | |                (_)          | |       
| /  \/ ___  _ __ ___  _ __   ___  _ __| |_ __ _ _ __ ___  _  ___ _ __ | |_ ___  
| |    / _ \| '_ ` _ \| '_ \ / _ \| '__| __/ _` | '_ ` _ \| |/ _ \ '_ \| __/ _ \ 
| \__/\ (_) | | | | | | |_) | (_) | |  | || (_| | | | | | | |  __/ | | | || (_) |
 \____/\___/|_| |_| |_| .__/ \___/|_|   \__\__,_|_| |_| |_|_|\___|_| |_|\__\___/ 
                      | |                                                        
                      |_|                                                        
";
            #endregion

            #region space
            string space = @"*********************************";
            #endregion

      
            Console.WriteLine(title);

            ConsoleKeyInfo keyInfo;
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                new Client().Main();

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("¿Terminar el programa? Y/N");
                keyInfo = Console.ReadKey();
                Console.WriteLine(space);

            } while (keyInfo.Key != ConsoleKey.Y);
        }
    }
}

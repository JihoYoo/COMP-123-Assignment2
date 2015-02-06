﻿/*
 *  Author's name:Jiho Yoo
 *  Date : 2/06/2015
 *  Program description : COMP-123 062
 *  Revision History : Date         Description
 *                    1/31/2015     set a superPower and constructor Method
 *                    2/01/2015     call Hero Class to SuperHero Class
 *                    2/04/2015     Set a array to show super hero powers 
 *                    2/06/2015     make more efficient show at public void showPowers() and debug
 *                    2/06/2014     changed hero.fight() to superhero's fight();  
 *                    
 *                    
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_JihoYoo300813612_Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            // To set Hero name -----------------------------------------------------
            Hero jiho = new Hero("Jiho");

            jiho.show();

            // To creat a new superHero
            SuperHero jiho2 = new SuperHero("Jiho2");


            jiho2.showPowers();



            //ConsoleKey ------------------------------------------------------------
            string consoleKey = "";
            consoleKey = checkKey(consoleKey);


            //Keep looping until q is entered ---------------------------------------
            while (consoleKey != "q")
            {
                switch (consoleKey)
                {
                    case "q":
                        break;
                    case "r":
                        jiho2.fight();
                        consoleKey = "";
                        break;
                    default:
                        consoleKey = checkKey(consoleKey);
                        break;

                }

            }
        }
        //Method checks key entered in order to perform task
        private static string checkKey(string consoleKey)
        {
            Console.WriteLine("Press q to exit or r to roll");
            consoleKey = Console.ReadLine();
            return consoleKey;
        }

    }
}




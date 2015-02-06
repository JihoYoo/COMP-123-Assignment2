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
    class SuperHero : Hero //call Hero superclass 
    {
        //Array Super hero powers
        private string[] superPowers = { "Super Speed", "Super Strength", "Body Armour", "Flight", "Fire Generation", "Weather Control" };


        //CONSTRUCTOR METHOD: Taking the same parameter as the Hero superclass and calling Hero constructor
        public SuperHero(string name) :
            base(name)
        {
            generateRandomPowers(rnd); //call the generateRandomPowers
        }

        //Using random number 
        Random rnd = new Random();

        //Temporary array
        string[] secondArray = new string[6];

        //To generate three random superpowers
        string[] lastArray = new string[3];

        // Generate three random superpowers from the 6 powers
        private void generateRandomPowers(Random rnd)
        {
            // Copy each powers of superPowers Array to secondArray
            for (int element = 0; element < superPowers.Length; element++)
            {
                secondArray[element] = superPowers[element];
            }


            // Arrange powers except unavailable powers

            int index = 0;

            int randomPower;

            while (index < lastArray.Length)
            {
                // Generate random number
                randomPower = generateRandomPowers(rnd, superPowers.Length);

                if (secondArray[randomPower] != "No Accepted")
                {
                    lastArray[index] = secondArray[randomPower];

                    secondArray[randomPower] = "No Accepted";

                    index++;
                }


            }



        }

        //Generate Random Number
        private static int generateRandomPowers(Random rnd, int maximum)
        {
            int number;

            number = rnd.Next(maximum);

            return number;

        }

        //To show Super Powers and Random Super Powers
        public void showPowers()
        {


            int index;
            Console.WriteLine("************************");
            Console.WriteLine("*  Super  Power  List  *");
            Console.WriteLine("************************");

            // Output the list of Super Hero Powers
            for (index = 0; index < superPowers.Length; index++)
            {
                Console.WriteLine("-> {0}", superPowers[index]);
            }
            Console.WriteLine();
            Console.WriteLine("************************");
            Console.WriteLine("*  Hero's Power List   *");
            Console.WriteLine("************************");

            // Output the getting powers in each array
            for (index = 0; index < lastArray.Length; index++)
            {
                Console.WriteLine("-> {0}", lastArray[index]);


            }
            Console.WriteLine();
        }

    }
}

       
       

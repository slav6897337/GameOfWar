// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace GameOfWar
{
    using System;
    using System.IO;

    /// <summary>
    /// First Class program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Method Main Point input program.
        /// </summary>
        /// <param name="args">Console param.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter number squads in Fraction");
            int numberSquards = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter number Warriors in Squad");
            int numberWarriors = int.Parse(Console.ReadLine());

            Battle battle = new Battle(numberSquards, numberWarriors);
            battle.BattleFractionVsFraction();
           /* battle.Elves.Report();
            battle.Orcs.Report();*/
        }
    }
}

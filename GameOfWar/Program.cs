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
            Battle battle = new Battle();
            battle.PVP();
            battle.Elves.Report();
            battle.Orcs.Report();
        }
    }
}

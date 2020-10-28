// <copyright file="Fraction.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace GameOfWar
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Class Fraction.
    /// </summary>
    public class Fraction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Fraction"/> class.
        /// </summary>
        /// <param name="name">Name Fraction.</param>
        /// <param name="numberSquads">Number Squads.</param>
        /// <param name="numberWarriors">Number Warriors.</param>
        public Fraction(string name, int numberSquads, int numberWarriors)
        {
            NameFraction = name;

            for (int i = 0; i < numberSquads; i++)
            {
                string nameSquad = Console.ReadLine();
                Squads.Add(new Squad(nameSquad, numberWarriors));
            }
        }

        /// <summary>
        /// Gets or sets Name Fraction.
        /// </summary>
        public string NameFraction { get; set; }

        /// <summary>
        /// Gets or sets Squad in Squads.
        /// </summary>
        public List<Squad> Squads { get; set; } = new List<Squad>();

        /// <summary>
        /// Method report Fraction.
        /// </summary>
        public void Report()
        {
            Console.WriteLine(NameFraction);
            foreach (var squad in Squads)
            {
                squad.Report();
            }
        }
    }
}

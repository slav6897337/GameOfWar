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
        public Fraction()
        {
            Squads.Add(new Squad("squard1"));
            Squads.Add(new Squad("squard2"));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Fraction"/> class.
        /// </summary>
        /// <param name="name">Name Fraction.</param>
        public Fraction(string name)
            : this()
        {
            NameFraction = name;
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

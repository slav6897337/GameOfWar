// <copyright file="Squad.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace GameOfWar
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Class Squad(Отряд).
    /// </summary>
    public class Squad
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Squad"/> class.
        /// </summary>
        public Squad()
        {
            for (int i = 0; i < 10; i++)
            {
                Warriors.Add(new Warrior());
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Squad"/> class.
        /// </summary>
        /// <param name="name">Name Squad.</param>
        public Squad(string name)
            : this()
        {
            NameSquad = name;
        }

        /// <summary>
        /// Gets or sets Name Squad.
        /// </summary>
        public string NameSquad { get; set; }

        /// <summary>
        /// Gets or sets Warriors.
        /// </summary>
        public List<Warrior> Warriors { get; set; } = new List<Warrior>();

        /// <summary>
        /// Method report Squad.
        /// </summary>
        public void Report()
        {
            Console.WriteLine($"{NameSquad,33}");
            foreach (var warior in Warriors)
            {
                warior.Report();
            }

            Console.WriteLine();
        }
    }
}

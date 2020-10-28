// <copyright file="ShieldWarrior.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace GameOfWar
{
    using System;

    /// <summary>
    /// Class ShieldWarrior.
    /// </summary>
    public class ShieldWarrior : Warrior
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShieldWarrior"/> class.
        /// </summary>
        public ShieldWarrior()
            : base()
        {
        }

        /// <summary>
        /// Gets or sets a value indicating whether State.
        /// </summary>
        public bool State { get; set; } = true;
    }
}

// <copyright file="BerserkWarrior.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace GameOfWar
{
    using System;

    /// <summary>
    /// Class SuperWarrior.
    /// </summary>
    public class BerserkWarrior : Warrior
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BerserkWarrior"/> class.
        /// </summary>
        public BerserkWarrior()
            : base()
        {
        }

        /// <summary>
        /// Method Attack.
        /// </summary>
        /// <param name="war1">First Warrior who gets hurt.</param>
        /// <param name="war2">Second Warrior who gets hurt.</param>
        public override void Attack(Warrior war1, Warrior war2)
        {
            Attack(war1);
            if (war2.Health <= 10)
            {
                Attack(war2);
            }
        }
    }
}

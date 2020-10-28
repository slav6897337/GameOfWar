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
        /// <param name="war">Warrior who gets hurt.</param>
        /// <param name="enemySquad">Enemy Squad.</param>
        /// <param name="yourSquad">Squad in which consist.</param>
        public override void Attack(Warrior war, Squad enemySquad, Squad yourSquad)
        {
            Console.WriteLine("Berserk");
            base.Attack(war, enemySquad, yourSquad);

            Warrior war2 = enemySquad.GetRandomWarrior();
            if (war2.Health <= 10)
            {
                base.Attack(war2, enemySquad, yourSquad);
            }
        }
    }
}

// <copyright file="Battle.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace GameOfWar
{
    using System;

    /// <summary>
    /// Class Battle.
    /// </summary>
    public class Battle
    {
        private Random rand = new Random();

        /// <summary>
        /// Gets or sets fraction Orcs.
        /// </summary>
        public Fraction Orcs { get; set; } = new Fraction(nameof(Orcs));

        /// <summary>
        /// Gets or sets fraction Elves.
        /// </summary>
        public Fraction Elves { get; set; } = new Fraction(nameof(Elves));

        /// <summary>
        /// Method PVP.
        /// </summary>
        public void PVP()
        {
            Warrior wr1 = GetRandomWarrior(Orcs);
            Warrior wr2 = GetRandomWarrior(Elves);
            bool who = false;
            do
            {
                if (who)
                {
                    Attack(wr1, wr2);
                }
                else
                {
                    Attack(wr2, wr1);
                }

                who = !who;
            }
            while (wr1.Health >= 0 && wr1.Health >= 0);
        }

        /// <summary>
        /// Gets random warrior of random squad.
        /// </summary>
        /// <param name="fraction">Fraction.</param>
        /// <returns>Warrior.</returns>
        public Warrior GetRandomWarrior(Fraction fraction)
        {
            int squadsIndex = rand.Next(0, 1);
            int warriorsIndex = rand.Next(0, fraction.Squads[squadsIndex].Warriors.Count);
            return fraction.Squads[squadsIndex].Warriors[warriorsIndex];
        }

        /// <summary>
        /// Method Attack.
        /// </summary>
        /// <param name="war1">Warrior who attack.</param>
        /// <param name="war2">Warrior who gets hurt.</param>
        public void Attack(Warrior war1, Warrior war2)
        {
            int damage = rand.Next(1, war1.Attack) + war1.Strong;
            war2.Health -= damage;
            Console.WriteLine($"{war1.Name} damage {damage} from {war2.Name} who has left {war2.Health}");
            Console.WriteLine();
        }
    }
}

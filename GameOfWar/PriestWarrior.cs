// <copyright file="PriestWarrior.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace GameOfWar
{
    using System;

    /// <summary>
    /// Class PriestWarrior.
    /// </summary>
    public class PriestWarrior : Warrior
    {
        private byte counter = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="PriestWarrior"/> class.
        /// </summary>
        public PriestWarrior()
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
            base.Attack(war, enemySquad, yourSquad);
            if (counter != 0)
            {
                counter = counter == 3 ? (byte)0 : (byte)(counter + 1);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Priest reset");
            }
            else
            {
                int minHeath = 20;
                int count = 0;
                int warCount = 0;
                foreach (var warrior in yourSquad.Warriors)
                {
                    if (warrior.Health < minHeath)
                    {
                        minHeath = warrior.Health;
                        warCount = count;
                    }

                    count++;
                }

                if (minHeath < 20)
                {
                    yourSquad.Warriors[warCount].Health += 40;
                    counter++;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Priest Regained health {yourSquad.Warriors[warCount].Name}");
                }
            }
        }
    }
}

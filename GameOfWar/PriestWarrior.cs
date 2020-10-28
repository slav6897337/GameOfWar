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
        /// Method Heal.
        /// </summary>
        /// <param name="war">Squad in which consist.</param>
        /// <param name="squad">Warrior who gets hurt.</param>
        public override void Attack(Warrior war, Squad squad)
        {
            Attack(war);
            if (counter != 0)
            {
                counter = counter == 3 ? (byte)0 : (byte)(counter + 1);
            }
            else
            {
                int minHeath = 20;
                int count = 0;
                int warCount = 0;
                foreach (var warrior in squad.Warriors)
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
                    squad.Warriors[warCount].Health += 60;
                    counter++;
                }
            }
        }
    }
}

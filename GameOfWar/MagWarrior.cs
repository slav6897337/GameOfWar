// <copyright file="MagWarrior.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace GameOfWar
{
    using System;

    /// <summary>
    /// Class MagWarrior.
    /// </summary>
    public class MagWarrior : Warrior
    {
        private byte counter = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="MagWarrior"/> class.
        /// </summary>
        public MagWarrior()
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
            Console.WriteLine("Mag");
            if (counter != 0)
            {
                counter = counter == 3 ? (byte)0 : (byte)(counter + 1);
                int minHealhth = 50;
                int count = 0;
                int wariorCount = 0;
                foreach (var warior in enemySquad.Warriors)
                {
                    if (warior.Health < minHealhth)
                    {
                        minHealhth = warior.Health;
                        wariorCount = count;
                    }

                    count++;
                }

                base.Attack(enemySquad.Warriors[wariorCount], enemySquad, yourSquad);
            }
            else
            {
                if (enemySquad.Warriors.Count > 3)
                {
                    int i = 0;
                    for (; i < enemySquad.Warriors.Count; i++)
                    {
                        if (enemySquad.Warriors[i] == war)
                        {
                            break;
                        }

                        if (i == 0)
                        {
                            base.Attack(enemySquad.Warriors[0], enemySquad, yourSquad);
                            base.Attack(enemySquad.Warriors[1], enemySquad, yourSquad);
                            base.Attack(enemySquad.Warriors[2], enemySquad, yourSquad);
                            counter++;
                        }
                        else if (i == enemySquad.Warriors.Count - 1)
                        {
                            base.Attack(enemySquad.Warriors[i], enemySquad, yourSquad);
                            base.Attack(enemySquad.Warriors[i - 1], enemySquad, yourSquad);
                            base.Attack(enemySquad.Warriors[i - 2], enemySquad, yourSquad);
                            counter++;
                        }
                        else
                        {
                            base.Attack(enemySquad.Warriors[i], enemySquad, yourSquad);
                            base.Attack(enemySquad.Warriors[i - 1], enemySquad, yourSquad);
                            base.Attack(enemySquad.Warriors[i + 1], enemySquad, yourSquad);
                            counter++;
                        }
                    }
                }
                else
                {
                    foreach (var warrior in enemySquad.Warriors)
                    {
                        base.Attack(warrior, enemySquad, yourSquad);
                    }

                    counter++;
                }
            }
        }
    }
}

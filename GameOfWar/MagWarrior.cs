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
        /// <param name="war1">Warrior who gets hurt.</param>
        /// <param name="squad">Enemy Squad.</param>
        public override void Attack(Warrior war1, Squad squad)
        {
            if (counter != 0)
            {
                counter = counter == 3 ? (byte)0 : (byte)(counter + 1);
                int minHealhth = 50;
                int count = 0;
                int wariorCount = 0;
                foreach (var warior in squad.Warriors)
                {
                    if (warior.Health < minHealhth)
                    {
                        minHealhth = warior.Health;
                        wariorCount = count;
                    }

                    count++;
                }

                Attack(squad.Warriors[wariorCount]);
            }
            else
            {
                if (squad.Warriors.Count > 3)
                {
                    int i = 0;
                    for (; i < squad.Warriors.Count; i++)
                    {
                        if (squad.Warriors[i] == war1)
                        {
                            break;
                        }

                        if (i == 0)
                        {
                            Attack(squad.Warriors[0]);
                            Attack(squad.Warriors[1]);
                            Attack(squad.Warriors[2]);
                            counter++;
                        }
                        else if (i == squad.Warriors.Count - 1)
                        {
                            Attack(squad.Warriors[i]);
                            Attack(squad.Warriors[i - 1]);
                            Attack(squad.Warriors[i - 2]);
                            counter++;
                        }
                        else
                        {
                            Attack(squad.Warriors[i]);
                            Attack(squad.Warriors[i - 1]);
                            Attack(squad.Warriors[i + 1]);
                            counter++;
                        }
                    }
                }
                else
                {
                    foreach (var warrior in squad.Warriors)
                    {
                        Attack(warrior);
                    }

                    counter++;
                }
            }
        }
    }
}

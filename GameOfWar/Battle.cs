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
        /// Initializes a new instance of the <see cref="Battle"/> class.
        /// </summary>
        /// <param name="numberSquards">Number Squads.</param>
        /// <param name="numberWarriors">Number Warriors.</param>
        public Battle(int numberSquards, int numberWarriors)
        {
            Orcs = new Fraction(nameof(Orcs), numberSquards, numberWarriors);
            Elves = new Fraction(nameof(Elves), numberSquards, numberWarriors);
        }

        /// <summary>
        /// Gets or sets fraction Orcs.
        /// </summary>
        public Fraction Orcs { get; set; }

        /// <summary>
        /// Gets or sets fraction Elves.
        /// </summary>
        public Fraction Elves { get; set; }

        /// <summary>
        /// Method Battle Squad Vs Squad.
        /// </summary>
        public void BattleSquadVsSquad()
        {
            Squad orc = Orcs.GetRandomSquad();
            Squad elv = Elves.GetRandomSquad();

            while (orc.Warriors.Count > 0 && elv.Warriors.Count > 0)
            {
                for (int i = 0; i < orc.Warriors.Count && i < elv.Warriors.Count; i++)
                {
                    orc.Warriors[i].Attack(elv.Warriors[i], elv, orc);
                    if (elv.Warriors[i].Health <= 0)
                    {
                        LostWarrior(elv.Warriors[i], Elves);
                        if (i + 1 < elv.Warriors.Count)
                        {
                            elv.Warriors[i + 1].Attack(orc.Warriors[i], orc, elv);
                        }
                        else
                        {
                            if (elv.Warriors.Count != 0)
                            {
                                elv.Warriors[0].Attack(orc.Warriors[i], orc, elv);
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    else
                    {
                        elv.Warriors[i].Attack(orc.Warriors[i], orc, elv);
                    }

                    if (orc.Warriors[i].Health <= 0)
                    {
                        LostWarrior(orc.Warriors[i], Orcs);
                    }
                }
            }

            if (elv.Warriors.Count > 0)
            {
                Console.WriteLine("\nElves WIN \nheroes left:");
                elv.Report();
            }
            else
            {
                Console.WriteLine("\nOrcs WIN \nheroes left:");
                orc.Report();
            }
        }

        /// <summary>
        /// Method PVP.
        /// </summary>
        public void PVP()
        {
            Squad orc = Orcs.GetRandomSquad();
            Squad elv = Elves.GetRandomSquad();

            Warrior wr1 = orc.GetRandomWarrior();
            Warrior wr2 = elv.GetRandomWarrior();
            bool who = false;
            while (wr1.Health >= 0 && wr2.Health >= 0)
            {
                if (who)
                {
                    wr1.Attack(wr2, elv, orc);
                }
                else
                {
                    wr2.Attack(wr1, orc, elv);
                }

                who = !who;
            }

            if (wr1.Health <= 0)
            {
                LostWarrior(wr1, Orcs);
            }
            else
            {
                LostWarrior(wr2, Elves);
            }
        }

        /// <summary>
        /// Method remove Warrior who health. <= 0.
        /// </summary>
        /// <param name="warrior">Warrior remove.</param>
        /// <param name="fraction">Fraction who lost warrior.</param>
        public void LostWarrior(Warrior warrior, Fraction fraction)
        {
            foreach (var squad in fraction.Squads)
            {
                foreach (var war in squad.Warriors)
                {
                    if (warrior == war)
                    {
                        squad.Warriors.Remove(warrior);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"{fraction.NameFraction} lost warrior {warrior.Name}");
                        Console.ResetColor();
                        return;
                    }
                }
            }
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
    }
}

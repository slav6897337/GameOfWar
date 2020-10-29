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
        private Random rand = new Random();

        /// <summary>
        /// Initializes a new instance of the <see cref="Squad"/> class.
        /// </summary>
        /// <param name="nameSquad">Name Squad.</param>
        /// <param name="quantityWarriors">Quantity Warriors in squad.</param>
        public Squad(string nameSquad, int quantityWarriors)
        {
            NameSquad = nameSquad;

            int temp = rand.Next(0, quantityWarriors);
            int bers = temp;
            int prist = temp;
            int mag = temp;
            int shield = temp;
            while (bers == prist)
            {
                temp = rand.Next(0, quantityWarriors);
                prist = temp;
            }

            while (bers == mag || prist == mag)
            {
                temp = rand.Next(0, quantityWarriors);
                mag = temp;
            }

            while (bers == shield || prist == shield || mag == shield)
            {
                temp = rand.Next(0, quantityWarriors);
                shield = temp;
            }

            for (int i = 0; i < quantityWarriors; i++)
            {
                if (i == bers)
                {
                    Warriors.Add(new BerserkWarrior());
                }

                if (i == prist)
                {
                    Warriors.Add(new PriestWarrior());
                }

                if (i == mag)
                {
                    Warriors.Add(new MagWarrior());
                }

                if (i == shield)
                {
                    Warriors.Add(new ShieldWarrior());
                }

                Warriors.Add(new Warrior());
            }
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
                if (warior is ShieldWarrior wr)
                {
                    wr.State = true;
                }
            }

            Console.WriteLine();
        }

         /// <summary>
        /// Gets random warrior in squad.
        /// </summary>
        /// <returns>Warrior.</returns>
        public Warrior GetRandomWarrior()
        {
            return Warriors[rand.Next(0, Warriors.Count - 1)];
        }
    }
}

// <copyright file="Warrior.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace GameOfWar
{
    using System;
    using System.IO;

    /// <summary>
    /// Class Warrior(Боец).
    /// </summary>
    public class Warrior
    {
        private static byte counter = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="Warrior"/> class.
        /// </summary>
        public Warrior()
        {
            Random rnd = new Random();

            Health = 50 + rnd.Next(1, 30);
            Attack = 6 + rnd.Next(1, 6);
            Strong = 1 + rnd.Next(0, 4);
            Name = GetNameWarior();
        }

        /// <summary>
        /// Gets or sets Name Warrior.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Health Warrior.
        /// </summary>
        public int Health { get; set; }

        /// <summary>
        /// Gets or sets Attack Warrior.
        /// </summary>
        public int Attack { get; set; }

        /// <summary>
        /// Gets or sets Strong Warrior.
        /// </summary>
        public int Strong { get; set; }

        /// <summary>
        /// Method report Warrior.
        /// </summary>
        public void Report()
        {
            Console.WriteLine($"{Name,-16} Health:{Health}\tAttack:{Attack}\tStrong:{Strong}");
        }

        private string GetNameWarior()
        {
            StreamReader sr = new StreamReader("Names.txt", System.Text.Encoding.Default);
            string temp = string.Empty;
            for (int i = 0; i <= counter; i++)
            {
                temp = sr.ReadLine();
            }

            counter++;
            if (counter == 10)
            {
                counter = 0;
            }

            return temp;
        }
    }
}

﻿using EvoNet.AI;
using System;

namespace EvoNet
{
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            NeuronalNetworkTest.Test();
            using (var game = new EvoGame())
                game.Run();
        }
    }
}

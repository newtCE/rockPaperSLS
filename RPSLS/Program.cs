﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            GameLoop newGame = new GameLoop();
            newGame.SelectGameMode();
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Bird
    {
        public virtual void Move()
        {
            Console.WriteLine("Birds Fly");
        }
    }

    class Penguin : Bird
    {
        public override void Move()
        {
            Console.WriteLine("Penguins Waddle");
        }
    }
}

// Bird bird = new Bird();
// bird.Move();
// Console.WriteLine("");

// Penguin penguin = new Penguin();
// penguin.Move();
// Console.WriteLine("");

// Bird penguinBird = new Penguin();
// penguinBird.Move();
// Console.WriteLine("");

﻿using Immortality_Quest.Elements.Classes;
using Immortality_Quest.Elements.Interfaces;

namespace Immortality_Quest;

class Program
{
    static void Main(string[] args)
    {
        //Generate first map 
        Map level = new Map();

        level.GenerateMap(); 
        level.PrintMap();

        Console.ReadLine(); 
    }
}

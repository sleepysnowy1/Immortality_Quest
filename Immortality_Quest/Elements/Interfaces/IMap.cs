using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Immortality_Quest.Elements.Classes;
using Immortality_Quest.Elements;

namespace Immortality_Quest.Elements.Interfaces
{
    internal interface IMap
    {
        public int X { get; }
        public int Y { get; }
        public Tiles[,] Level { get; set; }

        public void GenerateMap();

        public void PrintMap();
    }
}

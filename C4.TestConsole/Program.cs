using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C4.GridBuilder;
using C4.GridBuilder.Interfaces;
using C4.Model;

namespace C4.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IGridGenerator<Tile> gridGenerator = new GridGenerator<Tile>();
            Tile[,] grid = gridGenerator.GetGrid(6, 7);
            Console.ReadLine();
        }
    }
}

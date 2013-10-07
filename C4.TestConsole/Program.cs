using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C4.Logic;
using C4.Model;
using C4.UnitTests;

namespace C4.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var gridG = new GridGenerator<Tile>();
            var grid = Mother.GetGridOneTokenOffBeingFull();
            var flat = grid.Cast<Tile>().ToArray();
            int count = flat.Count(x => x.GameToken == GameToken.Undefined);
            
            Console.ReadLine();
        }
    }
}

using System;
using System.Linq;
using C4.Logic;
using C4.Model;

namespace TestConsole
{
    class Program
    {
        static void Main()
        {
            var sut = Game.GetGameInstance(new GridGenerator<Tile>());
            sut.TakeMove(0);
            var grid = sut.Gameboard;
            Tile[] tiles = grid.Cast<Tile>().Take(6).ToArray();
            Console.ReadKey();
        }
    }
}

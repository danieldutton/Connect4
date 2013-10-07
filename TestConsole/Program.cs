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
            bool wasCalled = false;
            sut.ColumnFull += (o, e) => wasCalled = true;

            sut.TakeMove(1);
            sut.TakeMove(1);
            sut.TakeMove(1);
            sut.TakeMove(1);
            sut.TakeMove(1);
            sut.TakeMove(1);
            sut.TakeMove(1);

            var grid = sut.Gameboard.Cast<Tile>().Take(5).ToArray();
            Console.ReadKey();
        }
    }
}

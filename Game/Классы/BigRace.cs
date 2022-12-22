using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Game.Классы
{
    class BigRace
    {
        public void StartGame(List<Team> teams)
        {
            Game game = new Game(teams);
            game.ChoiceGame(new Beach());
            game.PlayGame();
            game.ChoiceGame(new Fishing());
            game.PlayGame();
            game.ChoiceGame(new Postman());
            game.PlayGame();
            game.ChoiceGame(new MouseTrap());
            game.PlayGame();
            game.ChoiceGame(new See());
            game.PlayGame();
            game.ChoiceGame(new Slide());
            game.PlayGame();
            game.ChoiceGame(new MyGame());
            game.PlayGame();
            game.PrintResults();
            game.Winner();
            Console.ReadLine();
        }
    }
}

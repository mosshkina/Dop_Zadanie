using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Классы
{
    internal class Game
    {
        public IGame game { get; set; }
        public List<Team> teams { get; set; }

        public Game(List<Team> teams)
        {
            this.teams = teams;
        }
        public void ChoiceGame(IGame game)
        {
            this.game = game;
        }

        public void PlayGame()
        {
            game.Play(teams);
        }

        public void PrintResults()
        {
            for (int i = 0; i < teams.Count; i++)
            {
                Console.WriteLine($"У команды {teams[i].team}: {teams[i].points} балла(ов)");

            }
            Console.WriteLine("Игра закончилась! Подведем итоги..\tНажмите на любую клавишу, чтобы узнать результатаы соревнования!");
        }
        public void Winner()
        {

            int max = 0;
            string winner = "";
            for (int i = 0; i < teams.Count; i++)
            {

                if (max < teams[i].points)
                {
                    max = teams[i].points;
                    winner = teams[i].team;
                }
            }
            Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\tПобедила команда <<{winner}>> c {max} баллами!!");
            Console.ResetColor();
        }
    }
}

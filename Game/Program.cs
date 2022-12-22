using Game.Классы;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        static bool IsThisTeamAppropriate(List<string> Teams, string team)
        {
            foreach (string element in Teams)
            {
                if (team == element)
                {
                    return true;
                }
            }
            return false;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("\tПриближается новый год, начинаются <<Большие гонки>>. \nОливье Ганьян, ваше время пришло!");
            List<string> countries = new List<string>
            {
                "Россия", "Франция", "Китай", "Украина"
            };
            List<Team> teams = new();
            Console.WriteLine();
            Console.Write("Команду какой страны вы хотите сформировать? ");

            for (int i = 0; i < countries.Count; i++)
            {
                Console.Write("Команду какой страны вы хотите сформировать? ");
                string country = Console.ReadLine();
                while (!IsThisTeamAppropriate(countries, country))
                {
                    Console.Write("Этой страны нет в списке желающих. Повторите ввод: ");
                    country = Console.ReadLine();
                }
                if (IsThisTeamAppropriate(countries, country))
                {
                    Console.WriteLine("Команда добавлена в список участников");
                    Team team = new Team(country, 0);
                    teams.Add(team);

                }
            }
            Console.WriteLine("Поздравляем, Оливье! Список команд готов. Да начнутся <<Большие гонки>>!");
            Console.ReadLine();
            Console.Clear();
            BigRace bigRides = new BigRace();
            bigRides.StartGame(teams);
            Console.ReadLine();
        }

    }
}

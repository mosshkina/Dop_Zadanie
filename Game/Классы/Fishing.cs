using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Классы
{
    class Fishing : IGame
    {
        static Random random = new Random();
        public void Play(List<Team> teams)
        {
            int rand1 = random.Next(4);
            int rand2 = random.Next(4);
            while (rand1 == rand2)
            {
                rand2 = random.Next(4);
            }
            Console.WriteLine("Начинается игра <<Рыбылка>>");
            Console.WriteLine($"Лидируюшая команда-<<{teams[rand1].team}>>, команада <<{teams[rand2].team}>> пока отстает. Кто же одержит победу?");
            for (int i = 0; i < teams.Count; i++)
            {
                int rand = random.Next(1, 10);
                Console.WriteLine($"Команда {teams[i].team} получила {rand} очков");
                teams[i].points += rand;
            }
            Console.WriteLine();
        }
    }
}

using System;

namespace LegendaryHeroes
{
    class Program
    {
        class Player
        {
            string name;
            int hp;

            public Player(string _name)
            {
                name = _name;
                Random rnd = new Random();
                hp = rnd.Next(100, 151);
            }

            public string Name
            {
                get { return name; }
            }

            public int HP
            {
                get { return hp; }
            }

            public int MakeDamage()
            {
                Random rnd = new Random();
                return rnd.Next(10, 51);
            }

            public void TakeDamage(int damage)
            {
                if(hp <= 0)
                {
                    hp = 0;
                } else
                {
                    hp -= damage;
                }
            }

        }

        static void Main(string[] args)
        {
            Player Arnold = new Player("Arnold Schwarzenegger");
            Player Chuck = new Player("Chuck Norris");

            for(int i = 0; i <3; i++)
            {
                Arnold.TakeDamage(Chuck.MakeDamage());
                Chuck.TakeDamage(Arnold.MakeDamage());
                Console.WriteLine($"Arnold {Arnold.HP}");
                Console.WriteLine($"Chuck {Chuck.HP}");
            }

            if(Arnold.HP > Chuck.HP)
            {
                Console.WriteLine($"Arnold is the winner with {Arnold.HP} left.");
            } else if(Chuck.HP > Arnold.HP)
            {
                Console.WriteLine($"Chuck is the winner with {Chuck.HP} left.");
            } else
            {
                Console.WriteLine("It's a tie!");
            }

            Console.ReadLine();
        }
    }
}

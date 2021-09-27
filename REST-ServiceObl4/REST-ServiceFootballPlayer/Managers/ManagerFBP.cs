using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary_FootballPlayer;

namespace REST_ServiceFootballPlayer.Managers
{
    public class ManagerFBP:IManagersFBP 
    {
        private static readonly List<FootballPlayer> players = new List<FootballPlayer>()
        {
            new FootballPlayer(1, "Peter", 1000, 20),
            new FootballPlayer(2, "Bjerne", 2635, 38),
            new FootballPlayer(3, "Søren", 235, 27),
            new FootballPlayer(4, "Peter", 20366650, 2),
            new FootballPlayer(5, "Henrik", 463573, 1)
        };

        public IEnumerable<FootballPlayer> Get()
        {
            return new List<FootballPlayer>(players);
        }

        public FootballPlayer Get(int id)
        {
            return players.Find(p => p.Id == id);
        }

        public bool Create(FootballPlayer value)
        {
            players.Add(value);
            return true;
        }
        public bool Update(int id, FootballPlayer value)
        {
            FootballPlayer player = Get(id);
            if (player != null)
            {
                player.Id = value.Id;
                player.Name = value.Name;
                player.Price = value.Price;
                player.ShirtNumber = value.ShirtNumber;

                return true;
            }

            return false;
        }

        public FootballPlayer Delete(int id)
        {
            FootballPlayer player = Get(id);
            players.Remove(player);
            return player;
        }
    }
}

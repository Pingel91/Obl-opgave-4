using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary_FootballPlayer;

namespace REST_ServiceFootballPlayer.Managers
{
    public interface IManagersFBP
    {
        IEnumerable<FootballPlayer> Get();
        FootballPlayer Get(int id);
        bool Create(FootballPlayer value);
        bool Update(int id, FootballPlayer value);
        FootballPlayer Delete(int id);
    }
}

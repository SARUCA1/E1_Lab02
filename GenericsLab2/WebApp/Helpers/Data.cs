using WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Helpers
{
    public class Data
    {
        private static Data _instance = null;
        public static Data Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new Data();
                }
                return _instance;
            }
        }
        public List<TeamModel> TeamList = new List<TeamModel>
        {
            new TeamModel
            {
                TeamName = "100 Thieves",
                PlayerName = "Milan",
                PlayerLastN = "Oleksij",
                Role = "Top Laner",
                KDA = 3,
                CreepScore = 191,
            }
        };
    }
}

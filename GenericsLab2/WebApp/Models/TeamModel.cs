using WebApp.Helpers;
using System;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class TeamModel
    {
        public string TeamName { get; set; }
        public string PlayerName { get; set; }
        public string PlayerLastN { get; set; }
        public string Role { get; set; }
        public double KDA { get; set; }
        public int CreepScore { get; set; }
    }
    //public static bool Save(TeamModel model)
    //{
    //    Data.Instance.TeamList.Add(model);
    //    return false;
    //}
    //public static bool Edit(TeamModel model)
    //{
    //    throw new NotImplementedException();
    //}
}

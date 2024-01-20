using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class Team
    {
        public Team(string teamName, int noOfPlayers)
        {
            this.teamName = teamName;
            this.noOfPlayers = noOfPlayers;
        }
        public string teamName { get; set; }
        public int noOfPlayers { get; set; }

        public int AddPlayer(int count)
        {
            return this.noOfPlayers=this.noOfPlayers + count;
        }
        public bool RemovePlayer(int count)
        {
            

            if(this.noOfPlayers - count < 0)
            {
                return false;
            }
            else
            {
                this.noOfPlayers = this.noOfPlayers - count;
                return true;
            }
        }
    }

    public class Subteam : Team
    {
        public Subteam(string teamName, int noOfPlayers) :base( teamName, noOfPlayers)
        { }

        public void ChangeTeamName(string name)
        {
            this.teamName=name;
        }
    }
}

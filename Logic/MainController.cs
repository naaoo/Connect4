using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class MainController
    {
        public Connect4Entities data = new Connect4Entities();
        static MainController instance = null;
        public Action update;


        public static MainController GetInstance()
        {
            if (instance == null)
            {
                instance = new MainController();
            }
            return instance;
        }

        public void AddPlayer(string playerName)
        {
            data.Player.Add(new Player() { name = playerName });
            data.SaveChanges();
            update.Invoke();
        }

        public List<Player> GetPlayers(bool inclCPU)
        {
            if (inclCPU)
            {
                return data.Player.ToList();
            }
            else
            {
                return data.Player.Where(x => x.name != "CPU").ToList();
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorTestMain.Shared
{
    public class Game
    {
        public int GameID { get; set; }
        public string Title { get; set; }
        public DateTime DateCreated { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
    }
}

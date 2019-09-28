using System;
using System.Collections.Generic;

namespace gameApi.Models
{
    public partial class Player
    {
        public Player()
        {
            Winner = new HashSet<Winner>();
        }

        public int Id { get; set; }
        public string Username { get; set; }

        public ICollection<Winner> Winner { get; set; }
    }
}

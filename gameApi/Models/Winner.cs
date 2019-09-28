using System;
using System.Collections.Generic;

namespace gameApi.Models
{
    public partial class Winner
    {
        public int Id { get; set; }
        public short Score { get; set; }
        public short Round { get; set; }
        public int Username { get; set; }

        public Player UsernameNavigation { get; set; }
    }
}

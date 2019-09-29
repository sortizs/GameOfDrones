namespace GameDronesServices.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Winner")]
    public partial class Winner
    {
        public int Id { get; set; }

        public short Score { get; set; }

        public short Round { get; set; }

        public int Username { get; set; }

        public virtual Player Player { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PIIT_PRACTICAL.Models
{
    public enum MarketStatus
    {
        Active = 1, 
        Deactive = 2
    }
    public class Market
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public virtual ICollection<Coin> Coins { get; set; }

    }
}
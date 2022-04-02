using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PIIT_PRACTICAL.Models
{
    public enum CoinStatus
    {
        Active = 1, 
        Deactive = 2
    }
    public class Coin
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string BaseAsset { get; set; }
        [Required]
        public string QouteAsset { get; set; }
        [Required]
        public double LastPrice { get; set; }
        [Required]
        public double Volume24h { get; set; }
        [Required]
        public int MarketId { get; set; }
        public virtual Market Market { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
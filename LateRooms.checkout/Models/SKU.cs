using System;
namespace LateRooms.checkout.Models
{
    public class SKU
    {

        public string SKUCode{ get; set; }

        public decimal UnitPrice { get; set; }

        public decimal SpecialPrice { get; set; }

        public int SpecialPriceMultiplier { get; set; }

    }
}

using System;
namespace LateRooms.checkout.Models
{
    public class SKU
    {

        public string SKUCode{ get; set; }

        public int UnitPrice { get; set; }

        public int? SpecialPrice { get; set; }

        public int SpecialPriceMultiplier { get; set; }

    }
}

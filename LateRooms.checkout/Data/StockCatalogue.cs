using System;
using System.Collections.Generic;

namespace LateRooms.checkout.Data
{
    //setup some data for a stock catalogue.
    //normally, this would be coming from a database
    //or a service
    public class StockCatalogue
    {

        public List<Models.SKU> Items { get; private set; }


        public StockCatalogue()
        {
            generateExampleData();
        }


        void generateExampleData() {

            Items = new List<Models.SKU> {

             new Models.SKU{ SKUCode="A", UnitPrice=50, SpecialPrice=130, SpecialPriceMultiplier=3},
             new Models.SKU{ SKUCode="B", UnitPrice=30, SpecialPrice=45, SpecialPriceMultiplier=2},
             new Models.SKU{ SKUCode="C", UnitPrice=20},
             new Models.SKU{ SKUCode="D", UnitPrice=15},
             };
        }

    }
}

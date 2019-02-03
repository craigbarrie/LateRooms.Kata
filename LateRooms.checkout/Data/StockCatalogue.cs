using System;
using System.Collections.Generic;

namespace LateRooms.checkout.Data
{
    //setup some data for a stock catalogue.
    //normally, this would be coming from a database
    //or a service
    public class StockCatalogue
    {

        public List<Models.SKU> Items { get; }


        public StockCatalogue()
        {
        }
    }
}

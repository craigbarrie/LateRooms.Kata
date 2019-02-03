using System;
using System.Collections.Generic;
using System.Linq;

namespace LateRooms.checkout.Models
{
    public class Basket
    {
        public List<BasketItem> Items{get;set;}

        public Basket() {
            InitBasket();
        }

        void InitBasket() {
            Items = new List<BasketItem>();
        }

        public void Scan(string item) {
            AddItemToBasket(item);
        }

        public int GetTotalPrice() {

            //TODO:
            throw new NotImplementedException();
        
        }


        void AddItemToBasket(string sku) {
            BasketItem basketItem =  Items.FirstOrDefault(i => i.SKU == sku);

            if (basketItem != null) {
                basketItem.Quantity += 1;
            }
            else {
                basketItem = new BasketItem { SKU = sku, Quantity = 1 };
                Items.Add(basketItem);
            }

            calculateRowTotal(basketItem);

        }


        void calculateRowTotal(BasketItem basketItem) {
            //lookup part from catalogue

            SKU sku = Data.StockCatalogue.Items.FirstOrDefault(item => item.SKUCode == basketItem.SKU);

            if (sku.SpecialPrice != null)
            {
                var x = basketItem.Quantity / sku.SpecialPriceMultiplier;  // gives us x lots at the special price
                var y = basketItem.Quantity % sku.SpecialPriceMultiplier; // gives us y quantity at the regular price.
                basketItem.RowTotal = (x * Convert.ToInt32(sku.SpecialPrice)) + (y * sku.UnitPrice);
            }
            else { 
                basketItem.RowTotal = basketItem.Quantity * sku.UnitPrice; //no special offer.
            }
        }
    }
}

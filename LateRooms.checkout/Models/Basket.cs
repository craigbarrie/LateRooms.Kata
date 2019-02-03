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

            //TODO:

            //lookup part from catalogue

            //calculate row based on current qty.

            throw new NotImplementedException();

        }


    }
}

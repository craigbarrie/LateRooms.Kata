using System;
using System.Collections.Generic;

namespace LateRooms.checkout.Models
{
    public class Basket
    {
        public List<BasketItem> Items{get;set;}

        Basket() {
            InitBasket();
        }

        void InitBasket() {
            Items = new List<BasketItem>();
        }

        public void Scan(string item) { 
        
        }

        public int GetTotalPrice() {

            //TODO:
            throw new NotImplementedException();
        
        }



    }
}

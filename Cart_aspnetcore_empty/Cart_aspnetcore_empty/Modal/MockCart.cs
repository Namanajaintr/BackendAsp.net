using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cart_aspnetcore_empty.Modal
{
    
    public class MockCart : ICart
    {

        private List<Cart> cartitems = new List<Cart>();
      //  List<string> salmons ={ "chinook", "coho", "pink", "sockeye" };
      //string[] Payment_Mode= { "BHIM", "UPI", "BANK", "COD" };

        public MockCart() {
            //string[] payments = new string[4];
            //payments[0] = "BHIM";
            //payments[1]= "UPI";
            //payments[2] = "COD";
            //payments[3] = "BANK";

            //var salmons = new List<string> { "chinook", "coho", "pink", "sockeye" };
            cartitems.Add(new Cart() { Product_Id = 123, Product_Name = "Matte", Product_Price = 768, Product_Qty = 2, Payment_Mode = new string[] { "BHIM", "UPI", "BANK", "COD" }, Product_Type = new string[] { "accessories", "groceries", "sationary" }});
            cartitems.Add(new Cart() { Product_Id = 345, Product_Name = "Dress", Product_Price = 8789, Product_Qty = 1 , Payment_Mode = new string[] { "BHIM", "UPI", "BANK", "COD" }, Product_Type = new string[] { "accessories", "groceries", "sationary" } });
            cartitems.Add(new Cart() { Product_Id = 567, Product_Name = "vessel", Product_Price = 34, Product_Qty = 3 , Payment_Mode = new string[] { "BHIM", "UPI", "BANK", "COD" }, Product_Type = new string[] { "accessories", "groceries", "sationary" } });
            cartitems.Add(new Cart() { Product_Id = 789, Product_Name = "pens", Product_Price = 345, Product_Qty = 30 , Payment_Mode = new string[] { "BHIM", "UPI", "BANK", "COD" }, Product_Type = new string[] { "accessories", "groceries", "sationary" } });
            cartitems.Add(new Cart() { Product_Id = 901, Product_Name = "mixer", Product_Price = 6784, Product_Qty = 1 , Payment_Mode = new string[] { "BHIM", "UPI", "BANK", "COD" }, Product_Type = new string[] { "accessories", "groceries", "sationary" } });

        }
        Cart ICart.getCartDetails(int Product_Id) {
            return this.cartitems.FirstOrDefault(p => p.Product_Id == Product_Id);

        }

        public IEnumerable<Cart> GetAllCarts() {
            return cartitems;
        }

    }
}

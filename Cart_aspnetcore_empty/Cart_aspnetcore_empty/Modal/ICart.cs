using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cart_aspnetcore_empty.Modal
{
   public  interface ICart
    {
        public Cart getCartDetails(int Product_Id);
        public IEnumerable<Cart> GetAllCarts();
    }
}

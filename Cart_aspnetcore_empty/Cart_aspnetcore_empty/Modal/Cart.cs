using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cart_aspnetcore_empty.Modal
{
    public class Cart
    {
        public int Product_Id { get; set; }
        public string Product_Name { get; set; }

        public string[] Payment_Mode { get; set; }
        //public List<string> salmons = new List<string>();

        public int Product_Price { get; set; }
        public int Product_Qty { get; set; }

        public string[] Product_Type { get; set; }


    }
}

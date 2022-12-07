using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cart_aspnetcore_empty.Modal;

namespace Cart_aspnetcore_empty.ViewModal
{
    public class HomeIndex1ViewModal
    {
        //VIEWMODEL : The view which binds to a specific type of view model is strongly typed view
        public IEnumerable<Cart> Cart { get; set; }
        public string Title { get; set; }
    }
}

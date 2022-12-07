using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecart_CRUD.Models
{
    public class Cart
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CartId { get; set; }
        public string CartItem { get; set; }

        [Display(Name = "Products")]
        public virtual int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public virtual Products Products { get; set; }

    }
}

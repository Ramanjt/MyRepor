using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRepor.Core.Models
{
    // main class is base entity 
    public class Basket: BaseEntity
    {
        // this is foriegn key in basketitem table
        public virtual ICollection<BasketItem> BasketItems { get; set; }

        // constructor
        public Basket()
        {
            this.BasketItems = new List<BasketItem>();
        }

    }
}

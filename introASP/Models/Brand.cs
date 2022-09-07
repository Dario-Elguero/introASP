using System;
using System.Collections.Generic;

namespace introASP.Models
{
    public partial class Brand
    {
        public Brand()
        {
            Beersses = new HashSet<Beerss>();
        }

        public int BrandId { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<Beerss> Beersses { get; set; }
    }
}

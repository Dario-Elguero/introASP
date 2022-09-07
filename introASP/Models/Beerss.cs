using System;
using System.Collections.Generic;

namespace introASP.Models
{
    public partial class Beerss
    {
        public int BeerId { get; set; }
        public string? Name { get; set; }
        public int BrandId { get; set; }

        public virtual Brand Brand { get; set; } = null!;
    }
}

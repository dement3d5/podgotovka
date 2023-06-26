using System;
using System.Collections.Generic;

namespace podgotovka.Models
{
    public partial class Pizza
    {
        public int Id { get; set; }
        public string? Testo { get; set; }
        public string? Solt { get; set; }
        public string? Perets { get; set; }
    }
}

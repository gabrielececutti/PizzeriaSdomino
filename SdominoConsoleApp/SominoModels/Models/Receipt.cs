using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SominoModels.Models
{
    public class Receipt
    {
        public int Id { get; set; }
        public double TotalPrice { get; set; }
        public int OrderId { get; set; }
        public string? Description { get; set; }
    }
}

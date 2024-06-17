using DBconnection.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db_Connection.Data
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [ForeignKey("CustomerID")]
        public int CustomerId { get; set; }
        public DateTime? OrderDate { get; set; }
        public string TotalPrice { get; set; }
        public string items { get; set; }
        public virtual Customer Customer { get; set; }
    }
}

using Db_Connection.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBconnection.Data
{
    public enum _Gender { Male, Female }

    [Table("Customers")]
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string UserName { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }
        public _Gender Gender { get; set; }
        [Required]
        public string Phone_Number { get; set; }
        [Required]
        public string Address { get; set; }
        public string image { get; set; }

        public ICollection<Order> Orders { get; set; }

    }
}

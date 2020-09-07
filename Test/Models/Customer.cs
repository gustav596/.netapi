using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test.Models
{
    public class Customer
    {
        [Key]
        public int id { get; set; }

        [Column(TypeName ="nvarchar(100)")]
        public string Name { get; set; }

        public Country Country { get; set; }
    }
}

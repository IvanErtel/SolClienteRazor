using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ClienteRazor.Models
{
    public class Shipper
    {
        [Key]
        [DisplayName("Id")]
        public int ShipperID { get; set; }
        [Required]
        [StringLength(40)]
        [DisplayName("compañia de envio")]
        public string? CompanyName { get; set; }
        [StringLength(24)]
        public string? Phone { get; set; }
    }
}

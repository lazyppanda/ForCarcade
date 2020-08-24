using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForCarcade.Models
{
    public partial class Payment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PaymentId { get; set; }

        public DateTime PaymentDate { get; set; }

        [Column(TypeName = "money")]
        public decimal Sum { get; set; }

        public int? CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace Videly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        public MembershipType MembershipType { get; set; } //Navigation Property
        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }
        [Display(Name = "Date of Birth")]
        public DateTime? DateofBirth { get; set; }
    }
}
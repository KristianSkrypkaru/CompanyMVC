using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace Company.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage = "Fill the service name")]
        [Display(Name ="Service name")]
        public override string Title { get; set; }
        [Display(Name = "Short description of servicet")]
        public override string SubTitle { get; set; }
        [Display(Name = "Full description of service")]
        public override string Text { get; set; }
    }
}
